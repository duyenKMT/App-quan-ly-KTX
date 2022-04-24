--Bảng sinh viên
	CREATE TABLE SinhVien
(
	Masv varchar(20) NOT NULL
	CONSTRAINT Pk_SinhVien PRIMARY KEY,
	Hodem nvarchar(20) NULL,
	Ten nvarchar(50) NULL,
	Ngaysinh date NULL,
	GioiTinh nvarchar(3) NOT NULL,
	CMND varchar(20) NULL,
	SDT varchar(20) NULL,
	Khoa nvarchar(20) NULL,
	Lop varchar(10) NULL,
)
--Bảng quản lý
CREATE TABLE QuanLy
(
	Maquanly varchar(20) NOT NULL
	CONSTRAINT Pk_QuanLy PRIMARY KEY,
	Hoten nvarchar(50) NULL,
	Ngaysinh date NULL,
	Diachi nvarchar(50) NULL,
	SDT varchar(20) NULL
 )

--Bảng Phòng
CREATE TABLE Phong
(
	Maphong varchar(10) NOT NULL
	CONSTRAINT PK_Phong PRIMARY KEY,
	Sophong int NULL,
	Khunha char(3) NULL,
	LoaiPhong nvarchar(3) NOT NULL,
	SoluongSV int NOT NULL,
	TinhTrang bit NOT NULL
 )
 --Bảng hợp đồng
 CREATE TABLE HopDong
 (
	Mahopdong varchar(20) NOT NULL
	CONSTRAINT PK_HopDong PRIMARY KEY,
	Masv varchar(20) NOT NULL,
	Maquanly varchar(20) NOT NULL,
	Maphong varchar(10) NOT NULL,
	Ngaylap date NULL,
	Ngaybatdau date NULL,
	Ngayketthuc date NULL
)
--Bảng Hóa đơn Điện nước
CREATE TABLE HoaDonDienNuoc
(
	Mahoadon int NOT NULL
	CONSTRAINT [PK_HoaDonDienNuoc] PRIMARY KEY,
	Maquanly varchar(20) NOT NULL,
	Maphong varchar(10) NOT NULL,
	Ngaylap date NULL,
	Thang varchar(7) NOT NULL,
	CSDdien int NULL,
	CSCdien int NULL,
	CSDnuoc int NULL,
	CSCnuoc int NULL,
	Tongtien money NOT NULL,
  
)
--Bảng Hóa đơn phòng
CREATE TABLE HoaDonPhong(
	Mahoadon int  NOT NULL
	CONSTRAINT PK_HoaDonPhong PRIMARY KEY,
	Masv varchar(20) NOT NULL,
	MaPhong varchar(10) NOT NULL,
	Thang varchar(7) NOT NULL,
	Sotien money NOT NULL,
	Ngaylap date NULL
 
 )
