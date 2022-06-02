Create table Sample(id int, name varchar(200))
Select * from Sample;
insert into Sample values(1,'abc');
insert into Sample values(2,'abc2');
insert into Sample values(3,'abc3');
insert into Sample values(4,'abc4');
delete from Sample where id =4;

Select * from Sample where id = 3;

update Sample set name='Devanshi' where id= 1;

Create table Employee(employeename varchar(25),id int,employeeid int);
Select * from Employee;
insert into Employee values('Devanshi',1,4545);
insert into Employee values('xyz',2,4555);
insert into Employee values('wxy',3,4565);
insert into Employee values('alexa',4,4555,5000);
insert into Employee values('google',5,4565,1000);
delete from Employee where id=4;
alter table Employee add salary int;
update Employee set salary=1000 where id=1;
update Employee set salary=500 where id=2;
update Employee set salary=550 where id=3;

/*alter table Employee add department varchar(20);
alter table Employee Drop column department;*/


Select employeename,department from Employee;
Select MAX(salary) from Employee;
Select MIN(salary) from Employee;
Select AVG(salary) from Employee;
Select COUNT(*) from Employee;


Create table Department(dept varchar(20));
Select * from Department;
insert into Department values('Development');
insert into Department values('Designing');
insert into Department values('Testing');
insert into Department values('Development');
insert into Department values('HR');
--insert into Employee values('google',5,4585,'HR',100);


Select * from Employee where id in(1,2,3);
Select * from Employee where id not in(1,2,3);

Select * from Employee where  employeename Like '%a____';


Select employeename,salary from Employee;
Select dept from Department; 

Select CONCAT(employeename,'=',salary) as Employee Details  from Employee;