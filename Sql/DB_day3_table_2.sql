
insert into #AntraEmployee values (2, 'John', 25)

insert into ##AntraCustomer values (1, 'David', 'Chicago')

--table act as a variable that can be passed to other uses.
declare @empcollection Table (id int, firstname varchar(10), lastname varchar(20))

insert @empl