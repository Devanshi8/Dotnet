--procedure in studenttable
create table procstud(id int IDENTITY(1,1),rollno int, name varchar(10));
insert into procstud values(101,'Google')
drop table procstud
select * from procstud;
create proc addstud(@rollno int,@name varchar(10)) As
Begin

insert into procstud values(@rollno,@name);
END
exec dbo.addstud 102,"Alexa"
exec addstud 103,"Google"