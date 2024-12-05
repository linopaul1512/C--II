use textC#4

create table Userx(
codex varchar(10)not null primary key,
usernamex varchar(30) not null,
passwordx varchar(30) not null,
lastname varchar (30) not null,
datebirthx date not null,
statusx char not null
);

create table Messagex(
codemessage varchar(10)not null primary key,
codenotebook varchar(10) not null,
description varchar(100) not null,
statusx char not null
);

alter table Messagex
add foreign key (codenotebook)
references Notebookx(codenotebook);



create table Note(
codenote varchar(10)not null primary key,
descriptionx varchar(100)not null,
codenotebook varchar(10)not null,
statusx char not null
);

alter table Note
add foreign key (codenotebook)
references Notebookx(codenotebook);


create table Imagex(
codeimage varchar(10)not null primary key,
imagex varchar(20)not null,
codenotebook varchar(10)not null,
statusx char not null
);

alter table Imagex
add foreign key (codenotebook)
references Notebookx(codenotebook);

create table Notebookx(
codenotebook varchar(10)not null primary key,
descriptionx varchar(30) not null,
codex varchar(10)not null,
statusx char not null
);

alter table Notebookx
add foreign key (codex)
references Userx(codex);










