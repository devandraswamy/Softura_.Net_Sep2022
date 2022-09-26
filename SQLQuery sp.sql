select*from task
use test1

go

create procedure sp_task
@fname nvarchar(50),
@lname nvarchar(50),
@city nvarchar(50)


As

insert into task(Fname,lname,country)
values(@fname,@lname,@city)

return

delete from task
where
Fname='jaya'

