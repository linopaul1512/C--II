create table Position(
codeposition varchar(10) primary key not null,
latinname varchar(30) not null,
sanskritname varchar(30) not null,
limbsbenefited varchar(50) not null,
statusx char not null
);

 
create table Student(
ID varchar(10)not null primary key,
namex varchar(30) not null,
direction varchar(50) not null,
phonenumber varchar(20) not null,
statusx char not null
);

create table Schedules(
codeschedule varchar(10) not null primary key,
typeschedule varchar(10) not null,
starttime time not null,
finaltime time  not null,
statusclass char not null
);


create table Class(
codeclass varchar(10) not null primary key,
codeschedule varchar(10) not null,
nameclass varchar(20) not null,
schedule varchar(10)not null,
maximumquantity int not null,
statusclass char not null 
);


create table ClassStudent(
codeCS varchar(10) not null primary key,
codeclass varchar(10) not null,
ID varchar(10)not null,
);


alter table ClassStudent
add foreign key (codeclass)
references Class(codeclass);

alter table ClassStudent
add foreign key (ID)
references Student(ID);

create table PositionClassStudent(
codePCS varchar(10) not null primary key,
codeCS varchar(10) not null,
codeposition varchar(10) not null,
);


alter table PositionClassStudent
add foreign key (codeCS)
references ClassStudent(codeCS);

alter table PositionClassStudent
add foreign key (codeposition)
references Position(codeposition);