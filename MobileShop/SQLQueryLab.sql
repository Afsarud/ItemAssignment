
Create database MobileShop;

Create Table Mobile
(
Id int Identity (1,1),
Name varchar (50),
IMEI varchar (50),
Price float,
) 

insert into Mobile values('Samsung','15487957','1200')
insert into Mobile values('Nokia','144874957','1500')

select * from Mobile where Name = 'Samsung';



Select * from Mobile where 
 