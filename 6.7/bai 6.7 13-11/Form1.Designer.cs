namespace ClinicManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTiepNhan = new System.Windows.Forms.TabPage();
            this.dgvHoSo = new System.Windows.Forms.DataGridView();
            this.grpHoSo = new System.Windows.Forms.GroupBox();
            this.btnTaoHoSo = new System.Windows.Forms.Button();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBenhNhan = new System.Windows.Forms.GroupBox();
            this.btnThemBN = new System.Windows.Forms.Button();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimBN = new System.Windows.Forms.Button();
            this.txtTimSDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabThuoc = new System.Windows.Forms.TabPage();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.grpThuoc = new System.Windows.Forms.GroupBox();
            this.btnLamMoiThuoc = new System.Windows.Forms.Button();
            this.btnCapNhatThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.txtNhapThem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabKeDon = new System.Windows.Forms.TabPage();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.btnLuuXuatDon = new System.Windows.Forms.Button();
            this.dgvChiTietTam = new System.Windows.Forms.DataGridView();
            this.grpChonThuoc = new System.Windows.Forms.GroupBox();
            this.btnXoaKhoiDon = new System.Windows.Forms.Button();
            this.btnThemVaoDon = new System.Windows.Forms.Button();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cboThuocKeDon = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grpChonHoSo = new System.Windows.Forms.GroupBox();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboHoSoKham = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();

            this.tabControl1.SuspendLayout();
            this.tabTiepNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).BeginInit();
            this.grpHoSo.SuspendLayout();
            this.grpBenhNhan.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.tabThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.grpThuoc.SuspendLayout();
            this.tabKeDon.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).BeginInit();
            this.grpChonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.grpChonHoSo.SuspendLayout();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabTiepNhan);
            this.tabControl1.Controls.Add(this.tabThuoc);
            this.tabControl1.Controls.Add(this.tabKeDon);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 620);
            this.tabControl1.TabIndex = 0;

            // ================= TAB 1: TIẾP NHẬN =================
            this.tabTiepNhan.Controls.Add(this.dgvHoSo);
            this.tabTiepNhan.Controls.Add(this.grpHoSo);
            this.tabTiepNhan.Controls.Add(this.grpBenhNhan);
            this.tabTiepNhan.Controls.Add(this.grpTimKiem);
            this.tabTiepNhan.Location = new System.Drawing.Point(4, 26);
            this.tabTiepNhan.Name = "tabTiepNhan";
            this.tabTiepNhan.Padding = new System.Windows.Forms.Padding(6);
            this.tabTiepNhan.Size = new System.Drawing.Size(952, 590);
            this.tabTiepNhan.TabIndex = 0;
            this.tabTiepNhan.Text = "1. Tiếp nhận & Hồ sơ khám";
            this.tabTiepNhan.UseVisualStyleBackColor = true;

            // grpTimKiem
            this.grpTimKiem.Controls.Add(this.btnTimBN);
            this.grpTimKiem.Controls.Add(this.txtTimSDT);
            this.grpTimKiem.Controls.Add(this.label6);
            this.grpTimKiem.Location = new System.Drawing.Point(12, 10);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(928, 65);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tra cứu bệnh nhân theo Số điện thoại";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Text = "Số điện thoại:";

            this.txtTimSDT.Location = new System.Drawing.Point(115, 25);
            this.txtTimSDT.Size = new System.Drawing.Size(220, 24);

            this.btnTimBN.Location = new System.Drawing.Point(350, 23);
            this.btnTimBN.Size = new System.Drawing.Size(130, 28);
            this.btnTimBN.Text = "Tra cứu (SĐT)";
            this.btnTimBN.UseVisualStyleBackColor = true;
            this.btnTimBN.Click += new System.EventHandler(this.btnTimBN_Click);

            // grpBenhNhan
            this.grpBenhNhan.Controls.Add(this.btnThemBN);
            this.grpBenhNhan.Controls.Add(this.txtNamSinh);
            this.grpBenhNhan.Controls.Add(this.label4);
            this.grpBenhNhan.Controls.Add(this.txtSDT);
            this.grpBenhNhan.Controls.Add(this.label3);
            this.grpBenhNhan.Controls.Add(this.txtHoTen);
            this.grpBenhNhan.Controls.Add(this.label2);
            this.grpBenhNhan.Controls.Add(this.txtMaBN);
            this.grpBenhNhan.Controls.Add(this.label1);
            this.grpBenhNhan.Location = new System.Drawing.Point(12, 85);
            this.grpBenhNhan.Size = new System.Drawing.Size(450, 195);
            this.grpBenhNhan.TabStop = false;
            this.grpBenhNhan.Text = "Thông tin Bệnh nhân";

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Text = "Mã BN:";
            this.txtMaBN.Location = new System.Drawing.Point(120, 27);
            this.txtMaBN.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(100, 24);

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Text = "Họ và tên:";
            this.txtHoTen.Location = new System.Drawing.Point(120, 62);
            this.txtHoTen.Size = new System.Drawing.Size(300, 24);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Text = "Số điện thoại:";
            this.txtSDT.Location = new System.Drawing.Point(120, 97);
            this.txtSDT.Size = new System.Drawing.Size(180, 24);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Text = "Năm sinh:";
            this.txtNamSinh.Location = new System.Drawing.Point(120, 132);
            this.txtNamSinh.Size = new System.Drawing.Size(100, 24);

            this.btnThemBN.Location = new System.Drawing.Point(260, 130);
            this.btnThemBN.Size = new System.Drawing.Size(160, 32);
            this.btnThemBN.Text = "Lưu Bệnh nhân mới";
            this.btnThemBN.UseVisualStyleBackColor = true;
            this.btnThemBN.Click += new System.EventHandler(this.btnThemBN_Click);

            // grpHoSo
            this.grpHoSo.Controls.Add(this.btnTaoHoSo);
            this.grpHoSo.Controls.Add(this.txtTrieuChung);
            this.grpHoSo.Controls.Add(this.label5);
            this.grpHoSo.Location = new System.Drawing.Point(478, 85);
            this.grpHoSo.Size = new System.Drawing.Size(462, 195);
            this.grpHoSo.TabStop = false;
            this.grpHoSo.Text = "Lập Hồ sơ tiếp nhận khám";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Text = "Triệu chứng ban đầu:";

            this.txtTrieuChung.Location = new System.Drawing.Point(16, 55);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Size = new System.Drawing.Size(430, 80);

            this.btnTaoHoSo.Location = new System.Drawing.Point(276, 145);
            this.btnTaoHoSo.Size = new System.Drawing.Size(170, 34);
            this.btnTaoHoSo.Text = "Tạo Hồ sơ khám";
            this.btnTaoHoSo.UseVisualStyleBackColor = true;
            this.btnTaoHoSo.Click += new System.EventHandler(this.btnTaoHoSo_Click);

            // dgvHoSo
            this.dgvHoSo.AllowUserToAddRows = false;
            this.dgvHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoSo.Location = new System.Drawing.Point(12, 290);
            this.dgvHoSo.ReadOnly = true;
            this.dgvHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoSo.Size = new System.Drawing.Size(928, 285);

            // ================= TAB 2: DANH MỤC THUỐC =================
            this.tabThuoc.Controls.Add(this.dgvThuoc);
            this.tabThuoc.Controls.Add(this.grpThuoc);
            this.tabThuoc.Location = new System.Drawing.Point(4, 26);
            this.tabThuoc.Padding = new System.Windows.Forms.Padding(6);
            this.tabThuoc.Size = new System.Drawing.Size(952, 590);
            this.tabThuoc.TabIndex = 1;
            this.tabThuoc.Text = "2. Danh mục Thuốc";
            this.tabThuoc.UseVisualStyleBackColor = true;

            this.grpThuoc.Controls.Add(this.btnLamMoiThuoc);
            this.grpThuoc.Controls.Add(this.btnCapNhatThuoc);
            this.grpThuoc.Controls.Add(this.btnThemThuoc);
            this.grpThuoc.Controls.Add(this.txtNhapThem);
            this.grpThuoc.Controls.Add(this.label12);
            this.grpThuoc.Controls.Add(this.txtSoLuongTon);
            this.grpThuoc.Controls.Add(this.label11);
            this.grpThuoc.Controls.Add(this.txtDonGia);
            this.grpThuoc.Controls.Add(this.label10);
            this.grpThuoc.Controls.Add(this.cboDonViTinh);
            this.grpThuoc.Controls.Add(this.label9);
            this.grpThuoc.Controls.Add(this.txtTenThuoc);
            this.grpThuoc.Controls.Add(this.label8);
            this.grpThuoc.Controls.Add(this.txtMaThuoc);
            this.grpThuoc.Controls.Add(this.label7);
            this.grpThuoc.Location = new System.Drawing.Point(12, 10);
            this.grpThuoc.Size = new System.Drawing.Size(928, 175);
            this.grpThuoc.TabStop = false;
            this.grpThuoc.Text = "Thông tin Thuốc & Nhập kho";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 30);
            this.label7.Text = "Mã thuốc:";
            this.txtMaThuoc.Location = new System.Drawing.Point(110, 27);
            this.txtMaThuoc.ReadOnly = true;
            this.txtMaThuoc.Size = new System.Drawing.Size(90, 24);

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 30);
            this.label8.Text = "Tên thuốc:";
            this.txtTenThuoc.Location = new System.Drawing.Point(300, 27);
            this.txtTenThuoc.Size = new System.Drawing.Size(320, 24);

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 30);
            this.label9.Text = "ĐVT:";
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.Items.AddRange(new object[] { "Viên", "Vỉ", "Chai", "Hộp", "Gói" });
            this.cboDonViTinh.Location = new System.Drawing.Point(685, 27);
            this.cboDonViTinh.Size = new System.Drawing.Size(120, 24);

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 75);
            this.label10.Text = "Đơn giá:";
            this.txtDonGia.Location = new System.Drawing.Point(110, 72);
            this.txtDonGia.Size = new System.Drawing.Size(140, 24);

            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 75);
            this.label11.Text = "Tồn hiện tại:";
            this.txtSoLuongTon.Location = new System.Drawing.Point(360, 72);
            this.txtSoLuongTon.Size = new System.Drawing.Size(110, 24);

            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(495, 75);
            this.label12.Text = "Nhập thêm SL:";
            this.txtNhapThem.Location = new System.Drawing.Point(600, 72);
            this.txtNhapThem.Size = new System.Drawing.Size(110, 24);
            this.txtNhapThem.Text = "0";

            this.btnThemThuoc.Location = new System.Drawing.Point(110, 120);
            this.btnThemThuoc.Size = new System.Drawing.Size(150, 34);
            this.btnThemThuoc.Text = "Thêm thuốc mới";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);

            this.btnCapNhatThuoc.Location = new System.Drawing.Point(280, 120);
            this.btnCapNhatThuoc.Size = new System.Drawing.Size(210, 34);
            this.btnCapNhatThuoc.Text = "Cập nhật giá & Nhập kho";
            this.btnCapNhatThuoc.UseVisualStyleBackColor = true;
            this.btnCapNhatThuoc.Click += new System.EventHandler(this.btnCapNhatThuoc_Click);

            this.btnLamMoiThuoc.Location = new System.Drawing.Point(510, 120);
            this.btnLamMoiThuoc.Size = new System.Drawing.Size(120, 34);
            this.btnLamMoiThuoc.Text = "Làm mới";
            this.btnLamMoiThuoc.UseVisualStyleBackColor = true;
            this.btnLamMoiThuoc.Click += new System.EventHandler(this.btnLamMoiThuoc_Click);

            this.dgvThuoc.AllowUserToAddRows = false;
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.Location = new System.Drawing.Point(12, 195);
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(928, 380);
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);

            // ================= TAB 3: KÊ ĐƠN & THANH TOÁN =================
            this.tabKeDon.Controls.Add(this.grpThanhToan);
            this.tabKeDon.Controls.Add(this.btnLuuXuatDon);
            this.tabKeDon.Controls.Add(this.dgvChiTietTam);
            this.tabKeDon.Controls.Add(this.grpChonThuoc);
            this.tabKeDon.Controls.Add(this.grpChonHoSo);
            this.tabKeDon.Location = new System.Drawing.Point(4, 26);
            this.tabKeDon.Padding = new System.Windows.Forms.Padding(6);
            this.tabKeDon.Size = new System.Drawing.Size(952, 590);
            this.tabKeDon.TabIndex = 2;
            this.tabKeDon.Text = "3. Kê đơn & Thanh toán";
            this.tabKeDon.UseVisualStyleBackColor = true;

            // grpChonHoSo
            this.grpChonHoSo.Controls.Add(this.txtTienKham);
            this.grpChonHoSo.Controls.Add(this.label15);
            this.grpChonHoSo.Controls.Add(this.txtChanDoan);
            this.grpChonHoSo.Controls.Add(this.label14);
            this.grpChonHoSo.Controls.Add(this.cboHoSoKham);
            this.grpChonHoSo.Controls.Add(this.label13);
            this.grpChonHoSo.Location = new System.Drawing.Point(12, 8);
            this.grpChonHoSo.Size = new System.Drawing.Size(928, 95);
            this.grpChonHoSo.TabStop = false;
            this.grpChonHoSo.Text = "Thông tin khám & Chẩn đoán";

            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 25);
            this.label13.Text = "Hồ sơ khám:";
            this.cboHoSoKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoSoKham.Location = new System.Drawing.Point(105, 22);
            this.cboHoSoKham.Size = new System.Drawing.Size(440, 24);

            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(570, 25);
            this.label15.Text = "Tiền khám (VNĐ):";
            this.txtTienKham.Location = new System.Drawing.Point(690, 22);
            this.txtTienKham.Size = new System.Drawing.Size(150, 24);
            this.txtTienKham.Text = "100000";

            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 60);
            this.label14.Text = "Chẩn đoán:";
            this.txtChanDoan.Location = new System.Drawing.Point(105, 57);
            this.txtChanDoan.Size = new System.Drawing.Size(735, 24);

            // grpChonThuoc
            this.grpChonThuoc.Controls.Add(this.btnXoaKhoiDon);
            this.grpChonThuoc.Controls.Add(this.btnThemVaoDon);
            this.grpChonThuoc.Controls.Add(this.txtLieuDung);
            this.grpChonThuoc.Controls.Add(this.label18);
            this.grpChonThuoc.Controls.Add(this.nudSoLuong);
            this.grpChonThuoc.Controls.Add(this.label17);
            this.grpChonThuoc.Controls.Add(this.cboThuocKeDon);
            this.grpChonThuoc.Controls.Add(this.label16);
            this.grpChonThuoc.Location = new System.Drawing.Point(12, 110);
            this.grpChonThuoc.Size = new System.Drawing.Size(928, 95);
            this.grpChonThuoc.TabStop = false;
            this.grpChonThuoc.Text = "Chọn thuốc kê đơn";

            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 28);
            this.label16.Text = "Chọn thuốc:";
            this.cboThuocKeDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuocKeDon.Location = new System.Drawing.Point(105, 25);
            this.cboThuocKeDon.Size = new System.Drawing.Size(340, 24);

            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(465, 28);
            this.label17.Text = "Số lượng:";
            this.nudSoLuong.Location = new System.Drawing.Point(535, 25);
            this.nudSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuong.Size = new System.Drawing.Size(75, 24);
            this.nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 62);
            this.label18.Text = "Liều dùng:";
            this.txtLieuDung.Location = new System.Drawing.Point(105, 59);
            this.txtLieuDung.Size = new System.Drawing.Size(505, 24);
            this.txtLieuDung.Text = "Sáng 1, Chiều 1 sau ăn";

            this.btnThemVaoDon.Location = new System.Drawing.Point(635, 23);
            this.btnThemVaoDon.Size = new System.Drawing.Size(130, 60);
            this.btnThemVaoDon.Text = "Thêm vào đơn";
            this.btnThemVaoDon.UseVisualStyleBackColor = true;
            this.btnThemVaoDon.Click += new System.EventHandler(this.btnThemVaoDon_Click);

            this.btnXoaKhoiDon.Location = new System.Drawing.Point(775, 23);
            this.btnXoaKhoiDon.Size = new System.Drawing.Size(135, 60);
            this.btnXoaKhoiDon.Text = "Xóa dòng chọn";
            this.btnXoaKhoiDon.UseVisualStyleBackColor = true;
            this.btnXoaKhoiDon.Click += new System.EventHandler(this.btnXoaKhoiDon_Click);

            // dgvChiTietTam
            this.dgvChiTietTam.AllowUserToAddRows = false;
            this.dgvChiTietTam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietTam.Location = new System.Drawing.Point(12, 212);
            this.dgvChiTietTam.ReadOnly = true;
            this.dgvChiTietTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietTam.Size = new System.Drawing.Size(730, 145);

            // btnLuuXuatDon
            this.btnLuuXuatDon.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLuuXuatDon.ForeColor = System.Drawing.Color.White;
            this.btnLuuXuatDon.Location = new System.Drawing.Point(755, 212);
            this.btnLuuXuatDon.Size = new System.Drawing.Size(185, 145);
            this.btnLuuXuatDon.Text = "Lưu & Xuất đơn\n(SqlTransaction)";
            this.btnLuuXuatDon.UseVisualStyleBackColor = false;
            this.btnLuuXuatDon.Click += new System.EventHandler(this.btnLuuXuatDon_Click);

            // grpThanhToan
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.Controls.Add(this.dgvDonThuoc);
            this.grpThanhToan.Location = new System.Drawing.Point(12, 365);
            this.grpThanhToan.Size = new System.Drawing.Size(928, 212);
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Danh sách Đơn thuốc & Thanh toán";

            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonThuoc.Location = new System.Drawing.Point(12, 24);
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(730, 175);

            this.btnThanhToan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(755, 24);
            this.btnThanhToan.Size = new System.Drawing.Size(160, 175);
            this.btnThanhToan.Text = "Thanh toán &\nIn Hóa đơn";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 6.7 - Quản Lý Phòng Khám & Kê Đơn Thuốc";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.tabControl1.ResumeLayout(false);
            this.tabTiepNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoSo)).EndInit();
            this.grpHoSo.ResumeLayout(false);
            this.grpHoSo.PerformLayout();
            this.grpBenhNhan.ResumeLayout(false);
            this.grpBenhNhan.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.tabThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.grpThuoc.ResumeLayout(false);
            this.grpThuoc.PerformLayout();
            this.tabKeDon.ResumeLayout(false);
            this.grpThanhToan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).EndInit();
            this.grpChonThuoc.ResumeLayout(false);
            this.grpChonThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.grpChonHoSo.ResumeLayout(false);
            this.grpChonHoSo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTiepNhan;
        private System.Windows.Forms.TabPage tabThuoc;
        private System.Windows.Forms.TabPage tabKeDon;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Button btnTimBN;
        private System.Windows.Forms.TextBox txtTimSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBenhNhan;
        private System.Windows.Forms.Button btnThemBN;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpHoSo;
        private System.Windows.Forms.Button btnTaoHoSo;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHoSo;
        private System.Windows.Forms.GroupBox grpThuoc;
        private System.Windows.Forms.Button btnLamMoiThuoc;
        private System.Windows.Forms.Button btnCapNhatThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.TextBox txtNhapThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.GroupBox grpChonHoSo;
        private System.Windows.Forms.TextBox txtTienKham;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboHoSoKham;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpChonThuoc;
        private System.Windows.Forms.Button btnXoaKhoiDon;
        private System.Windows.Forms.Button btnThemVaoDon;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboThuocKeDon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvChiTietTam;
        private System.Windows.Forms.Button btnLuuXuatDon;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.DataGridView dgvDonThuoc;
        private System.Windows.Forms.Button btnThanhToan;
    }
}