create table Student(
Id varchar(10) primary key not null,
nameestudent varchar(30) not null,
datebirth date not null,
direction varchar(30) not null,
phonenumber varchar(20) not null,
codefaculty varchar(10) not null,
statusestudent char not null,
);

alter table Student
add foreign key (codefaculty) 
references Faculty(codefaculty);

create table Asignature(
codeasignature varchar(10) primary key not null,
nameasignature varchar (30) not null,
creditunits int not null,
theoryhours int not null,
hourspractice int not null,
semester int,
statusasignature char not null,
);


create table Section(
codesection varchar(10) primary key not null,
quantitystudents int,
codeasignature varchar(10) not null,
);

alter table Section
add foreign key (codeasignature) 
references Asignature(codeasignature);


create table Student_Section(
codeSS  varchar(10) primary key not null,
codesection varchar(10) not null,
Id varchar(10) not null,
);

alter table Student_Section
add foreign key (Id) 
references Student(Id);

alter table Student_Section
add foreign key (codesection) 
references Section(codesection);



create table Faculty(
codefaculty varchar(10) primary key not null,
namefaculty varchar (30) not null,
professionalprofile varchar (30) not null,
title varchar (30) not null,
statusfaculty char not null
);

create table Asignature_Faculty(
codeAF  varchar(10) primary key not null,
codeasignature varchar(10) not null,
codefaculty varchar(10) not null,
);

alter table Asignature_Faculty
add foreign key (codeasignature) 
references Asignature(codeasignature);

alter table Asignature_Faculty
add foreign key (codefaculty) 
references Faculty(codefaculty);
