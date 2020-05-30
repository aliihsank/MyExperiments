/* Son 24 saat içinde çalıştırılmış scriptleri listele */

SELECT execquery.last_execution_time AS [Date Time]
	,execsql.TEXT AS [Script]
FROM sys.dm_exec_query_stats AS execquery
CROSS APPLY 

sys.dm_exec_sql_text(execquery.sql_handle) AS execsql
ORDER BY execquery.last_execution_time DESC




/* Deletes all user-defined stored procedures */

Create proc delProcedures
as
begin
declare @procName varchar(500)
declare cur cursor 

for select [name] from sys.objects where type = 'p'
open cur
fetch next from cur into @procName
while @@fetch_status = 0
begin
    exec('drop procedure [' + @procName + ']')
    fetch next from cur into @procName
end
close cur
deallocate cur
end

GO

exec delProcedures
