Create table Employee(id int, nm varchar(20),deptid int);
Create table Department(id int, dept varchar(20));

Select * from Employee;
Select * from Department;

insert into Employee values(1,'a',1);
insert into Employee values(2,'b',2);
insert into Employee values(3,'c',1);
insert into Employee values(4,'d',3);

insert into Department values(1,'IT');
insert into Department values(2,'Sales');
insert into Department values(4,'Admin');

--FULL OUTER JOIN(emp-intersection-dep-->all)
Select * from Employee emp FULL OUTER JOIN department dep on emp.deptid = dep.id;

--LEFT OUTER JOIN (emp ,emp intersection with dep)
Select * from Employee emp LEFT OUTER JOIN department dep on emp.deptid = dep.id;

--RIGHT OUTER JOIN (emp intersection with dep, dep)
Select * from Employee emp RIGHT OUTER JOIN department dep on emp.deptid=dep.id;