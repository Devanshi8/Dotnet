Create table OrderList(id int identity(1,1) primary key,UserName varchar(100),ProductName nvarchar(100),ProductMrp decimal(18,2));

create table TblLogin(id int identity(1,1)primary key, UserName nvarchar(100),Password nvarchar(100),IsAdmin int);

create table TblProduct(id int identity(1,1)primary key, ProductName nvarchar(100),ProductDescription nvarchar(100), CatId int,ProductImage nvarchar(100),ProductMrp decimal(18,2),ProductDiscount decimal(18,2),ProductFinal decimal(18,2),ProductQuantity int);

create table TblCategory(id int identity(1,1) primary key, CatName nvarchar(100));

create table addcart(id int identity(1,1) primary key, ProductName nvarchar,ProductImage nvarchar(100),ProductDescription nvarchar(100),ProductFinal decimal(18,2),ProductQuantity int);

select * from TblLogin;
select * from tblProduct;
select * from TblCategory;



select* from addcart;

select * from OrderList;

