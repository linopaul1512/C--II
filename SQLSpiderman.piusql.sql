/*create table Universe(
codex varchar (10) primary key,
namex varchar(50),
locationx varchar (50),
quantityx int,
statex char
);*/

/*
create table Spiderman(
codex varchar(10) primary key,
superheroname varchar(50),
colors varchar (50),
superpowers varchar(1000),
codeuniverse varchar(10),
statusx char
);*/

/*alter table Spiderman
add foreign key (codex)
references Universe(codex);
*/

/*
create table Spiderman(
codex varchar(10) primary key,
superheroname varchar(50),
colors varchar (50),
superpowers varchar(1000),
codeuniverse varchar(10),
statusx char
);*/

/*create table Villain(
codex varchar(10) primary key,
superheroname varchar(50),
origin varchar (50),
ocupation varchar(50),
dangerousness int,
statusx char
);*/

create table Civilianvillain(
codex varchar(10) primary key,
civilianname varchar(50),
Birthdate date,
codeuniverse varchar(10),
codevillain varchar(10),
statusx char
);

alter table Civilianvillain
add foreign key (codeuniverse)
references Universe(codex);


alter table Civilianvillain
add foreign key (codevillain)
references Villain(codex);



