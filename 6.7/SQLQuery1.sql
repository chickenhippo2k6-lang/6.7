USE ClinicDB;
GO

-- 1. Bảng Bệnh nhân
CREATE TABLE BenhNhan (
    MaBN INT PRIMARY KEY IDENTITY(1,1),
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE,
    NamSinh INT
);

-- 2. Bảng Hồ sơ khám
CREATE TABLE HoSoKham (
    MaHoSo INT PRIMARY KEY IDENTITY(1,1),
    MaBN INT NOT NULL FOREIGN KEY REFERENCES BenhNhan(MaBN),
    NgayKham DATETIME DEFAULT GETDATE(),
    TrieuChung NVARCHAR(MAX),
    ChanDoan NVARCHAR(250)
);

-- 3. Bảng Thuốc
CREATE TABLE Thuoc (
    MaThuoc INT PRIMARY KEY IDENTITY(1,1),
    TenThuoc NVARCHAR(150) NOT NULL,
    DonViTinh NVARCHAR(20),
    DonGia DECIMAL(18,2) NOT NULL,
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
);

-- 4. Bảng Đơn thuốc
CREATE TABLE DonThuoc (
    MaDon INT PRIMARY KEY IDENTITY(1,1),
    MaHoSo INT NOT NULL FOREIGN KEY REFERENCES HoSoKham(MaHoSo),
    TienKham DECIMAL(18,2) NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL
);

-- 5. Bảng Chi tiết đơn thuốc
CREATE TABLE ChiTietDonThuoc (
    MaDon INT NOT NULL FOREIGN KEY REFERENCES DonThuoc(MaDon),
    MaThuoc INT NOT NULL FOREIGN KEY REFERENCES Thuoc(MaThuoc),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    LieuDung NVARCHAR(100),
    PRIMARY KEY (MaDon, MaThuoc)
);
GO

-- Dữ liệu mẫu để test nhanh
INSERT INTO BenhNhan (HoTen, SoDienThoai, NamSinh) VALUES
(N'Nguyễn Văn An', '0901234567', 1995),
(N'Trần Thị Bình', '0912345678', 1988);

INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon) VALUES
(N'Paracetamol 500mg', N'Viên', 1500, 100),
(N'Amoxicillin 500mg', N'Vỉ', 15000, 50),
(N'Siro Ho Bảo Thanh', N'Chai', 55000, 20),
(N'Vitamin C 1000mg', N'Viên', 2000, 5); -- Cố tình để ít để dễ test Rollback
GO