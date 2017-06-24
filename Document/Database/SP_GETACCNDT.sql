create proc SP_GETACCNDT
(
	@MaNDT varchar(20)
)
as 
begin
	select TN.MaTK, TN.SoTien, NH.TenNH, NDT.HoTen from TAIKHOAN_NGANHANG as TN, NDT, NGANHANG as NH where TN.MaNH = NH.MaNH and TN.MaNDT = NDT.MaNDT and NDT.MaNDT = @MaNDT 
end