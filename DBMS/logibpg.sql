create database LoginpageDB;
use LoginpageDB
create table TblLogin(ID int identity(1,1) primary key,UserName nvarchar(100),Password nvarchar(100),IsAdmin int);
select * from TblLogin;
create table TblProduct(id int identity(1,1) primary key, ProductName nvarchar(100),ProductDescription nvarchar(100), CatId int,ProductImage nvarchar(100),ProductMrp decimal(18,2),ProductDiscount decimal(18,2),ProductFinal decimal(18,2),ProductQuantity int)
select * from tblProduct;
create table TblCategory(id int identity(1,1) primary key, CatName nvarchar(100));
