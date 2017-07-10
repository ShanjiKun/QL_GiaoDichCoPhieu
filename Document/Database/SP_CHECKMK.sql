create proc SP_CHECKMK
(
	@MaNDT varchar(20),
	@MKGD varchar(50),
	@NMKGD varchar(50)
)
as
begin 
	DECLARE @Returns INT
	SET @Returns = 0
	if exists(select 1 from NDT where MaNDT = @MaNDT and MKGD = @MKGD)
		begin
			UPDATE NDT SET MKGD = @NMKGD WHERE MaNDT = @MaNDT
			set @Returns = 1
		end 
	return @Returns;
end