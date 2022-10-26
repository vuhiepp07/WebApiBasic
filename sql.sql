create database BasicAPIDb
go
use BasicAPIDb
go

Create table Product(
	productId int,
	productName nvarchar(max),
	productDescription nvarchar(max),
	price int
)
go

insert into Product(productId, productName, productDescription, price) values (1, 'San pham 1', 'Mo ta san pham 1', 1000)
insert into Product(productId, productName, productDescription, price) values (2, 'San pham 2', 'Mo ta san pham 2', 1000)
insert into Product(productId, productName, productDescription, price) values (3, 'San pham 3', 'Mo ta san pham 3', 1000)
insert into Product(productId, productName, productDescription, price) values (4, 'San pham 4', 'Mo ta san pham 4', 1000)
insert into Product(productId, productName, productDescription, price) values (5, 'San pham 5', 'Mo ta san pham 5', 1000)