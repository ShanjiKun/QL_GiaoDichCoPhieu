create proc [dbo].[SP_SDCP]
(
 @MaNDT varchar(20)
)
as
begin
select CP.MaCP, SH.SoLuong, CP.TenCty, LSG.GiaTC, (SH.SoLuong*LSG.GiaTC*1000) as TongGiaTri from SOHUU as SH
inner join COPHIEU as CP on SH.MaCP = CP.MaCP
inner join LICHSUGIA as LSG on CP.MaCP = LSG.MaCP
where SH.MaNDT = @MaNDT
end