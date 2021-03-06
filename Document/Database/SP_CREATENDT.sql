create proc [dbo].[SP_CREATENDT]
(
@MaNDT varchar(20),
@HoTen nvarchar(50),
@NgaySinh date,
@MKGD varchar(50),
@DiaChi nvarchar(MAX),
@Phone varchar(15),
@CMND varchar(10),
@GioiTinh varchar(10),
@Email varchar(50),
@MaTK varchar(20),
@MaNH varchar(20),
@SoTien float
)
as
begin
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
	INSERT INTO NDT (MaNDT, HoTen, NgaySinh, MKGD, DiaChi, Phone, CMND, GioiTinh, Email)
	VALUES (@MaNDT, @HoTen, @NgaySinh, @MKGD, @DiaChi, @Phone, @CMND, @GioiTinh, @Email);
	INSERT INTO TAIKHOAN_NGANHANG (MaTK, MaNDT, MaNH, SoTien)
	VALUES (@MaTK, @MaNDT, @MaNH, @SoTien);
COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
end