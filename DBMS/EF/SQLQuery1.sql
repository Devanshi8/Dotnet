create table tblsample(id int identity(1,1)primary key,text varchar(50));
select * from tblsample;
use SampleDB
create table Employee(ID int identity(1,1)primary key,FirstName varchar(20),LastName varchar(20),Gender varchar(8));
select * from Employee;
insert into Employee values('Devanshi','Joshi','Female');
insert into Employee values('Arpit','Joshi','Male');
insert into Employee values('Daivik','Thanki','Male');
insert into Employee values('Krupa','Modha','Female');
insert into Employee values('Vedant','Kumar','Male');

