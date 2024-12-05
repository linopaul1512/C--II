use textC#6


create table Client(
ID varchar (10) not null primary key,
namex varchar(20) not null,
lastname varchar(20) not null,
datebirth date,
phonenumber int,
stusx char
);


create table Editorial (
codeditorial varchar (10) not null primary key,
nameeditorial varchar(30) not null,
phonenumber int,
statusx char
);

create table Category(
codecategory varchar (10) not null primary key,
descriptionx varchar(40),
statusx char
);

create table Book (
ISBN varchar (10) not null primary key,
codeditorial varchar(10) not null,
codecategory varchar (10) not null,
title varchar (20),
nameauthor varchar(20),
resumebook varchar(100),
category varchar(20),
statusx char
);

alter table Book
add foreign key (codeditorial)
references Editorial(codeditorial);

alter table Book
add foreign key (codecategory)
references Category(codecategory);

create table Copys(
codecopy varchar (10) not null primary key,
ISBN varchar (10) not null,
actualstate  varchar(40),
statusx char
);


alter table Copys
add foreign key (ISBN)
references Book(ISBN);

create table Incidence(
codeincidence varchar (10) not null primary key,
codeloan varchar (10) not null,
descriptionx varchar(50),
penalty FLOAT,
statusx char
);

alter table Incidence
add foreign key (codeloan)
references Loan(codeloan);

create table Loan(
codeloan varchar (10) not null primary key,
ID varchar (10) not null,
codecopy varchar (10) not null,
Deadline date,
physicalstate varchar (50),
statusx char
)

alter table Loan
add foreign key (ID)
references Client(ID);

alter table Loan
add foreign key (codecopy)
references Copys(codecopy);

