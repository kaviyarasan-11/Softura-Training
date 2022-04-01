use AdventureWorks2019
go
--1
select * from Person.Person

select FirstName,LastName
from Person.Person
where Title is not null

--2
select FirstName,LastName
from person.Person
where firstname like '%a%' or LastName like '%a%'

--3
select scc.CurrencyCode,Name
from Sales.Currency ,sales.CountryRegionCurrency scc

--4
go
create view hrDept
as
select DepartmentID,Name,GroupName,ModifiedDate
from HumanResources.Department
go
select  DepartmentID,Name,GroupName,ModifiedDate
from hrdept

--5
create table table_task5
(
SINO int identity(1,1),
FirstName varchar(30),
LastName varchar(30),
Email varchar(50),
Gender varchar(10)
constraint gender_5 check (gender in('Male','Female','Others'))
)

select * from table_task5

insert table_task5 values('Nithin','p','nithin@gmail.com','Male')
insert table_task5 values('Rukesh','Kumar','Rukesh@gmail.com','Male')
insert table_task5 values('Kavi','B','kavi@gmail.com','Male')
insert table_task5 values('Ajay','Suban','Ajay@gmail.com','Male')
insert table_task5 values('Gilbert','A','Gilbert@gmail.com','Male')
insert table_task5 values('Shammu','P','Shammu@gmail.com','Male')
insert table_task5 values('Shebik','D','Shebik@gmail.com','Male')
insert table_task5 values('Suresh','C','Suresh@gmail.com','Male')
insert table_task5 values('Gayathri','H','Gayathri@gmail.com','Female')
insert table_task5 values('Abinesh','A','Abinesh@gmail.com','Male')
insert table_task5 values('Haris','L','Haris@gmail.com','Male')
insert table_task5 values('Balamurgan','B','bala@gmail.com','Male')
insert table_task5 values('Hari','M','Hari@gmail.com','Male')
insert table_task5 values('Kattadura','T','Kattadura@gmail.com','Male')
insert table_task5 values('Nesamani','C','Nesamani@gmail.com','Male')
insert table_task5 values('Naaisekar','R','naai@gmail.com','Male')
insert table_task5 values('Vandumurgan','V','Vandu@gmail.com','Male')
insert table_task5 values('Verrabagu','p','bagu@gmail.com','Male')
insert table_task5 values('Murugaesa','G','murugaesa@gmail.com','Male')
insert table_task5 values('Jackson','H','Jacki@gmail.com','Male')
select FirstName,LastName,Email,Gender
from table_task5

--6

select Bea.BusinessEntityID,AddressTypeID
from Person.BusinessEntityAddress bea
join HumanResources.EmployeeDepartmentHistory his
on bea.BusinessEntityID=his.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=his.DepartmentID

--7

select distinct GroupName
from HumanResources.Department

--8

select ph.StandardCost,sum(ListPrice) SumofListPrice,sum(ph.StandardCost) SumofStandardCost
from Production.ProductCostHistory ph,Production.Product pp
group by ph.StandardCost

--9

select departmentID,Datediff(year,StartDate,EndDate) Years
from HumanResources.EmployeeDepartmentHistory
 
-- 10
 select SalesQuota 
 from sales.SalesPersonQuotaHistory
 where salesquota>5000 and SalesQuota<100000 

 -- 11

 select max(TaxRate) max_taxrate
 from Sales.SalesTaxRate

 -- 12
 go
 create View task12
 as
 select dept.DepartmentID,his.BusinessentityId,ShiftId,BirthDate,datediff(year,BirthDate,getdate()) Age
 from  HumanResources.Employee emp
 join HumanResources.EmployeeDepartmentHistory his
 on emp.BusinessEntityID = his.BusinessEntityID
 join HumanResources.Department dept
 on dept.DepartmentID = his.DepartmentID
 go

 -- 13

 go
 create view NameAge_1
 as
 select *
 from  task12
 go

 select * from NameAge_1

 -- 14

 select count(*) No_of_rows_hr
 from HumanResources.Employee,HumanResources.Department,HumanResources.EmployeeDepartmentHistory,HumanResources.EmployeePayHistory

 -- 15

 select max(rate) MaxRate 
 from HumanResources.EmployeeDepartmentHistory dhis
 join HumanResources.EmployeePayHistory his
 on dhis.BusinessEntityID = his.BusinessEntityID
 join HumanResources.Department dept
 on dept.DepartmentID = dhis.DepartmentID

 -- 16
select FirstName,MiddleName,Title,ea.BusinessEntityID,AddressTypeID
from Person.Person pp
left outer join person.BusinessEntityAddress ea
on ea.BusinessEntityID=pp.BusinessEntityID
where title is not null

-- 17
select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<350 and locationId like 50 

-- 18

select Loc.LocationID,Name,Shelf
from Production.Location Loc
join production.ProductInventory Pro
on Loc.LocationID=Pro.LocationID

-- 19

select * from person.Address
select * from person.StateProvince

select AddressID,AddressLine1,AddressLine2,addr.StateProvinceID,StateProvinceCode,CountryRegionCode
from person.Address addr
join person.StateProvince sp
on addr.StateProvinceID = sp.StateProvinceID

-- 20

select * from sales.SalesOrderHeader
select * from sales.SalesTerritory
select * from sales.CountryRegionCurrency

select CurrencyCode,sum(SubTotal) subtotal,TaxAmt
from sales.SalesTerritory st
join sales.CountryRegionCurrency crc
on st.CountryRegionCode = crc.CountryRegionCode
join Sales.SalesOrderHeader oh
on oh.TerritoryID = st.TerritoryID
group by CurrencyCode,TaxAmt

