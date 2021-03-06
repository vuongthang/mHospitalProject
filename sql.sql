USE [master]
GO
/****** Object:  Database [QUANLYBENHVIEN]    Script Date: 6/30/2015 11:04:24 AM ******/
CREATE DATABASE [QUANLYBENHVIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYBENHVIEN', FILENAME = N'F:\QUANLYBENHVIEN.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYBENHVIEN_log', FILENAME = N'F:\QUANLYBENHVIEN_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYBENHVIEN] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYBENHVIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYBENHVIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYBENHVIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYBENHVIEN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QUANLYBENHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[BenhNhanInsert]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanInsert]
(
	@MaBenhNhan nvarchar(10),
	@TenBenhNhan nvarchar(20),
	@CMND nchar(20),
	@NgaySinh datetime,
	@DiaChi nvarchar(100),
	@SDT nchar(20),
	@GioiTinh nvarchar(10),
	@MaPhongKham nvarchar(10)
)
AS
BEGIN
	INSERT INTO BenhNhan(MaBenhNhan, TenBenhNhan, CMND, NgaySinh, DiaChi, SDT, GioiTinh, MaPhongKham, Flag)
	VALUES(@MaBenhNhan, @TenBenhNhan, @CMND, @NgaySinh, @DiaChi, @SDT, @GioiTinh, @MaPhongKham, '1')
END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanSearch]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanSearch]
(
	@temp nvarchar(10)

)
AS
BEGIN
	SELECT MaBenhNhan, TenBenhNhan, CMND, NgaySinh, DiaChi, SDT,GioiTinh, PhongKham.TenPhongKham
	FROM BenhNhan inner join PhongKham on BenhNhan.MaPhongKham = PhongKham.MaPhongKham
	WHERE MaBenhNhan= @temp OR TenBenhNhan like '%'+@temp+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanSearch1]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanSearch1]
(
	@temp nvarchar(10)
)
AS
BEGIN
	SELECT MaBenhNhan, TenBenhNhan, PhongKham.TenPhongKham
	FROM BenhNhan inner join PhongKham on BenhNhan.MaPhongKham = PhongKham.MaPhongKham
	WHERE BenhNhan.Flag = '1' AND (MaBenhNhan= @temp OR TenBenhNhan like '%'+@temp+'%')
END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanSearch2]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanSearch2]
(
	@temp nvarchar(10)
)
AS
BEGIN
	SELECT KhamBenh.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham
	FROM KhamBenh INNER JOIN BenhNhan ON KhamBenh.MaBenhNhan = BenhNhan.MaBenhNhan
	     INNER JOIN PhongKham on KhamBenh.MaPhongKham = PhongKham.MaPhongKham
	WHERE KhamBenh.Flag = '1' AND (KhamBenh.MaBenhNhan= @temp OR BenhNhan.TenBenhNhan like '%'+@temp+'%')
END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanSelectAll]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanSelectAll]

AS
BEGIN
	SELECT MaBenhNhan, TenBenhNhan, CMND, NgaySinh, DiaChi, SDT,GioiTinh, PhongKham.TenPhongKham
	FROM BenhNhan inner join PhongKham on BenhNhan.MaPhongKham = PhongKham.MaPhongKham

END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanSelectByFlag]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanSelectByFlag]

AS
BEGIN
	SELECT MaBenhNhan, TenBenhNhan, PhongKham.TenPhongKham 
	FROM BenhNhan inner join PhongKham on BenhNhan.MaPhongKham = PhongKham.MaPhongKham
	WHERE BenhNhan.Flag = '1'
END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanSelectByID]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanSelectByID]
(
	@MaBenhNhan nvarchar(10)

)
AS
BEGIN
	SELECT MaBenhNhan, TenBenhNhan, CMND, CONVERT(VARCHAR(11),NgaySinh,106) AS NgaySinh, DiaChi, SDT, GioiTinh, PhongKham.TenPhongKham
	FROM BenhNhan INNER JOIN PhongKham ON BenhNhan.MaPhongKham = PhongKham.MaPhongKham
	WHERE MaBenhNhan= @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[BenhNhanUpDate]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BenhNhanUpDate]
(
	@MaBenhNhan nvarchar(10),
	@TenBenhNhan nvarchar(20),
	@CMND nchar(20),
	@NgaySinh datetime,
	@DiaChi nvarchar(100),
	@SDT nchar(20),
	@MaPhongKham nvarchar(10)
)
AS
BEGIN
	UPDATE BenhNhan SET TenBenhNhan= @TenBenhNhan, CMND= @CMND, NgaySinh= @NgaySinh, DiaChi= @DiaChi, SDT= @SDT, MaPhongKham= @MaPhongKham
	WHERE MaBenhNhan = @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[BNDangKhamSelect]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BNDangKhamSelect]
AS
BEGIN
	SELECT KhamBenh.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham
	FROM KhamBenh INNER JOIN BenhNhan ON KhamBenh.MaBenhNhan = BenhNhan.MaBenhNhan
	     INNER JOIN PhongKham on KhamBenh.MaPhongKham = PhongKham.MaPhongKham
	WHERE KhamBenh.Flag = '1'
END

