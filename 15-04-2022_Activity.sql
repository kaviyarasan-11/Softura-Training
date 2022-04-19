use trail
go

create table Product_Table
(
 ProductID int identity(1,1) constraint Pro primary key(ProductID), 
 ProductName varchar(30),
 price Money,
 DateOfManfacture date default getdate(),
 ExpiryDate date default getdate()
)


insert Product_table values('Perk',20,getdate(),DATEADD(m,5,getdate()))select * from Product_Table
select * from Product_Table

create table Customers_Table
(
CustomerID int identity(100,1)constraint P_Cus primary key(CustomerID),
CustomerName varchar(50),
Gender Varchar(10),
DateOfBirth date,
ContactNo varchar(10),
EmailId varchar(50),
City Varchar(50),
Constraint chk_ge check(Gender in ('Male','Female')),
constraint chk_Ci check(City in ('Chennai','Mumbai'))
)
insert Customers_Table(CustomerName,Gender,DateOfBirth,ContactNo,EmailID,City) values('Bala','Male','2001-03-12','6378456245','bala@gmail.com','Chennai')
select*from Customers_Table --where CustomerName='Ajay'
 
create table Purchases_Table
(
BillNo int identity (1000,1) constraint P_Bill primary KEy(BillNo),
CustomerId int,
ProductId int,
Quantity int,
TotalAmount int,
purdate date default getdate()
Constraint FK_cust foreign key(CustomerID) references Customers_table(CustomerID),
Constraint FK_proc foreign key(ProductID) references Product_table(ProductID)
)
select *from Purchases_Table

drop table Purchases_Table
select  Purtab.ProductID,CustomerID,Quantity,ProductName,PurTab.TotalAmount
from Product_table pt
join Purchases_Table PurTab
on pt.ProductID=PurTab.ProductId
go

 select*from Purchases_Table


 