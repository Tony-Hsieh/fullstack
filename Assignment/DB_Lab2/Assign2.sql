/*
What is a result set?

What is the difference between Union and Union All?

What are the other Set Operators SQL Server has?

What is the difference between Union and Join?

What is the difference between INNER JOIN and FULL JOIN?

What is difference between left join and outer join

What is cross join?

What is the difference between WHERE clause and HAVING clause?

Can there be multiple group by columns?

*/

Use AdventureWorks2019
/*
--1.
Select count(1)
From Production.Product
*/
--2.
Select count(p.ProductSubcategoryID) as "number of products", p.ProductSubcategoryID
From Production.Product p
--where p.ProductSubcategoryID is not NULL
Group by p.ProductSubcategoryID

select * 
from Production.Product

