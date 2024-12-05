create table Owner(
ID varchar(15) not null primary key,
nameowner varchar(30) not null,
phonenumber int not null,
direction varchar(40) not null,
statusx char not null
);

create table Pet(
codepet varchar(10) not null primary key,
namepet varchar(30) not null,
birthdate date not null,
IDowner varchar(10) not null,
statusx char not null
);


alter table Pet
add foreign key (IDowner)
references Owner(ID);

