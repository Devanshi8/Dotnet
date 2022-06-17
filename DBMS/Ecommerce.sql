Create table Admin(id int identity(1,1) primary key,AdminID varchar(50),AdminName nvarchar(50));

create table UserDetail(id int identity(1,1)primary key, UserID nvarchar(50),UserName nvarchar(50));

create table Product(id int identity(1,1)primary key, ProductID nvarchar(50),ProductName nvarchar(50),Category nvarchar(50));