USE QL_GDCP
GO
CREATE PROC SP_STTBACKUP(
	@MEDIA_ID INT
)
AS
SELECT  media_set_id, position, backup_start_date  FROM  msdb.dbo.backupset 
   WHERE     database_name = 'QL_GDCP' AND media_set_id = @MEDIA_ID AND
     backup_set_id > = 
     ( SELECT MAX(backup_set_id) FROM msdb.dbo.backupset
                WHERE media_set_id= @MEDIA_ID AND position=1) 

 ORDER BY position DESC