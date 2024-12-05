use textC#5

create table Userx(
codeuser varchar(10) not null primary key,
username varchar(20)not null,
passwordx varchar(10) not null,
email varchar(20) not null,
phonenumber int,
statusx char not null
);



create table Publication(
codepublic varchar(10) not null primary key,
codeuser varchar(10)not null,
descriptionx varchar(50),
datepulic date not null,
hourpublic time not null,
statusx char not null
);

alter table Publication
add foreign key (codeuser)
references Userx(codeuser);



create table Picture(
codepicture varchar(10) not null primary key,
picture varchar(50) not null,
codepublic varchar(10) not null,
descriptionx varchar(50) not null,
datepict datetime not null,
urlpict varchar (100) not null, 
statusx char
);

alter table Picture
add foreign key (codepublic)
references Publication(codepublic);



create table Video(
codevideo varchar(10) not null primary key,
video varbinary (8000),
codepublic varchar(10) not null,
descriptionx varchar(50) not null,
urlpict varchar (100) not null, 
statusx char not null
);

alter table Video
add foreign key (codepublic)
references Publication(codepublic);

create table Likes(
codelike varchar(10) not null primary key,
codepublic varchar(10) not null,
codeuser varchar(10) not null,
datelike datetime not null,
statusx char not null
);

alter table Likes
add foreign key (codepublic)
references Publication(codepublic);

alter table Likes
add foreign key (codeuser)
references Userx(codeuser);

create table Comment(
codecomment varchar(10) not null primary key,
codeuser varchar(10) not null,
codepublic varchar(10) not null,
descriptionx varchar(50) not null,
datecomment datetime not null,
statusx char not null
);

alter table Comment
add foreign key (codepublic)
references Publication(codepublic);

alter table Comment
add foreign key (codeuser)
references Userx(codeuser);