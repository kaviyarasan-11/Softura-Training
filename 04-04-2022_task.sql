use AdventureWorks2019
go

-- 1
select count(*)
from HumanResources.Department

select BusinessEntityID,sum(Rate) as Total
from HumanResources.EmployeePayHistory
group by BusinessEntityID

select BusinessEntityID,DATEDIFF(YEAR,StartDate,EndDate) as datedif
from HumanResources.EmployeeDepartmentHistory

select DATEADD(year,1,BirthDate) as addbirth
from HumanResources.Employee

select Convert(int,rate) Toint
from HumanResources.EmployeePayHistory

select left(FirstName,5) as FName
from person.person

select FirstName,len(FirstName) FNameSize
from Person.Person

select FirstName,REVERSE(FirstName) as ReverseFName
from person.Person

-- 2
go
create function fn_Conrupee(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_Conrupee(rate) as Dollar 
from HumanResources.EmployeePayHistory

-- 3

create table table_task3
(
SINO int identity(1,1),
FirstName varchar(30),
LastName varchar(30),
Email varchar(50),
Gender varchar(10)
constraint gender_3 check (gender in('Male','Female','Others'))
)

insert table_task3 (firstname,LastName,Email) values('naveen','kumar','naveen@gmail.com')

go
create view vw_task3
as
select FirstName,LastName,Email
from table_task3
go

insert vw_task3 (firstname,LastName,Email) values('jitesh','sharma','naveen@gmail.com')

insert table_task3 (firstname,LastName,Email) values('abishek','sharma','abi@gmail.com')

select  *
from vw_task3

select *
from table_task3

-- 4
go
create proc protask4
as 
select *
from table_task3

exec protask4

insert table_task3(FirstName,LastName,Email) values('Ravi','Kumar','ravi@gmail.com')

delete table_task3
where FirstName='ravi'

update table_task3
set FirstName='ravi'
where LastName='kumar'

select *
from table_task3

-- 5
select name,convert(varchar,DaysToManufacture)
from production.product
where name=(select name
from production.Product where name='blade' and DaysToManufacture = 1)

-- 6
select Name
from Production.Product
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,ProductModelID
from Production.Product
GRoup By ProductModelID

-- 7
select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name

select * from Sales.SalesPerson
select * from sales.SalesTerritory
select * from Person.Person



