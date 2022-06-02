Create table stud(id int,rollno int,firstname varchar(20), lastname varchar(20),gender varchar(10), classid int);
Select * from stud;
Create table studentClass(id int,classname varchar(20));
select * from studentClass;
drop table stud;

insert into stud values(1,101,'Devanshi','Joshi','Female',1);
insert into stud values(2,102,'Geeta','Joshi','Female',2);
insert into stud values(3,103,'Arpit','Kumar','Male',3);
insert into stud values(4,104,'Justin','Trudeau','Male',2);
insert into stud values(5,105,'Bill','Gates','Male',1);
insert into stud values(6,106,'Pooja','Sharma','Female',3);

insert into studentClass values(1,'A');
insert into studentClass values(2,'B');
insert into studentClass values(3,'C');
insert into studentClass values(4,'D');

--OUTER JOIN
Select rollno,CONCAT(firstname,'-',lastname) as Fullname, gender,classname from stud st RIGHT OUTER JOIN studentClass sc on st.classid=sc.id;

--INNER JOIN
Select st.rollno,CONCAT(firstname,'-',lastname) as Fullname, st.gender,sc.classname from stud as st INNER JOIN studentClass as sc on st.classid=sc.id;



--function
create function GetFullName(@ID int)
returns varchar(100) as

Begin
return(Select CONCAT(firstname,' ',lastname) as Fullname from stud where id=@ID);
End

Select * from stud;
Select dbo.GetFullName(5);



