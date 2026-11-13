using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối mặc định của SQL Server Object Explorer (LocalDB) trong Visual Studio
        private readonly string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClinicDB;Integrated Security=True;";

        // Bảng tạm lưu danh sách thuốc bác sĩ đang chọn để kê đơn
        private DataTable dtDonTam = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDonViTinh.SelectedIndex = 0;
            KhoiTaoBangTam();
            LoadDanhSachHoSo();
            LoadDanhMucThuoc();
            LoadDanhSachDonThuoc();
        }

        private void KhoiTaoBangTam()
        {
            dtDonTam.Columns.Add("MaThuoc", typeof(int));
            dtDonTam.Columns.Add("TenThuoc", typeof(string));
            dtDonTam.Columns.Add("DonGia", typeof(decimal));
            dtDonTam.Columns.Add("SoLuong", typeof(int));
            dtDonTam.Columns.Add("ThanhTien", typeof(decimal));
            dtDonTam.Columns.Add("LieuDung", typeof(string));
            dgvChiTietTam.DataSource = dtDonTam;
        }

        // =========================================================================
        // CHỨC NĂNG 1A: TIẾP NHẬN BỆNH NHÂN & LẬP HỒ SƠ KHÁM
        // =========================================================================

        private void btnTimBN_Click(object sender, EventArgs e)
        {
            string sdt = txtTimSDT.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại cần tra cứu!", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT MaBN, HoTen, SoDienThoai, NamSinh FROM BenhNhan WHERE SoDienThoai = @SDT";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtMaBN.Text = reader["MaBN"].ToString();
                        txtHoTen.Text = reader["HoTen"].ToString();
                        txtSDT.Text = reader["SoDienThoai"].ToString();
                        txtNamSinh.Text = reader["NamSinh"].ToString();
                        MessageBox.Show("Đã tìm thấy bệnh nhân cũ! Bạn có thể lập Hồ sơ khám mới.", "Thông báo");
                    }
                    else
                    {
                        txtMaBN.Clear();
                        txtHoTen.Clear();
                        txtSDT.Text = sdt;
                        txtNamSinh.Clear();
                        MessageBox.Show("Bệnh nhân mới! Vui lòng nhập thông tin và bấm 'Lưu Bệnh nhân mới'.", "Thông báo");
                    }
                }
            }
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || !int.TryParse(txtNamSinh.Text, out int namSinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên, SĐT và Năm sinh hợp lệ!", "Cảnh báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string sql = @"INSERT INTO BenhNhan (HoTen, SoDienThoai, NamSinh)
                                   VALUES (@HoTen, @SDT, @NamSinh);
                                   SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                    cmd.Parameters.AddWithValue("@NamSinh", namSinh);

                    conn.Open();
                    int maBN = Convert.ToInt32(cmd.ExecuteScalar());
                    txtMaBN.Text = maBN.ToString();
                    MessageBox.Show("Thêm bệnh nhân mới thành công! Mã BN: " + maBN, "Thành công");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thêm bệnh nhân (có thể trùng SĐT): " + ex.Message, "Lỗi");
            }
        }

        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaBN.Text, out int maBN))
            {
                MessageBox.Show("Vui lòng tra cứu hoặc lưu thông tin bệnh nhân trước!", "Cảnh báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO HoSoKham (MaBN, TrieuChung) VALUES (@MaBN, @TrieuChung)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaBN", maBN);
                cmd.Parameters.AddWithValue("@TrieuChung", txtTrieuChung.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            txtTrieuChung.Clear();
            LoadDanhSachHoSo();
            MessageBox.Show("Đã tạo hồ sơ tiếp nhận khám thành công!", "Thành công");
        }

        private void LoadDanhSachHoSo()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT hs.MaHoSo, bn.HoTen, bn.SoDienThoai, hs.NgayKham, hs.TrieuChung, hs.ChanDoan,
                                      CAST(hs.MaHoSo AS NVARCHAR(10)) + ' - ' + bn.HoTen + ' (' + bn.SoDienThoai + ')' AS HienThi
                               FROM HoSoKham hs
                               INNER JOIN BenhNhan bn ON hs.MaBN = bn.MaBN
                               ORDER BY hs.MaHoSo DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHoSo.DataSource = dt;
                if (dgvHoSo.Columns["HienThi"] != null)
                    dgvHoSo.Columns["HienThi"].Visible = false;

                cboHoSoKham.DataSource = dt.Copy();
                cboHoSoKham.DisplayMember = "HienThi";
                cboHoSoKham.ValueMember = "MaHoSo";
            }
        }

        // =========================================================================
        // CHỨC NĂNG 1B: QUẢN LÝ DANH MỤC THUỐC (CRUD)
        // =========================================================================

        private void LoadDanhMucThuoc()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT MaThuoc, TenThuoc, DonViTinh, DonGia, SoLuongTon,
                                      TenThuoc + N' (Tồn: ' + CAST(SoLuongTon AS NVARCHAR(10)) + ' ' + DonViTinh + ')' AS HienThi
                               FROM Thuoc
                               ORDER BY MaThuoc DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvThuoc.DataSource = dt;
                if (dgvThuoc.Columns["HienThi"] != null)
                    dgvThuoc.Columns["HienThi"].Visible = false;

                cboThuocKeDon.DataSource = dt.Copy();
                cboThuocKeDon.DisplayMember = "HienThi";
                cboThuocKeDon.ValueMember = "MaThuoc";
            }
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];
                txtMaThuoc.Text = row.Cells["MaThuoc"].Value.ToString();
                txtTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                cboDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();
                txtNhapThem.Text = "0";
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThuoc.Text) ||
                !decimal.TryParse(txtDonGia.Text, out decimal donGia) ||
                !int.TryParse(txtSoLuongTon.Text, out int slTon) || slTon < 0)
            {
                MessageBox.Show("Vui lòng nhập Tên thuốc, Đơn giá và Tồn kho hợp lệ (>= 0)!", "Cảnh báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon) VALUES (@Ten, @DVT, @Gia, @Ton)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", txtTenThuoc.Text.Trim());
                cmd.Parameters.AddWithValue("@DVT", cboDonViTinh.Text);
                cmd.Parameters.AddWithValue("@Gia", donGia);
                cmd.Parameters.AddWithValue("@Ton", slTon);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadDanhMucThuoc();
            LamMoiInputThuoc();
            MessageBox.Show("Thêm thuốc mới thành công!", "Thành công");
        }

        private void btnCapNhatThuoc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaThuoc.Text, out int maThuoc) ||
                !decimal.TryParse(txtDonGia.Text, out decimal donGia) ||
                !int.TryParse(txtNhapThem.Text, out int nhapThem) || nhapThem < 0)
            {
                MessageBox.Show("Vui lòng chọn thuốc trong bảng và nhập Đơn giá, Số lượng nhập thêm (>= 0) hợp lệ!", "Cảnh báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"UPDATE Thuoc
                               SET DonGia = @Gia, SoLuongTon = SoLuongTon + @NhapThem
                               WHERE MaThuoc = @MaThuoc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Gia", donGia);
                cmd.Parameters.AddWithValue("@NhapThem", nhapThem);
                cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadDanhMucThuoc();
            LamMoiInputThuoc();
            MessageBox.Show("Đã cập nhật đơn giá và nhập thêm tồn kho!", "Thành công");
        }

        private void btnLamMoiThuoc_Click(object sender, EventArgs e)
        {
            LamMoiInputThuoc();
        }

        private void LamMoiInputThuoc()
        {
            txtMaThuoc.Clear();
            txtTenThuoc.Clear();
            txtDonGia.Clear();
            txtSoLuongTon.Clear();
            txtNhapThem.Text = "0";
        }

        // =========================================================================
        // CHỨC NĂNG 2: KÊ ĐƠN THUỐC & XUẤT KHO BẰNG SqlTransaction
        // =========================================================================

        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            if (cboThuocKeDon.SelectedItem == null) return;

            DataRowView drv = (DataRowView)cboThuocKeDon.SelectedItem;
            int maThuoc = Convert.ToInt32(drv["MaThuoc"]);
            string tenThuoc = drv["TenThuoc"].ToString();
            decimal donGia = Convert.ToDecimal(drv["DonGia"]);
            int soLuong = (int)nudSoLuong.Value;
            string lieuDung = txtLieuDung.Text.Trim();

            // Kiểm tra nếu thuốc đã có trong bảng tạm thì cộng dồn số lượng
            foreach (DataRow r in dtDonTam.Rows)
            {
                if ((int)r["MaThuoc"] == maThuoc)
                {
                    int slMoi = (int)r["SoLuong"] + soLuong;
                    r["SoLuong"] = slMoi;
                    r["ThanhTien"] = slMoi * donGia;
                    r["LieuDung"] = lieuDung;
                    return;
                }
            }

            dtDonTam.Rows.Add(maThuoc, tenThuoc, donGia, soLuong, soLuong * donGia, lieuDung);
        }

        private void btnXoaKhoiDon_Click(object sender, EventArgs e)
        {
            if (dgvChiTietTam.CurrentRow != null && !dgvChiTietTam.CurrentRow.IsNewRow)
            {
                dgvChiTietTam.Rows.RemoveAt(dgvChiTietTam.CurrentRow.Index);
            }
        }

        private void btnLuuXuatDon_Click(object sender, EventArgs e)
        {
            if (cboHoSoKham.SelectedValue == null)
            {
                MessageBox.Show("Chưa có hồ sơ khám nào được chọn!", "Cảnh báo");
                return;
            }
            if (dtDonTam.Rows.Count == 0)
            {
                MessageBox.Show("Đơn thuốc đang trống! Vui lòng thêm ít nhất 1 loại thuốc.", "Cảnh báo");
                return;
            }
            if (!decimal.TryParse(txtTienKham.Text, out decimal tienKham) || tienKham < 0)
            {
                MessageBox.Show("Tiền khám không hợp lệ!", "Cảnh báo");
                return;
            }

            int maHoSo = Convert.ToInt32(cboHoSoKham.SelectedValue);
            string chanDoan = txtChanDoan.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // 0. Cập nhật Chẩn đoán vào HoSoKham
                    string sqlUpdateHS = "UPDATE HoSoKham SET ChanDoan = @ChanDoan WHERE MaHoSo = @MaHoSo";
                    using (SqlCommand cmdHS = new SqlCommand(sqlUpdateHS, conn, trans))
                    {
                        cmdHS.Parameters.AddWithValue("@ChanDoan", chanDoan);
                        cmdHS.Parameters.AddWithValue("@MaHoSo", maHoSo);
                        cmdHS.ExecuteNonQuery();
                    }

                    // Tính tổng tiền thuốc
                    decimal tongTienThuoc = 0;
                    foreach (DataRow r in dtDonTam.Rows)
                    {
                        tongTienThuoc += Convert.ToDecimal(r["ThanhTien"]);
                    }
                    decimal tongTien = tienKham + tongTienThuoc;

                    // 1. Tạo bản ghi DonThuoc
                    string sqlDon = @"INSERT INTO DonThuoc (MaHoSo, TienKham, TongTien, TrangThai)
                                      VALUES (@MaHoSo, @TienKham, @TongTien, N'Chờ lấy thuốc');
                                      SELECT SCOPE_IDENTITY();";
                    int maDon;
                    using (SqlCommand cmdDon = new SqlCommand(sqlDon, conn, trans))
                    {
                        cmdDon.Parameters.AddWithValue("@MaHoSo", maHoSo);
                        cmdDon.Parameters.AddWithValue("@TienKham", tienKham);
                        cmdDon.Parameters.AddWithValue("@TongTien", tongTien);
                        maDon = Convert.ToInt32(cmdDon.ExecuteScalar());
                    }

                    // 2 & 3. Tạo ChiTietDonThuoc và Trừ tồn kho bảng Thuoc
                    foreach (DataRow r in dtDonTam.Rows)
                    {
                        int maThuoc = Convert.ToInt32(r["MaThuoc"]);
                        string tenThuoc = r["TenThuoc"].ToString();
                        int soLuong = Convert.ToInt32(r["SoLuong"]);
                        string lieuDung = r["LieuDung"].ToString();

                        // Kiểm tra và trừ tồn kho an toàn ngay trong Transaction
                        string sqlTruKho = @"UPDATE Thuoc
                                             SET SoLuongTon = SoLuongTon - @SoLuong
                                             WHERE MaThuoc = @MaThuoc AND SoLuongTon >= @SoLuong";
                        using (SqlCommand cmdTru = new SqlCommand(sqlTruKho, conn, trans))
                        {
                            cmdTru.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdTru.Parameters.AddWithValue("@MaThuoc", maThuoc);

                            int rowsAffected = cmdTru.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                // Ném lỗi để nhảy vào catch và thực hiện trans.Rollback()
                                throw new Exception($"Thuốc '{tenThuoc}' không đủ số lượng tồn trong kho (cần {soLuong})!");
                            }
                        }

                        string sqlCT = @"INSERT INTO ChiTietDonThuoc (MaDon, MaThuoc, SoLuong, LieuDung)
                                         VALUES (@MaDon, @MaThuoc, @SoLuong, @LieuDung)";
                        using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@MaDon", maDon);
                            cmdCT.Parameters.AddWithValue("@MaThuoc", maThuoc);
                            cmdCT.Parameters.AddWithValue("@SoLuong", soLuong);
                            cmdCT.Parameters.AddWithValue("@LieuDung", lieuDung);
                            cmdCT.ExecuteNonQuery();
                        }
                    }

                    // Thành công toàn bộ -> Commit
                    trans.Commit();

                    dtDonTam.Clear();
                    txtChanDoan.Clear();
                    LoadDanhMucThuoc();
                    LoadDanhSachHoSo();
                    LoadDanhSachDonThuoc();

                    MessageBox.Show($"Lưu & xuất đơn thuốc #{maDon} thành công! Tồn kho đã được trừ.", "Thành công");
                }
                catch (Exception ex)
                {
                    try { trans.Rollback(); } catch { }
                    MessageBox.Show("Cảnh báo - Đã hủy giao dịch (Rollback):\n" + ex.Message, "Không thể xuất đơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // =========================================================================
        // CHỨC NĂNG 3: THANH TOÁN & IN HÓA ĐƠN
        // =========================================================================

        private void LoadDanhSachDonThuoc()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"SELECT dt.MaDon, dt.MaHoSo, bn.HoTen AS BenhNhan, hs.ChanDoan,
                                      dt.TienKham, dt.TongTien, dt.TrangThai
                               FROM DonThuoc dt
                               INNER JOIN HoSoKham hs ON dt.MaHoSo = hs.MaHoSo
                               INNER JOIN BenhNhan bn ON hs.MaBN = bn.MaBN
                               ORDER BY dt.MaDon DESC";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDonThuoc.DataSource = dt;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvDonThuoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một đơn thuốc để thanh toán!", "Thông báo");
                return;
            }

            int maDon = Convert.ToInt32(dgvDonThuoc.CurrentRow.Cells["MaDon"].Value);
            string trangThai = dgvDonThuoc.CurrentRow.Cells["TrangThai"].Value.ToString();

            if (trangThai == "Đã thanh toán")
            {
                MessageBox.Show("Đơn thuốc này đã được thanh toán trước đó!", "Thông báo");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // 1. Lấy thông tin đơn & tính tổng chi phí = TienKham + Tổng(SoLuong * DonGia)
                string sqlChiTiet = @"SELECT t.TenThuoc, t.DonViTinh, ct.SoLuong, t.DonGia,
                                             (ct.SoLuong * t.DonGia) AS ThanhTien, ct.LieuDung
                                      FROM ChiTietDonThuoc ct
                                      INNER JOIN Thuoc t ON ct.MaThuoc = t.MaThuoc
                                      WHERE ct.MaDon = @MaDon";
                SqlCommand cmdCT = new SqlCommand(sqlChiTiet, conn);
                cmdCT.Parameters.AddWithValue("@MaDon", maDon);

                decimal tienKham = Convert.ToDecimal(dgvDonThuoc.CurrentRow.Cells["TienKham"].Value);
                string benhNhan = dgvDonThuoc.CurrentRow.Cells["BenhNhan"].Value.ToString();
                string chanDoan = dgvDonThuoc.CurrentRow.Cells["ChanDoan"].Value.ToString();

                decimal tongTienThuoc = 0;
                StringBuilder sbHoaDon = new StringBuilder();
                sbHoaDon.AppendLine("========== HÓA ĐƠN PHÒNG KHÁM ==========");
                sbHoaDon.AppendLine($"Mã đơn: #{maDon}");
                sbHoaDon.AppendLine($"Bệnh nhân: {benhNhan}");
                sbHoaDon.AppendLine($"Chẩn đoán: {chanDoan}");
                sbHoaDon.AppendLine("-----------------------------------------");
                sbHoaDon.AppendLine("Chi tiết thuốc:");

                using (SqlDataReader r = cmdCT.ExecuteReader())
                {
                    while (r.Read())
                    {
                        decimal thanhTien = Convert.ToDecimal(r["ThanhTien"]);
                        tongTienThuoc += thanhTien;
                        sbHoaDon.AppendLine($"- {r["TenThuoc"]} ({r["SoLuong"]} {r["DonViTinh"]} x {Convert.ToDecimal(r["DonGia"]):N0}) = {thanhTien:N0} đ");
                        sbHoaDon.AppendLine($"  Liều dùng: {r["LieuDung"]}");
                    }
                }

                decimal tongChiPhi = tienKham + tongTienThuoc;
                sbHoaDon.AppendLine("-----------------------------------------");
                sbHoaDon.AppendLine($"Tiền khám:   {tienKham:N0} VNĐ");
                sbHoaDon.AppendLine($"Tiền thuốc:  {tongTienThuoc:N0} VNĐ");
                sbHoaDon.AppendLine($"TỔNG CỘNG:   {tongChiPhi:N0} VNĐ");
                sbHoaDon.AppendLine("Trạng thái:  Đã thanh toán");
                sbHoaDon.AppendLine("=========================================");

                // 2. Cập nhật TongTien chính xác và chuyển trạng thái -> "Đã thanh toán"
                string sqlUpdate = @"UPDATE DonThuoc
                                     SET TongTien = @TongTien, TrangThai = N'Đã thanh toán'
                                     WHERE MaDon = @MaDon";
                SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                cmdUp.Parameters.AddWithValue("@TongTien", tongChiPhi);
                cmdUp.Parameters.AddWithValue("@MaDon", maDon);
                cmdUp.ExecuteNonQuery();

                LoadDanhSachDonThuoc();
                MessageBox.Show(sbHoaDon.ToString(), "In Hóa Đơn Thanh Toán");
            }
        }
    }
}