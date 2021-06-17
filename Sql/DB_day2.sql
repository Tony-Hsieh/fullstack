/*
    'join' is used to fetch teh data from two or more tables into a single result set
    using a join condition

    Every join has two tables and talbe mentioned before the join type is called 
    left table and table mentioned after join type is called right tables.

    'left'              'right'
    Customer inner join Order

    inner join: it brings the data from left and right table which satisfy the join conditions
        (Intersect)

    left join: it brings all the records from the left table adn only those records from the right table which statisfy the join condition.
        For non matching records right table will return null values.
    
    right join: it brings all the records from the right table adn only those records from the left table which statisfy the join condition.
        For non matching records left table will return null values.

    full join: it brings all the records from the right table and right tables.
        For non matching records left table will return null values.
        (Union)

    self join: when a table is joined with itself then it is called self join.
        TO write a self join 
*/

--select * from Customers
--select * from Orders

/* 
SELECT c.CustomerID, 
       c.ContactName, 
       c.City, 
       o.ShipCity, 
       o.ShipName
From Customers c --left
     inner join Orders o on c.CustomerID = o.CustomerID --right
Where c.City = 'London'
*/

/*
SELECT c.CustomerID, 
       c.ContactName, 
       c.City, 
       o.ShipCity, 
       o.ShipName,
       e.FirstName +' '+ e.LastName as "Employee",
       (od.UnitPrice-od.Discount)*od.Quantity as Total
From Customers c 
     inner join Orders o on c.CustomerID = o.CustomerID 
     inner join Employees e on e.EmployeeID = o.EmployeeID
     inner join [Order Details] od on o.OrderId = od.OrderID
     inner join Products p on od.ProductID = p.ProductID
*/

/*
select c.CustomerID, 
       c.ContactName, 
       c.Country,
       o.OrderID,
       o.OrderDate 
From Customers c -- left
    left join Orders o on c.CustomerID = o.CustomerID -- right

select c.CustomerID, 
       c.ContactName, 
       c.Country,
       o.OrderID,
       o.OrderDate 
From Orders o-- left
    right join Customers c on o.CustomerID = c.CustomerID -- right

select c.CustomerID, 
       c.ContactName, 
       c.Country,
       o.OrderID,
       o.OrderDate 
From Customers c -- left
    full join Orders o on c.CustomerID = o.CustomerID -- right
*/

/*
self join
-- give me the employee and manager name
select e.EmployeeID, e.FirstName, e.ReportsTo
From Employees e

select e.FirstName, m.FirstName
From Employees e
    left join Employees m on e.ReportsTo = m.EmployeeID

select e.FirstName, isnull(m.FirstName, 'CEO') as "Manager"
From Employees e
    left join Employees m on e.ReportsTo = m.EmployeeID
*/

/* Interview Question
    inner join 0 a intersect b
    full join aUb
*/

/*
select top(10) percent c.CustomerID, c.ContactName, c.Phone
From Customers c
*/

/*
--Aggregate methods: 
select count(*), count(1), count(EmployeeID), count(Region) from Employees
select max(unitprice), min(unitprice), avg(unitprice), sum(unitprice) from products
*/
/* 
Difference between count(*) vs count(colName):
    count(*) is used to count the  total number of rows in a table
    count(colName) is used to count total not Null values in that column
*/

--select count(city), Country from Customers  --error
select count(city), Country, Region from Customers group by Country, Region


-- where and having clause difference
-- having: use for aggregate function
select count(city) as total, Country 
from Customers 
group by Country 
having count(city)>3

-- customer name and total orders
-- if some customers did not place any order, they still have to be listed.
select c.ContactName, count(o.OrderDate) as "totalorders"
from Customers c
    left join Orders o on c.CustomerID = o.CustomerID
group by c.ContactName

select c.ContactName, o.OrderDate as "totalorders"
from Customers c
    left join Orders o on c.CustomerID = o.CustomerID
where o.OrderID is NULL