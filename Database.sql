create table Products
(
	Id serial primary key,
	Name varchar,
	Desription varchar,
	Price decimal,
	StockQuantity int
);

create table Customers
(
	Id serial primary key,
	Name varchar,
	Surname varchar,
	Email varchar unique,
	PhoneNumber varchar
);

create table Orders
(
	Id serial primary key,
	CustomerId int references Customers(Id),
	OrderDate date,
	ProductId int references Products(Id),
	ProductQuantity int,
	TotalAmount decimal
);
select * from Products