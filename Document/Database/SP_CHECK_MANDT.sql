create proc [dbo].[SP_CHECK_MATK](@MaTK varchar(20))
as
begin
DECLARE @Returns INT
SET @Returns = 0
if exists(select 1 from TAIKHOAN_NGANHANG where MaTK = @MaTK) 
	set @Returns = 1
return @Returns;
end