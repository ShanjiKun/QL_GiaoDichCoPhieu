create proc SP_LK
(
	@fromDate Date,
	@toDate Date
)
as
select LK.MaLK, LK.MaGD, LK.NgayGioKhop, LK.SoLuongKhop, LK.GiaKhop, LK.KieuKhop from LENHDAT as LD inner join 
LENHKHOP as LK
on LD.MaGD = LK.MaGD  
where NgayGD >= @fromDate and NgayGD <= @toDate