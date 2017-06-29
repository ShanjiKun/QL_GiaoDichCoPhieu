--Create Device
EXEC sp_addumpdevice 'disk', 'Bk_GDCP', 'c:\Bk_GDCP.bak'
-- Back up the full MyNwind database.
BACKUP DATABASE QL_GDCP TO Bk_GDCP
--Find max of Device backup
SELECT MAX(media_set_id) FROM msdb.dbo.backupset  
   WHERE database_name = 'QL_GDCP'
--Restore
USE MASTER
GO
ALTER DATABASE QL_GDCP
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE
GO
RESTORE DATABASE QL_GDCP
FROM Bk_GDCP
WITH REPLACE, FILE = 1
GO
ALTER DATABASE QL_GDCP
SET MULTI_USER
