USE QL_GDCP
GO
--Drop if exist
IF OBJECT_ID(N'dbo.LICHSUGIA', N'U') IS NOT NULL
BEGIN
    DROP TABLE LICHSUGIA
END

IF OBJECT_ID(N'dbo.SOHUU', N'U') IS NOT NULL
BEGIN
    DROP TABLE SOHUU
END

IF OBJECT_ID(N'dbo.LENHKHOP', N'U') IS NOT NULL
BEGIN
    DROP TABLE LENHKHOP
END

IF OBJECT_ID(N'dbo.LENHDAT', N'U') IS NOT NULL
BEGIN
    DROP TABLE LENHDAT
END

IF OBJECT_ID(N'dbo.COPHIEU', N'U') IS NOT NULL
BEGIN
    DROP TABLE COPHIEU
END

IF OBJECT_ID(N'dbo.TAIKHOAN_NGANHANG', N'U') IS NOT NULL
BEGIN
    DROP TABLE TAIKHOAN_NGANHANG
END

IF OBJECT_ID(N'dbo.NGANHANG', N'U') IS NOT NULL
BEGIN
    DROP TABLE NGANHANG
END

IF OBJECT_ID(N'dbo.NHANVIEN', N'U') IS NOT NULL
BEGIN
    DROP TABLE NHANVIEN
END

IF OBJECT_ID(N'dbo.NDT', N'U') IS NOT NULL
BEGIN
    DROP TABLE NDT
END

--Create table
CREATE TABLE NDT(
	MaNDT varchar(20) PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL,
	MKGD varchar(50) NOT NULL,
	DiaChi nvarchar(max) NOT NULL,
	Phone varchar(15) NOT NULL,
	CMND varchar(10) NOT NULL,
	GioiTinh varchar(10) NOT NULL,
	Email varchar(50) NOT NULL
);

CREATE TABLE NHANVIEN(
	MaNV varchar(20) PRIMARY KEY,
	HoTen nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL,
	DiaChi nvarchar(max) NOT NULL,
	Phone varchar(15) NOT NULL,
	CMND varchar(10) NOT NULL,
	GioiTinh varchar(10) NOT NULL,
	Email varchar(50) NOT NULL
);

CREATE TABLE NGANHANG(
	MaNH varchar(20) PRIMARY KEY,
	TenNH nvarchar(50) NOT NULL,
	DiaChi nvarchar(max) NOT NULL,
	Phone varchar(10) NOT NULL,
	Email varchar(50) NOT NULL
);

CREATE TABLE TAIKHOAN_NGANHANG(
	MaTK varchar(20) PRIMARY KEY,
	MaNDT varchar(20) NOT NULL FOREIGN KEY REFERENCES NDT(MaNDT),
	MaNH varchar(20) NOT NULL FOREIGN KEY REFERENCES NGANHANG(MaNH),
	SoTien float 
);

CREATE TABLE COPHIEU(
	MaCP varchar(10) PRIMARY KEY,
	TenCty nvarchar(50) NOT NULL,
	DiaChi nvarchar(max) NOT NULL,
	SoLuongPH int NOT NULL
);

CREATE TABLE LENHDAT(
	MaGD int IDENTITY(1,1) PRIMARY KEY,
	NgayGD datetime NOT NULL,
	LoaiLenh varchar(1) NOT NULL,
	PhuongThuc varchar(2) NOT NULL,
	SoLuong int NOT NULL,
	MaCP varchar(10) NOT NULL FOREIGN KEY REFERENCES COPHIEU(MaCP),
	Gia float NOT NULL,
	MaNDT varchar(20) NOT NULL FOREIGN KEY REFERENCES NDT(MaNDT),
	MaTK varchar(20) NOT NULL FOREIGN KEY REFERENCES TAIKHOAN_NGANHANG(MaTK),
	TrangThai varchar(10) NOT NULL,
	CONSTRAINT kt_LoaiLenh CHECK (LoaiLenh='M' or LoaiLenh='B'),
	CONSTRAINT kt_PhuongThuc CHECK (PhuongThuc='LO' or PhuongThuc='MB'),
	CONSTRAINT kt_TrangThai CHECK (TrangThai='HUY' or TrangThai='CHUA' or TrangThai='MOTPHAN' or TrangThai='HET' or TrangThai='CHO')
);

CREATE TABLE LENHKHOP(
	MaLK int IDENTITY(1,1) PRIMARY KEY,
	MaGD int NOT NULL FOREIGN KEY REFERENCES LENHDAT(MaGD),
	NgayGioKhop datetime NOT NULL,
	SoLuongKhop int NOT NULL,
	GiaKhop float NOT NULL,
	KieuKhop varchar(20) NOT NULL,
	CONSTRAINT kt_KieuKhop CHECK (KieuKhop='MOTPHAN' or KieuKhop='KHOPHET')
);

CREATE TABLE SOHUU(
	MaNDT varchar(20) NOT NULL FOREIGN KEY REFERENCES NDT(MaNDT),
	MaCP varchar(10) NOT NULL FOREIGN KEY REFERENCES COPHIEU(MaCP),
	SoLuong int NOT NULL
	PRIMARY KEY (MaNDT, MaCP)
);

CREATE TABLE LICHSUGIA(
	MaCP varchar(10) NOT NULL FOREIGN KEY REFERENCES COPHIEU(MaCP),
	Ngay datetime NOT NULL,
	GiaTran float NOT NULL,
	GiaSan float NOT NULL,
	GiaTC float NOT NULL
	PRIMARY KEY (MaCP, Ngay)
);

