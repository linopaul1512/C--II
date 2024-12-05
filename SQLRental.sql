use textC#9;

create table Client(
ID varchar(10) primary key,
nameclient varchar(30),
lastname varchar(30),
phonenumber varchar(30),
direction varchar(50),
statusclient char
);

create table BrainEnhancers(
serialnumber varchar(10) primary key,
model varchar(20),
percentageimprovement float,
priceperhour float,
statuxbrain char
);


create table Rental(
codex varchar(10) primary key,
ID varchar(10),
serialnumber varchar(10),
numberofhours int
);


alter table Rental
add foreign key (ID) 
references Client(ID);

alter table Rental
add foreign key (serialnumber) 
references BrainEnhancers(serialnumber);


