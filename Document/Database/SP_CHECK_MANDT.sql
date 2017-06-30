create proc [dbo].[SP_CHECK_MANDT](@MaNDT varchar(20))
as
begin
DECLARE @Returns INT
SET @Returns = 0
if exists(select 1 from NDT where MaNDT = @MaNDT) 
	set @Returns = 1
return @Returns;
end