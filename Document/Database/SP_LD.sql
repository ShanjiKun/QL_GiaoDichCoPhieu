create proc SP_LD
(
	@fromDate Date,
	@toDate Date
)
as
select * from LENHDAT where NgayGD >= @fromDate and NgayGD <= @toDate