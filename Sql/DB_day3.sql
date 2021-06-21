--Sub Query
/*
--customers who never placed any order
select CustomerId,ContactName from Customers where 
CustomerID not in
(Select distinct CustomerId from Orders)


select c.CustomerID,c.ContactName
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.OrderID is null


-- correlated sub query is faster than join
-- customer with total numbers of orders

select c.ContactName,c.City,c.Country,c.Phone,
(select count(o.orderid) from Orders o where o.CustomerID=c.CustomerID ) as"Totalorders"
from Customers c


select c.contactname, c.City,c.Country,c.Phone, count(o.orderid) as "TotalOrders" from Customers c left join orders o
on c.CustomerID = o.CustomerID
group by c.ContactName,c.City,c.Country,c.Phone


-- union will give the unique records but union all will give duplicate
-- union will sort the data based on the first column in select statement but union all
  -- will not sort the data
-- union all will be faster than union
-- union can not be used inside the recursive CTE but union all can be used inside recursive cte

select city, country from Customers
UNION
select city, country from Employees

select city, country from Customers
UNION all
select city, country from Employees

-- number of columns in each select statement must be the same
-- columns must be in the same order with respect to the data types
-- column alias must be given in the first select statement

select city from Customers
UNION all
select city, country from Employees

select city as "Result", country from Customers
UNION all
select city, country from Employees

-- union vs join
-- union add rows, join add columns
-- union at least use two select statement
-- union has no condition

select ContactName, City , Country FROM
(select * from CUstomers) derivedtable

select top 1 * FROM
(select top 10 * from products order by UnitPrice desc) dt
order by dt.UnitPrice ASC

-- window function / ranking function
-- where cannot use with rank at same clause
-- rank (11,11,13,14...) vs dense_rank (11, 11, 12, 13 ...)

select productid, productname, unitprice, rnk from
(select p.ProductID, p.ProductName, p.UnitPrice, rank() over(order by p.unitprice desc) rnk
from Products p ) dt
where rnk=11

select p.ProductID, p.ProductName, p.UnitPrice, dense_rank() over(order by p.unitprice desc) rnk
from Products p 


-- offset: how many records that I want to skip
-- fetch: how many records to fetch
select c.CustomerID, c.ContactName, c.City, c.Country from Customers c
order by c.CustomerID
offset 20 rows -- skip first 10 rows
fetch first 10 rows only -- rows 10 - 20


Select c.ContactTitle,c.CustomerID,c.city,c.Country ,dt.total
from Customers c
left join (select count(orderid) total, customerid from orders group by customerid)dt
on c.CustomerID = dt.CustomerID



-- CTE Common Table Expressions
-- A Common Table Expression (CTE) is the result set of a query 
-- which exists temporarily and for use only within the context of a larger query. 
-- Much like a derived table, the result of a CTE is not stored and exists only for the duration of the query


-- CTE advantages: code clearity, recursive, ...
with orderCountCTE
AS(
    Select o.customerid, count(o.orderid) as "totalorders" from orders o group by o.CustomerID
)
select c.CustomerID,c.ContactName,oc.totalorders  from Customers c left join orderCountCTE oc 
on c.CustomerID = oc.CustomerID
*/

-- find top 3 customers from every city who have placed maximum number of orders
select dt2.CustomerID,dt2.ContactName,dt2.city,dt2.TotalOrders,dt2.rnk from 
(Select c.CustomerID,c.ContactName,dt.TotalOrders,c.city,
DENSE_RANK() over(partition by c.city order by dt.totalorders desc) rnk from 
Customers c inner join 
(select o.CustomerID,count(o.orderid) as "TotalOrders" from orders o
group by o.CustomerID)dt
on c.CustomerID = dt.CustomerID )dt2
where dt2.rnk<=3


with cteCustomerOrderCount
as
(
    select o.customerid,count(o.orderid) as "TotalOrders" from Orders o 
	group by o.CustomerID
),cteCustomerDetailWithRank
as
(
   Select c.CustomerID,c.ContactName,c.City,co.TotalOrders, 
   DENSE_RANK() over(partition by c.city order by co.totalorders desc) rnk
   from Customers c inner join cteCustomerOrderCount co
   on c.CustomerID = co.CustomerID
)
select * from cteCustomerDetailWithRank where rnk <=3


-- find out top 3 and least 3 sold products in every city

-- recursive
with empHeirarchy
as
(
Select e.EmployeeID,e.FirstName,e.ReportsTo, 1 as "lvl"
from Employees e where e.ReportsTo is null
union all
select e.EmployeeID,e.FirstName,e.ReportsTo, eh.lvl+1
from Employees e inner join  empHeirarchy eh on e.ReportsTo = eh.EmployeeID
)
select * from empHeirarchy 
