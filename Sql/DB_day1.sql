
Select p.ProductID, p.ProductName, p.UnitPrice
From products p
where p.UnitPrice between 20 and 30 -- <, =, >, !=, <> is !=

Select c.CustomerID, c.ContactName, c.City
From Customers c
--where c.City='London' or c.City='Paris' or c.City='Seattle'
where c.City in ('London', 'Paris', 'Seattle')

Select e.EmployeeID, e.FirstName, e.Region
From Employees e
where e.Region is Null -- "= NUll" incorrect



Select c.CustomerID, c.ContactName
From Customers c
where c.ContactName like '%an%' 
-- where c.ContactName like 'h%' 
-- where c.ContactName like '[^a, m ,c]%' 

Select c.ContactName, c.City, c.Country
From Customers c
where c.Country='Brazil'
--order by c.ContactName desc
order by c.Country, c.City

declare @x INT

select * from [Order Details]