--Create Database Role
--Create NHANVIEN, DNT roles
CREATE ROLE NHANVIEN
CREATE ROLE NDT

EXEC sp_addrolemember'db_datareader', 'NHANVIEN'
EXEC sp_addrolemember 'db_datareader', 'NDT'

EXEC sp_addrolemember 'db_datawriter', 'NHANVIEN'
EXEC sp_addrolemember 'db_datawriter', 'NDT'

--Create ADMIN Role
CREATE ROLE ADMIN
EXEC sp_addrolemember 'db_backupoperator', 'ADMIN'

EXEC SP_ADDLOGIN 'trongtuan', '1234','QL_GDCP'
EXEC SP_GRANTDBACCESS 'trongtuan', 'trongtuan'
EXEC sp_addrolemember ADMIN, 'trongtuan'

--Server role
EXEC sp_addsrvrolemember 'trongtuan', 'SecurityAdmin'
EXEC sp_addsrvrolemember 'trongtuan', 'DBCreator'
EXEC sp_addsrvrolemember 'trongtuan', 'ProcessAdmin'

--Add Execute sp permission
GRANT EXECUTE TO NHANVIEN
GRANT EXECUTE TO NDT
GRANT EXECUTE TO ADMIN

--Craete NDT
EXEC SP_ADDLOGIN 'linhdan', '1234','QL_GDCP'
EXEC SP_GRANTDBACCESS 'linhdan', '111111'
EXEC sp_addrolemember NDT, '111111'

EXEC SP_ADDLOGIN 'giabao', '1234','QL_GDCP'
EXEC SP_GRANTDBACCESS 'giabao', '222222'
EXEC sp_addrolemember NDT, '222222'

EXEC SP_ADDLOGIN 'phucdien', '1234','QL_GDCP'
EXEC SP_GRANTDBACCESS 'phucdien', 'nv1111'
EXEC sp_addrolemember NHANVIEN, 'nv1111'
--Create temp data
INSERT INTO NDT VALUES('111111', N'Huỳnh Thị Linh Đan', '1995-01-01', '1234', 'HCM', '0163288176', '312233178', 'Nu', 'linhdan@gmail.com')
INSERT INTO NDT VALUES('222222', N'Nguyễn Gia Bảo', '1995-01-01', '1234', 'HCM', '0163288177', '312233177', 'Nam', 'giabao@gmail.com')
INSERT INTO NDT VALUES('333333', N'Lê Thị Dạ Thi', '1995-02-01', '1234', 'HCM', '0163288276', '312234178', 'Nu', 'dathi@gmail.com')

INSERT INTO NHANVIEN VALUES('nv1111', N'Cao Phúc Điền', '1995-03-01', 'HCM', '0163288577', '312633177', 'Nam', 'phucdien@gmail.com')

INSERT INTO NGANHANG VALUES('vcb', 'Vietcombank', 'HCM', '086312778', 'vcb@gmail.com')
INSERT INTO NGANHANG VALUES('vtb', 'Vietinbank', 'HCM', '086312779', 'vtb@gmail.com')
INSERT INTO NGANHANG VALUES('acb', N'Á Châu Bank', 'HCM', '086312879', 'acb@gmail.com')
INSERT INTO NGANHANG VALUES('agb', 'Agribank', 'HCM', '086312789', 'agb@gmail.com')

INSERT INTO TAIKHOAN_NGANHANG VALUES('tk1', '111111', 'vcb', 100000)
INSERT INTO TAIKHOAN_NGANHANG VALUES('tk2', '111111', 'vtb', 50000)
INSERT INTO TAIKHOAN_NGANHANG VALUES('tk3', '111111', 'vcb', 25000)
INSERT INTO TAIKHOAN_NGANHANG VALUES('tk4', '222222', 'vcb', 100000)
INSERT INTO TAIKHOAN_NGANHANG VALUES('tk5', '222222', 'vtb', 25000)
INSERT INTO TAIKHOAN_NGANHANG VALUES('tk6', '333333', 'vcb', 25000)

INSERT INTO COPHIEU VALUES('ACB', 'ACB', 'HCM', 100000000)
INSERT INTO COPHIEU VALUES('ABI', 'ABIC', 'HCM', 100000000)
INSERT INTO COPHIEU VALUES('ACE', 'ACECO', 'HCM', 100000000)

INSERT INTO SOHUU VALUES('111111', 'ACB', 100000)
INSERT INTO SOHUU VALUES('111111', 'ABI', 50000)
INSERT INTO SOHUU VALUES('111111', 'ACE', 75000)

INSERT INTO SOHUU VALUES('222222', 'ACB', 60000)
INSERT INTO SOHUU VALUES('222222', 'ABI', 20000)

INSERT INTO SOHUU VALUES('333333', 'ABI', 10000)

INSERT INTO LICHSUGIA VALUES('ACB', CONVERT(Datetime, '2017-06-14 00:00:00', 120), 26.9, 26.5, 26.7)
INSERT INTO LICHSUGIA VALUES('ABI', CONVERT(Datetime, '2017-06-14 00:00:00', 120), 32, 30, 31)
INSERT INTO LICHSUGIA VALUES('ACE', CONVERT(Datetime, '2017-06-14 00:00:00', 120), 32, 24, 27)