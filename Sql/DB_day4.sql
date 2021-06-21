--Constraints
Use JuneBatch2021

/*
Create table Employee (Id int, EName varchar(20))
insert into Employee values (1, 'Peter')
select * from Employee
insert into Employee values (null, null)
select * from Employee
select count(1) from Employee
drop table Employee
*/

Create table Employee (Id int not null, EName varchar(20) not null)
insert into Employee values (1, 'Peter')
insert into Employee values (null, null) --error
insert into Employee values (2, 'John') -- if run multiple times
select count(1) from Employee
drop table employee

--set unique(use )
Create table Employee (Id int unique, EName varchar(20) unique)
insert into Employee values (1, 'Peter')
insert into Employee values (null, null)
drop table employee

-- not null + unique = primary key
-- not null unique(not sorted) , primary key(sorted)
/*
    1. Primary key does not accept null value but unique constraint accepts one null value
	2. one table can have only one primary key but a table can have multiple unique constraints
	3. primary key will sort the data in asc order by default but unique constraint can not do that
	4. primary key by default creates clustered index but unique constrain creates non clustered index
*/

Create table Employee (Id int primary key, EName varchar(20) unique)
insert into Employee values (1, null)
insert into Employee values (null, 'John') --error
select * from Employee
drop table employee

-- out of bound Constraint
Create table Employee (Id int primary key, EName varchar(20) not null, Age int)
insert into Employee values (1, 'Peter', -56)
insert into Employee values (2, 'James', 7000)
select * from Employee
drop table Employee

Create table Employee (Id int primary key, EName varchar(20) not null unique, Age int check(age between 20 and 50))
insert into Employee values (1, 'Peter', -56)
insert into Employee values (2, 'James', 7000)
select * from Employee
drop table Employee

