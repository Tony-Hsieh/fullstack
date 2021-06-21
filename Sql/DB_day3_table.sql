-- # means local temporary table
-- cannot be used in other queries
-- the moment the session close, temp table will be deleted automatically 
-- both table, variable and temp table store in tempdb
Create table #AntraEmployee (Id int, FullName varchar(20), Age int)

insert into #AntraEmployee values (2, 'John', 25)

select * from #AntraEmployee

drop table #AntraEmployee

-- ## global temp table
create table ##AntraCutsomer (Id int, FullName varchar(20), City varchar(20))

