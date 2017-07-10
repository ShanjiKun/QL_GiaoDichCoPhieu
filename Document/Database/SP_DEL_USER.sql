create proc SP_DEL_USER
(
	@LOGIN nvarchar(50)
)
as
begin
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
	EXEC sp_droplogin @LOGIN
	EXEC sp_dropuser @LOGIN
COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'L?i: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
end