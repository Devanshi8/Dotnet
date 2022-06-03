--function 
Select * from Employee;

/*

create function <function name>(parameters)
returns varchar(100) as
Begin
return(enter your query)
End

Call A function :-
		Select dbo.empid(value);


*/

create function empid(@ID varchar)
returns varchar(100) as 
Begin
return(Select CONCAT('EMP',id) as Empid from Employee where id =@ID);
End
drop function empid;
Select * from Employee;
Select dbo.empid(3);

--Procedure
/*

use for manipulation DML->insert update delete,call

*/

create proc AddEmployee(@empname varchar(20),@id int,@employeeid int,@salary int)
As
Begin
insert into Employee values(@empname,@id,@employeeid,@salary);
End

drop proc AddEmployee;

Select * from Employee;
exec dbo.AddEmployee 'Bill',6,4595,6000;


