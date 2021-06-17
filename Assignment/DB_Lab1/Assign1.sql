Use AdventureWorks2019

--1.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p

--2.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.ListPrice = 0

--3.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color is NULL

--4.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color is not NULL

--5. 
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color is NULL and p.ListPrice>0

--6.
Select concat(p.Name, ' ', p.Color)
From Production.Product p
Where p.Color is not NULL

--7.
Select concat('Name: ', p.Name, ' -- COLOR: ', p.Color) as "Name And Color"
From Production.Product p
Where p.Color is not NULL

--8.
Select p.ProductID, p.Name
From Production.Product p
Where p.ProductID between 400 and 500

--9.
Select p.ProductID, p.Name, p.Color
From Production.Product p
Where p.Color in ('Black', 'Blue')

--10.
Select *
From Production.Product p
Where p.Name like 'S%'

--11.
Select p.Name, p.ListPrice
From Production.Product p
Where p.Name like 'S%'
Order by p.Name

--12.
Select p.Name, p.ListPrice
From Production.Product p
Where p.Name like '[A, S]%'
Order by p.Name

--13.
Select p.Name, p.ListPrice
From Production.Product p
Where p.Name like 'SPO%' and p.Name not like 'SPOK%'
Order by p.Name

--14.
Select distinct p.Color
From Production.Product as p
Order by p.Color

--15.
Select distinct concat(p.ProductSubcategoryID,' ', p.Color) as comb
From Production.Product as p
Where p.ProductSubcategoryID is not NULL and p.Color is not NULL
Order by comb

--16.
SELECT ProductSubCategoryID
      , LEFT([Name],35) AS [Name]
      , Color, ListPrice 
FROM Production.Product
WHERE Color IN ('Red','Black') 
      AND ListPrice BETWEEN 1000 AND 2000 
      AND ProductSubCategoryID = 1
ORDER BY ProductID

--17.
SELECT ProductSubCategoryID
      , LEFT([Name],35) AS [Name]
      , Color, ListPrice 
FROM Production.Product
WHERE
     ProductSubcategoryID<15
ORDER BY ProductSubcategoryID DESC