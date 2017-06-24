create proc [dbo].[SP_AVAILABLEMONEY]
(
	@MaTK varchar(20)
)
as
begin
	select sum(Gia*SoLuong) from LENHDAT as LD where LD.MaTK = @MaTK and (LD.TrangThai = 'Cho' or LD.TrangThai = 'Motphan') group by LD.MaTK
end