GO
/****** Object:  StoredProcedure [dbo].[CanLamSangCheckSearch]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CanLamSangCheckSearch]
(
	@temp NVARCHAR(50),
	@stt NVARCHAR(50)
)
AS
BEGIN
	SELECT MaChiTietCanLamSang, ChiTietCanLamSang.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham, 
			TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien, BacSiChiDinh, TrangThai
	FROM ChiTietCanLamSang INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
			INNER JOIN BenhNhan ON ChiTietCanLamSang.MaBenhNhan = BenhNhan.MaBenhNhan
	WHERE ChiTietCanLamSang.TrangThai = @stt AND (ChiTietCanLamSang.MaBenhNhan = @temp OR BenhNhan.TenBenhNhan LIKE '%'+@temp+'%')
END

GO
/****** Object:  StoredProcedure [dbo].[CanLamSangSearch]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CanLamSangSearch]
(
	@temp NVARCHAR(50)
)
AS
BEGIN
	SELECT MaChiTietCanLamSang, ChiTietCanLamSang.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham, 
			TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien, BacSiChiDinh, TrangThai
	FROM ChiTietCanLamSang INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
			INNER JOIN BenhNhan ON ChiTietCanLamSang.MaBenhNhan = BenhNhan.MaBenhNhan
	WHERE ChiTietCanLamSang.MaBenhNhan = @temp OR BenhNhan.TenBenhNhan LIKE '%'+@temp+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[CanLamSangSelectByFlag]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CanLamSangSelectByFlag]
(
	@TrangThai nvarchar(10)
)
AS
BEGIN
	SELECT MaChiTietCanLamSang, ChiTietCanLamSang.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham, 
			TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien, BacSiChiDinh, TrangThai
	FROM ChiTietCanLamSang INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
			INNER JOIN BenhNhan ON ChiTietCanLamSang.MaBenhNhan = BenhNhan.MaBenhNhan
	WHERE ChiTietCanLamSang.TrangThai = @TrangThai
END

GO
/****** Object:  StoredProcedure [dbo].[ChiDinhCLSDelete]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiDinhCLSDelete]
(
	@MaChiTietCanLamSang nvarchar(10)

)
AS
BEGIN
	DELETE FROM ChiTietCanLamSang WHERE MaChiTietCanLamSang= @MaChiTietCanLamSang
END

GO
/****** Object:  StoredProcedure [dbo].[ChiDinhCLSInsert]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiDinhCLSInsert]
(
	@MaChiTietCanLamSang nvarchar(10),
	@MaBenhNhan nvarchar(10),
	@MaPhongKham nvarchar(10),
	@TenXetNghiem nvarchar(50),
	@ThoiGianThucHien datetime,
	@BacSiChiDinh nvarchar(20)
)
AS
BEGIN
	INSERT INTO ChiTietCanLamSang(MaChiTietCanLamSang, MaBenhNhan, MaPhongKham, TenXetNghiem, ThoiGianThucHien, BacSiChiDinh)
	VALUES(@MaChiTietCanLamSang, @MaBenhNhan, @MaPhongKham, @TenXetNghiem, @ThoiGianThucHien,@BacSiChiDinh)
END

GO
/****** Object:  StoredProcedure [dbo].[ChiDinhCLSSelectByMaBN]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiDinhCLSSelectByMaBN]
(
	@MaBenhNhan nvarchar(10)

)
AS
BEGIN
	SELECT MaChiTietCanLamSang, PhongKham.TenPhongKham, TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien, BacSiChiDinh
	FROM ChiTietCanLamSang INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
	WHERE MaBenhNhan = @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[ChiDinhCLSUpDate]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiDinhCLSUpDate]
(
	@MaChiTietCanLamSang nvarchar(10),
	@MaBenhNhan nvarchar(10),
	@MaPhongKham nvarchar(10),
	@TenXetNghiem nvarchar(50),
	@ThoiGianThucHien datetime,
	@BacSiChiDinh nvarchar(20)
)
AS
BEGIN
	UPDATE ChiTietCanLamSang SET MaBenhNhan= @MaBenhNhan, MaPhongKham= @MaPhongKham, TenXetNghiem= @TenXetNghiem, ThoiGianThucHien= @ThoiGianThucHien, BacSiChiDinh= @BacSiChiDinh
	WHERE MaChiTietCanLamSang = @MaChiTietCanLamSang
END

GO
/****** Object:  StoredProcedure [dbo].[ChiTietCanLamSangSelectAll]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTietCanLamSangSelectAll]

AS
BEGIN
	SELECT MaChiTietCanLamSang, ChiTietCanLamSang.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham, 
			TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien, BacSiChiDinh, TrangThai
	FROM ChiTietCanLamSang INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
			INNER JOIN BenhNhan ON ChiTietCanLamSang.MaBenhNhan = BenhNhan.MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[ChiTietCanLamSangUpDate]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTietCanLamSangUpDate]
(
	@MaChiTietCanLamSang nvarchar(10),
	@ThoiGianLayMau datetime,
	@ThoiGianTraKQ datetime,
	@BacSiThucHien nvarchar(20),
	@KetQuaCLS nvarchar(200),
	@NhanVienNhapLieu nvarchar(20)
)
AS
BEGIN
	UPDATE ChiTietCanLamSang SET ThoiGianLayMau= @ThoiGianLayMau, ThoiGianTraKQ= @ThoiGianTraKQ, 
		   BacSiThucHien= @BacSiThucHien, KetQuaCLS= @KetQuaCLS, NhanVienNhapLieu= @NhanVienNhapLieu,TrangThai= '1'
	WHERE MaChiTietCanLamSang = @MaChiTietCanLamSang
END

GO
/****** Object:  StoredProcedure [dbo].[ChiTietDonThuocDelete]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTietDonThuocDelete]
(
	@MaChiTietDonThuoc int

)
AS
BEGIN
	DELETE FROM ChiTietDonThuoc WHERE MaChiTietDonThuoc= @MaChiTietDonThuoc
END

GO
/****** Object:  StoredProcedure [dbo].[ChiTietDonThuocInsert]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTietDonThuocInsert]
(
	@MaDonThuoc nvarchar(10),
	@MaThuoc nvarchar(10),
	@LieuDung nvarchar(MAX),
	@SoLuongThuoc nvarchar(50)
)
AS
BEGIN
	INSERT INTO ChiTietDonThuoc(MaDonThuoc, MaThuoc, LieuDung, SoLuongThuoc)
	VALUES(@MaDonThuoc, @MaThuoc, @LieuDung, @SoLuongThuoc)
END

GO
/****** Object:  StoredProcedure [dbo].[ChiTietDonThuocSelectBN]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChiTietDonThuocSelectBN]
(
	@MaBenhNhan NVARCHAR(10)
)
AS
BEGIN
	SELECT MaChiTietDonThuoc, Thuoc.TenThuoc, LieuDung, SoLuongThuoc 
	FROM ChiTietDonThuoc INNER JOIN Thuoc ON ChiTietDonThuoc.MaThuoc = Thuoc.MaThuoc
		 INNER JOIN DonThuoc ON ChiTietDonThuoc.MaDonThuoc = DonThuoc.MaDonThuoc
	WHERE DonThuoc.MaBenhNhan = @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[DonThuocInsert]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DonThuocInsert]
(
	@MaDonThuoc nvarchar(10),
	@TenBacSiKeDon nvarchar(20),
	@MaBenhNhan nvarchar(10),
	@NgayLapDonThuoc datetime,
	@NoiDungDonThuoc nvarchar(500),
	@GhiChu nvarchar(50)
)
AS
BEGIN
	INSERT INTO DonThuoc(MaDonThuoc, TenBacSiKeDon, MaBenhNhan, NgayLapDonThuoc, NoiDungDonThuoc, GhiChu)
	VALUES(@MaDonThuoc, @TenBacSiKeDon, @MaBenhNhan, @NgayLapDonThuoc, @NoiDungDonThuoc, @GhiChu)
END

GO
/****** Object:  StoredProcedure [dbo].[DonThuocSelectAll]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DonThuocSelectAll]

AS
BEGIN
	SELECT * 
	FROM DonThuoc
END

GO
/****** Object:  StoredProcedure [dbo].[DonThuocSelectByMaBN]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DonThuocSelectByMaBN]
(
	@MaBenhNhan NVARCHAR(10)
)
AS
BEGIN
	SELECT MaDonThuoc, TenBacSiKeDon, NgayLapDonThuoc, NoiDungDonThuoc, GhiChu
	FROM DonThuoc
	WHERE MaBenhNhan = @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[DonThuocUpDate]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DonThuocUpDate]
(
	@MaDonThuoc nvarchar(10),
	@TenBacSiKeDon nvarchar(20),
	@MaBenhNhan nvarchar(10),
	@NgayLapDonThuoc datetime,
	@NoiDungDonThuoc nvarchar(500),
	@GhiChu nvarchar(50)
)
AS
BEGIN
	UPDATE DonThuoc SET TenBacSiKeDon= @TenBacSiKeDon, MaBenhNhan= @MaBenhNhan, NgayLapDonThuoc= @NgayLapDonThuoc, NoiDungDonThuoc= @NoiDungDonThuoc, GhiChu= @GhiChu
	WHERE MaDonThuoc = @MaDonThuoc
END

GO
/****** Object:  StoredProcedure [dbo].[KetQuaCLSSelectAll]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KetQuaCLSSelectAll]

AS
BEGIN
	SELECT MaChiTietCanLamSang, ChiTietCanLamSang.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham,
	       BacSiChiDinh, TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien,
		   BacSiThucHien, CONVERT(VARCHAR(11),ThoiGianLayMau,106) AS NgayLayMau, 
		   CONVERT(VARCHAR(11),ThoiGianTraKQ,106) AS NgayTraKQ, NhanVienNhapLieu, KetQuaCLS, TrangThai
	FROM ChiTietCanLamSang INNER JOIN BenhNhan ON ChiTietCanLamSang.MaBenhNhan = BenhNhan.MaBenhNhan
	     INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
END

GO
/****** Object:  StoredProcedure [dbo].[KetQuaCLSSelectByID]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KetQuaCLSSelectByID]
(
	@MaCLS NVARCHAR(10)
)
AS
BEGIN
	SELECT MaChiTietCanLamSang, ChiTietCanLamSang.MaBenhNhan, BenhNhan.TenBenhNhan, PhongKham.TenPhongKham,
	       BacSiChiDinh, TenXetNghiem, CONVERT(VARCHAR(11),ThoiGianThucHien,106) AS NgayThucHien,
		   BacSiThucHien, CONVERT(VARCHAR(11),ThoiGianLayMau,106) AS NgayLayMau, 
		   CONVERT(VARCHAR(11),ThoiGianTraKQ,106) AS NgayTraKQ, NhanVienNhapLieu, KetQuaCLS, TrangThai
	FROM ChiTietCanLamSang INNER JOIN BenhNhan ON ChiTietCanLamSang.MaBenhNhan = BenhNhan.MaBenhNhan
	     INNER JOIN PhongKham ON ChiTietCanLamSang.MaPhongKham = PhongKham.MaPhongKham
	WHERE ChiTietCanLamSang.MaChiTietCanLamSang = @MaCLS
END

GO
/****** Object:  StoredProcedure [dbo].[KhamBenhInsert]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KhamBenhInsert]
(
	@MaKhamBenh nvarchar(10),
	@TenBacSi nvarchar(50),
	@MaBenhNhan nvarchar(10),
	@TenNguoiNhapLieu nvarchar(50),
	@ThoiGianKham datetime,
	@ChuanDoan nvarchar(200),
	@TrieuChung nvarchar(200)
)
AS
BEGIN
	INSERT INTO KhamBenh(MaKhamBenh, TenBacSi, MaBenhNhan, TenNguoiNhapLieu, ThoiGianKham, ChuanDoan, TrieuChung, Flag)
	VALUES(@MaKhamBenh, @TenBacSi, @MaBenhNhan, @TenNguoiNhapLieu, @ThoiGianKham, @ChuanDoan, @TrieuChung, '1')
END

GO
/****** Object:  StoredProcedure [dbo].[KhamBenhSelectByID]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KhamBenhSelectByID]
(
	@MaKhambenh nvarchar(10)

)
AS
BEGIN
	SELECT MaKhambenh, MaBenhNhan, TenBacSi, CONVERT(VARCHAR(11),ThoiGianKham,106) AS NgayKham, TrieuChung, ChuanDoan, TenNguoiNhapLieu
	FROM KhamBenh 
	WHERE MaKhambenh = @MaKhambenh
END

GO
/****** Object:  StoredProcedure [dbo].[KhamBenhSelectByIdBN]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KhamBenhSelectByIdBN]
(
	@MaBenhNhan nvarchar(10)

)
AS
BEGIN
	SELECT MaKhambenh, MaBenhNhan, TenBacSi, CONVERT(VARCHAR(11),ThoiGianKham,106) AS NgayKham, TrieuChung, ChuanDoan, TenNguoiNhapLieu
	FROM KhamBenh 
	WHERE MaBenhNhan= @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[KhamBenhUpDate]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KhamBenhUpDate]
(
	@MaKhamBenh nvarchar(10),
	@TenBacSi nvarchar(50),
	@MaBenhNhan nvarchar(10),
	@TenNguoiNhapLieu nvarchar(50),
	@ThoiGianKham datetime,
	@ChuanDoan nvarchar(200),
	@TrieuChung nvarchar(200)
)
AS
BEGIN
	UPDATE KhamBenh SET TenBacSi= @TenBacSi, TenNguoiNhapLieu= @TenNguoiNhapLieu, ThoiGianKham= @ThoiGianKham, ChuanDoan= @ChuanDoan, TrieuChung= @TrieuChung
	WHERE MaKhamBenh = @MaKhamBenh AND MaBenhNhan= @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[KT_DonThuocBenhNhan]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KT_DonThuocBenhNhan]
(
	@MaBenhNhan NVARCHAR(10)
)
AS
BEGIN
	SELECT MaBenhNhan 
	FROM DonThuoc
	WHERE DonThuoc.MaBenhNhan = @MaBenhNhan
END

GO
/****** Object:  StoredProcedure [dbo].[KT_MaDonThuoc]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KT_MaDonThuoc]
(
	@MaDonThuoc NVARCHAR(10)
)
AS
BEGIN
	SELECT MaDonThuoc
	FROM DonThuoc
	WHERE MaDonThuoc = @MaDonThuoc
END


GO
/****** Object:  StoredProcedure [dbo].[LoadCLS]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadCLS]
(
	@MaBenhNhan NVARCHAR(10)
)
AS
BEGIN
	SELECT MaChiTietCanLamSang, TenXetNghiem, TrangThai 
	FROM ChiTietCanLamSang
	WHERE MaBenhNhan = @MaBenhNhan

END

GO
/****** Object:  StoredProcedure [dbo].[PhongKhamSelect]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PhongKhamSelect]

AS
BEGIN
	SELECT * FROM PhongKham
	WHERE Flag = '1'
END

GO
/****** Object:  StoredProcedure [dbo].[PhongKhamSelectAll]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PhongKhamSelectAll]

AS
BEGIN
	SELECT * FROM PhongKham
END

GO
/****** Object:  StoredProcedure [dbo].[PhongKhamSelectByID]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PhongKhamSelectByID]
(
	@MaPhongKham nvarchar(10)

)
AS
BEGIN
	SELECT * FROM PhongKham WHERE MaPhongKham= @MaPhongKham
END

GO
/****** Object:  StoredProcedure [dbo].[ThuocDelete]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThuocDelete]
(
	@MaThuoc nvarchar(10)

)
AS
BEGIN
	DELETE FROM Thuoc WHERE MaThuoc= @MaThuoc
END


GO
/****** Object:  StoredProcedure [dbo].[ThuocInsert]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThuocInsert]
(
	@MaThuoc nvarchar(10),
	@TenThuoc nvarchar(100),
	@SoLuong nvarchar(50),
	@HanSuDung nvarchar(50),
	@CachSuDung nvarchar(MAX),
	@GiaThuoc int
)
AS
BEGIN
	INSERT INTO Thuoc(MaThuoc, TenThuoc, SoLuong, HanSuDung, CachSuDung, GiaThuoc)
	VALUES(@MaThuoc, @TenThuoc, @SoLuong, @HanSuDung, @CachSuDung, @GiaThuoc)
END


GO
/****** Object:  StoredProcedure [dbo].[ThuocSearch]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThuocSearch]
(
	@MaThuoc nvarchar(100)
)
AS
BEGIN
	SELECT * FROM Thuoc WHERE MaThuoc= @MaThuoc or TenThuoc like '%'+@MaThuoc+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[ThuocSelectAll]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThuocSelectAll]

AS
BEGIN
	SELECT * FROM Thuoc
END


GO
/****** Object:  StoredProcedure [dbo].[ThuocSelectMaThuoc]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThuocSelectMaThuoc]
(
	@TenThuoc nvarchar(50)
)
AS
BEGIN
	SELECT MaThuoc
	FROM Thuoc 
	WHERE TenThuoc = @TenThuoc
END

GO
/****** Object:  StoredProcedure [dbo].[ThuocSelectTop5]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ThuocSelectTop5]
(
	@TenThuoc nvarchar(50)
)
AS
BEGIN
	SELECT TOP 5 MaThuoc, TenThuoc 
	FROM Thuoc 
	WHERE TenThuoc LIKE '%'+@TenThuoc+'%'
END




GO
/****** Object:  StoredProcedure [dbo].[ThuocUpDate]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThuocUpDate]
(
	@MaThuoc nvarchar(10),
	@TenThuoc nvarchar(100),
	@SoLuong nvarchar(50),
	@HanSuDung nvarchar(50),
	@CachSuDung nvarchar(MAX),
	@GiaThuoc int
)
AS
BEGIN
	UPDATE Thuoc SET TenThuoc= @TenThuoc, SoLuong= @SoLuong, HanSuDung= @HanSuDung, CachSuDung= @CachSuDung, GiaThuoc= @GiaThuoc
	WHERE MaThuoc = @MaThuoc
END


GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBenhNhan] [nvarchar](10) NOT NULL,
	[TenBenhNhan] [nvarchar](20) NULL,
	[CMND] [nchar](20) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [nchar](20) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[MaPhongKham] [nvarchar](10) NULL,
	[Flag] [nchar](1) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietCanLamSang]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietCanLamSang](
	[MaChiTietCanLamSang] [nvarchar](10) NOT NULL,
	[MaBenhNhan] [nvarchar](10) NULL,
	[MaPhongKham] [nvarchar](10) NULL,
	[TenXetNghiem] [nvarchar](50) NULL,
	[ThoiGianThucHien] [datetime] NOT NULL,
	[ThoiGianLayMau] [datetime] NULL,
	[ThoiGianTraKQ] [datetime] NULL,
	[BacSiChiDinh] [nvarchar](20) NULL,
	[BacSiThucHien] [nvarchar](20) NULL,
	[KetQuaCLS] [nvarchar](200) NULL,
	[NhanVienNhapLieu] [nvarchar](20) NULL,
	[MaDichVu] [nvarchar](10) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaCLS] [nvarchar](10) NULL,
 CONSTRAINT [PK_CanLamSang] PRIMARY KEY CLUSTERED 
(
	[MaChiTietCanLamSang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietDonThuoc]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonThuoc](
	[MaChiTietDonThuoc] [int] IDENTITY(1,1) NOT NULL,
	[MaDonThuoc] [nvarchar](10) NULL,
	[MaThuoc] [nvarchar](10) NULL,
	[LieuDung] [nvarchar](max) NULL,
	[SoLuongThuoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietDonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaChiTietDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaCTHoaDon] [nvarchar](10) NOT NULL,
	[MaHoaDon] [nvarchar](10) NULL,
	[DanhMucThuPhi] [nvarchar](30) NULL,
	[SoLuong_SoLan] [nvarchar](50) NULL,
	[SoTien] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaCTHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoSoBenhNhanNgoaiTru]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoSoBenhNhanNgoaiTru](
	[MaChiTietHSBNNgoaiTru] [nvarchar](10) NOT NULL,
	[MaHoSoBNNgoaiTru] [nvarchar](10) NOT NULL,
	[NgayKham] [datetime] NULL,
	[TinhTrangBenh] [nvarchar](50) NULL,
	[NoiDungChiDinh] [nvarchar](500) NULL,
	[MaDichVu] [nvarchar](10) NULL,
 CONSTRAINT [PK_ChiTietHoSoBenhNhanNgoaiTru] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHSBNNgoaiTru] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CLamSang]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLamSang](
	[MaCanLamSang] [nvarchar](10) NOT NULL,
	[TenCanLamSang] [nvarchar](50) NULL,
	[MaBenhNhan] [nvarchar](10) NULL,
 CONSTRAINT [PK_CLamSang] PRIMARY KEY CLUSTERED 
(
	[MaCanLamSang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [nvarchar](10) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[GiaDichVu] [nvarchar](20) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonThuoc]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonThuoc](
	[MaDonThuoc] [nvarchar](10) NOT NULL,
	[TenBacSiKeDon] [nvarchar](20) NULL,
	[MaBenhNhan] [nvarchar](10) NULL,
	[NgayLapDonThuoc] [datetime] NULL,
	[NoiDungDonThuoc] [nvarchar](500) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaBenhNhan] [nvarchar](10) NULL,
	[NgayThu] [datetime] NULL,
	[TongSoTienHoaDon] [int] NULL,
	[DaThanhToan] [int] NULL,
	[DoiTuongBenhNhan] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoSoBenhNhanNgoaiTru]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoBenhNhanNgoaiTru](
	[MaHoSoBNNgoaiTru] [nvarchar](10) NOT NULL,
	[MaBenhNhan] [nvarchar](10) NOT NULL,
	[NgayKham] [datetime] NULL,
	[SoNgayDieuTriNgoaiTru] [int] NULL,
	[Benh] [nvarchar](50) NULL,
	[KetQuaDieuTri] [nvarchar](200) NULL,
 CONSTRAINT [PK_HoSoBenhNhanNgoaiTru] PRIMARY KEY CLUSTERED 
(
	[MaHoSoBNNgoaiTru] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhamBenh]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhamBenh](
	[MaKhamBenh] [nvarchar](10) NOT NULL,
	[TenBacSi] [nvarchar](50) NULL,
	[MaBenhNhan] [nvarchar](10) NOT NULL,
	[TenNguoiNhapLieu] [nvarchar](50) NULL,
	[ChiDinhCanLamSang] [nvarchar](50) NULL,
	[ChiDinhDichVu] [nvarchar](500) NULL,
	[MaDonThuoc] [nvarchar](10) NULL,
	[ThoiGianKham] [datetime] NULL,
	[MaPhongKham] [nvarchar](10) NULL,
	[ChuanDoan] [nvarchar](200) NULL,
	[TrieuChung] [nvarchar](200) NULL,
	[Flag] [nchar](1) NULL,
 CONSTRAINT [PK_KhamBenh] PRIMARY KEY CLUSTERED 
(
	[MaKhamBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongKham]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongKham](
	[MaPhongKham] [nvarchar](10) NOT NULL,
	[TenPhongKham] [nvarchar](50) NULL,
	[Flag] [nchar](1) NULL,
 CONSTRAINT [PK_PhongKham] PRIMARY KEY CLUSTERED 
(
	[MaPhongKham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 6/30/2015 11:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [nvarchar](10) NOT NULL,
	[TenThuoc] [nvarchar](100) NULL,
	[SoLuong] [nvarchar](50) NULL,
	[HanSuDung] [nvarchar](50) NULL,
	[CachSuDung] [nvarchar](max) NULL,
	[GiaThuoc] [int] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'1', N'1', N'1                   ', CAST(0x0000A4AA00000000 AS DateTime), N'1', N'1                   ', N'1', N'P001', N'1')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'BN001', N'Nguyễn An', N'017098123           ', CAST(0x000084B000000000 AS DateTime), N'Cầu Giấy - Hà Nội', N'0982345627          ', N'Nam', N'P001', NULL)
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'BN002', N'Nguyễn Ngọc Anh', N'012225321           ', CAST(0x0000809C00000000 AS DateTime), N'Hải Dương', N'0971878809          ', N'Nam', N'P001', N'1')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'BN003', N'Ngô Thúy Hồng', N'012224326           ', CAST(0x000080A600000000 AS DateTime), N'Thái Bình', N'0964378021          ', N'Nữ', N'P001', N'1')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'BN004', N'Hoàng Quý Hồng An', N'012225478           ', CAST(0x0000806800000000 AS DateTime), N'Thái Nguyên', N'01669871004         ', N'Nam', N'P002', N'1')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'BN005', N'Nguyễn Đức Hải', N'189019781           ', CAST(0x00007CCD00000000 AS DateTime), N'Thanh Hóa', N'01682209882         ', N'Nam', N'P002', N'1')
INSERT [dbo].[BenhNhan] ([MaBenhNhan], [TenBenhNhan], [CMND], [NgaySinh], [DiaChi], [SDT], [GioiTinh], [MaPhongKham], [Flag]) VALUES (N'BN006', N'Vuong Thang', N'017107527           ', CAST(0x0000A4AA00000000 AS DateTime), N'Ha Noi', N'                    ', N'Nam', N'P001', N'1')
INSERT [dbo].[ChiTietCanLamSang] ([MaChiTietCanLamSang], [MaBenhNhan], [MaPhongKham], [TenXetNghiem], [ThoiGianThucHien], [ThoiGianLayMau], [ThoiGianTraKQ], [BacSiChiDinh], [BacSiThucHien], [KetQuaCLS], [NhanVienNhapLieu], [MaDichVu], [TrangThai], [MaCLS]) VALUES (N'CLS001', N'BN001', N'P001', N'Xet Nghiem Mau', CAST(0x0000A4C600000000 AS DateTime), CAST(0x0000A4C600000000 AS DateTime), CAST(0x0000A4C600000000 AS DateTime), N'Vuong Thang', N'Bùi Thảo', N'Nhóm máu A', N'', NULL, N'1', NULL)
SET IDENTITY_INSERT [dbo].[ChiTietDonThuoc] ON 

INSERT [dbo].[ChiTietDonThuoc] ([MaChiTietDonThuoc], [MaDonThuoc], [MaThuoc], [LieuDung], [SoLuongThuoc]) VALUES (1, N'DT001', N'TH002', N'Ngày uống 2 lần, 1 viên/ 1 lần - Sau ăn', N'1 vỉ')
SET IDENTITY_INSERT [dbo].[ChiTietDonThuoc] OFF
INSERT [dbo].[DonThuoc] ([MaDonThuoc], [TenBacSiKeDon], [MaBenhNhan], [NgayLapDonThuoc], [NoiDungDonThuoc], [GhiChu]) VALUES (N'DT001', N'Nguyen hai', N'BN001', CAST(0x0000A4AA00000000 AS DateTime), N'Thuoc cam cum', N'')
INSERT [dbo].[KhamBenh] ([MaKhamBenh], [TenBacSi], [MaBenhNhan], [TenNguoiNhapLieu], [ChiDinhCanLamSang], [ChiDinhDichVu], [MaDonThuoc], [ThoiGianKham], [MaPhongKham], [ChuanDoan], [TrieuChung], [Flag]) VALUES (N'KB001', N'Bùi Ngọc', N'BN001', N'Nguyễn Hải', NULL, NULL, NULL, CAST(0x0000A4AA00000000 AS DateTime), N'P001', N'Đau dạ dày', N'Bụng dưới đau nhói', N'1')
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P001', N'Phòng khám số 1', N'1')
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P002', N'Phòng khám số 2', N'1')
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P003', N'Phòng xét nghiệm máu', NULL)
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P004', N'Phòng chụp XQ', NULL)
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P005', N'Phòng nội soi', NULL)
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P006', N'Phòng xét nghiệm sinh hóa', NULL)
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P007', N'Phòng siêu âm', NULL)
INSERT [dbo].[PhongKham] ([MaPhongKham], [TenPhongKham], [Flag]) VALUES (N'P008', N'Phòng Điện tim', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH001', N'THUỐC MELOXICAM', N'100 Hộp ', NULL, N'Thuốc có thể uống, tiêm bắp, đặt trực tràng, ngày 1 lần. Uống vào lúc no hoặc bất cứ nào, có dùng thuốc kháng acid hay không. Tiêm bắp sâu, vào phần tư trên của mông, trước khi bơm thuốc, phải hút xem có máu không (tránh tiêm vào mạch máu. Nếu lúc tiêm người bệnh kêu đau nhiều phải ngừng ngay).', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH002', N'THUỐC PARACETAMOL', N'100 Vỉ', NULL, N'Uống thuốc với nhiều nước. Người lớn : 1 - 2 viên x 3 - 4 lần/ngày. Không dùng thuốc quá 8 viên/ngày.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH003', N'THUỐC IBRAFEN', N'100 Lọ', NULL, N'Giảm đau và hạ sốt: Liều khởi đầu 200-400mg; lặp lại liều này mỗi 4-6 giờ nếu cần. Không vượt quá 1200mg/ngày. Giảm đau và hạ sốt: Liều khởi đầu 200-400mg; lặp lại liều này mỗi 4-6 giờ nếu cần. Không vượt quá 1200mg/ngày.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH004', N'THUỐC HAPACOL', N'100 Vỉ', NULL, N'Cách mỗi 5 - 6 giờ uống một lần. Người lớn và trẻ em > 12 tuổi: uống 1 viên/ lần, không uống quá 6 viên/ ngày.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH005', N'THUỐC DECONTRACTYL 500MG', N'100 Vỉ', NULL, N'Nốt nguyên viên thuốc với một ít nước.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH006', N'ĐẠI TRÀNG HOÀN BÀ GIẰNG', N'100 Lọ x 100 Viên', NULL, N'Ngày uống 3 lần, trước khi ăn 30 phút. Người lớn: Mỗi lần12 viên. Trẻ em trên 5 tuổi: Mỗi lần 5 viên, thêm 1 tuổi thì tăng 1 viên mỗi lần.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH007', N'THUỐC LINCOMYCIN', N'100 Vỉ x 100 Viên', NULL, N'Liều thông thường cho người lớn : uống 1 viên / lần x 3 - 4 lần / ngày. Trẻ em từ : 30 - 60 mg / kg /ngày.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH008', N'THUỐC HAGINAT', N'100 Vỉ x 7 Viên', NULL, N'Nên uống thuốc liền sau bữa ăn. Cần dùng thuốc theo hết liệu trình 5 - 10 ngày, thường là 7 ngày. Người lớn: thông thường uống 250 mg x 2 lần/ ngày.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH009', N'THUỐC HIDRASEC', N'100 Gói', NULL, N'Liều dùng: Ngày đầu tiên: dùng liều khởi đầu, 1 liều x 4 lần/ngày. Những ngày sau: 3 liều/ngày, tối đa 7 ngày. Dạng gói 10 mg & 30 mg: Trẻ 1-9 tháng (dưới 9 kg): 1 gói 10 mg/liều, 9-30 tháng (9-13 kg): 2 gói 10 mg/liều, 30 tháng -9 tuổi (13-27 kg): 1 gói 30 mg/liều, trên 9 tuổi (trên 27 kg): 2 gói 30 mg/ngày. Nuốt nguyên viên cả bột trong gói hoặc khuấy đều trong thức ăn, cốc nước uống hoặc bình sữa, phải được uống ngay lập tức. Dạng viên 100 mg: Người lớn & trẻ > 15t 1 viên 100 mg x 3 lần/ngày.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH010', N'THUỐC ERYTHROMYCIN', NULL, NULL, N'Viên nén bao phim (base và stearat) nên uống lúc đói, nhưng nếu bị kích ứng tiêu hóa thì uống với thức ăn. Viên bao tan trong ruột erythromycin base và estolat có thể uống bất cứ lúc nào; erythromycin ethylsucinat được hấp thu tốt nhất khi uống vào bữa ăn. Người lớn: Từ 1 đến 2 g/ngày chia làm 2 - 4 lần, khi nhiễm khuẩn nặng. Có thể tăng đến 4g/ngày, chia làm nhiều lần. Trẻ em: Khoảng 30 - 50 mg/kg thể trọng/ngày. Trong trường hợp nhiễm khuẩn nặng, liều có thể tăng lên gấp đôi. Trẻ em từ 2 - 8 tuổi dùng 1g/ngày chia làm nhiều lần. Trẻ em dưới 2 tuổi dùng 500 mg/ngày, chia làm nhiều lần.', NULL)
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [SoLuong], [HanSuDung], [CachSuDung], [GiaThuoc]) VALUES (N'TH011', N'Thuốc chuột', N'10', N'6/18/2015', N'Uống 1 lần là xong ko cần uống nữa', 50000)
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [FK_BenhNhan_PhongKham] FOREIGN KEY([MaPhongKham])
REFERENCES [dbo].[PhongKham] ([MaPhongKham])
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [FK_BenhNhan_PhongKham]
GO
ALTER TABLE [dbo].[ChiTietCanLamSang]  WITH CHECK ADD  CONSTRAINT [FK_CanLamSang_BenhNhan] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[ChiTietCanLamSang] CHECK CONSTRAINT [FK_CanLamSang_BenhNhan]
GO
ALTER TABLE [dbo].[ChiTietCanLamSang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCanLamSang_PhongKham] FOREIGN KEY([MaPhongKham])
REFERENCES [dbo].[PhongKham] ([MaPhongKham])
GO
ALTER TABLE [dbo].[ChiTietCanLamSang] CHECK CONSTRAINT [FK_ChiTietCanLamSang_PhongKham]
GO
ALTER TABLE [dbo].[ChiTietDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonThuoc_DonThuoc] FOREIGN KEY([MaDonThuoc])
REFERENCES [dbo].[DonThuoc] ([MaDonThuoc])
GO
ALTER TABLE [dbo].[ChiTietDonThuoc] CHECK CONSTRAINT [FK_ChiTietDonThuoc_DonThuoc]
GO
ALTER TABLE [dbo].[ChiTietDonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonThuoc_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[ChiTietDonThuoc] CHECK CONSTRAINT [FK_ChiTietDonThuoc_Thuoc]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[HoSoBenhNhanNgoaiTru]  WITH CHECK ADD  CONSTRAINT [FK_HoSoBenhNhanNgoaiTru_BenhNhan] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[HoSoBenhNhanNgoaiTru] CHECK CONSTRAINT [FK_HoSoBenhNhanNgoaiTru_BenhNhan]
GO
ALTER TABLE [dbo].[KhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_KhamBenh_BenhNhan] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[KhamBenh] CHECK CONSTRAINT [FK_KhamBenh_BenhNhan]
GO
ALTER TABLE [dbo].[KhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_KhamBenh_DonThuoc] FOREIGN KEY([MaDonThuoc])
REFERENCES [dbo].[DonThuoc] ([MaDonThuoc])
GO
ALTER TABLE [dbo].[KhamBenh] CHECK CONSTRAINT [FK_KhamBenh_DonThuoc]
GO
ALTER TABLE [dbo].[KhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_KhamBenh_PhongKham] FOREIGN KEY([MaPhongKham])
REFERENCES [dbo].[PhongKham] ([MaPhongKham])
GO
ALTER TABLE [dbo].[KhamBenh] CHECK CONSTRAINT [FK_KhamBenh_PhongKham]
GO
USE [master]
GO
ALTER DATABASE [QUANLYBENHVIEN] SET  READ_WRITE 
GO
