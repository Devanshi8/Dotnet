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
return(Select CONCAT(employeename,id) as Empid from Employee where id =@ID);
End

Select * from Employee;
Select dbo.empid(5);

