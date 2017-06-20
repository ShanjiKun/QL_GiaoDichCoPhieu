USE QL_GDCP
GO
--SP_LOGIN
CREATE PROC SP_DANGNHAP
@loginName NVARCHAR (50)
AS
DECLARE @userName NVARCHAR(50)
SELECT @userName=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@loginName)

--Output: Ma, HoTen, Role

DECLARE @hoTen nvarchar(50)

SELECT @hoTen = HoTen FROM NDT WHERE MaNDT = @userName

IF(@hoTen is null)
BEGIN
	SELECT @hoTen = HoTen FROM NHANVIEN WHERE MaNV = @userName
END

SELECT Ma = @userName, 
  HoTen = @hoTen,
   NAME as 'Role'
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@userName))
