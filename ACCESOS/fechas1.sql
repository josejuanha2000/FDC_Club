use club
select * from rentaeq
where convert(nvarchar(10),fechar,101)='16/08/2010'
go

use club
select   convert(char(10),fechar,101) from rentaeq

use club
select   convert(smalldatetime,convert(char(10),fechar,101),101) from rentaeq
go

CAST(floor( CAST( GETDATE() AS FLOAT ) )
AS DATETIME
go

SELECT CAST('2010-08-16' AS datetime), cast('00:00' as datetime)
go

select * from rentaeq where fechar='2010-08-16'
go

select * from rentaeq where fechar='19/08/2010'
go


set language spanish
SET LANGUAGE us_english
SET LANGUAGE ansi



select cast('2010/08/16' as datetime)
