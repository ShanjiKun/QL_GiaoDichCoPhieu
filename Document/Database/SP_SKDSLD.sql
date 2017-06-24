create proc SP_SKDSLD
(
	@fromDate nvarchar(50),
	@toDate nvarchar(50)
)
as 
select LD.MaCP ,LD.NgayGD, LD.LoaiLenh, LD.PhuongThuc, LD.SoLuong, LD.Gia, ISNULL(LK.SoLuongKhop, 0) as SoLuongKhop, ISNULL(LK.GiaKhop,0) as GiaKhop, LK.NgayGioKhop from LENHDAT as LD left join LENHKHOP as LK on LD.MaGD = LK.MaGD 
where NgayGD >= @fromDate and NgayGD <= @toDate