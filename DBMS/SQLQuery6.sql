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
