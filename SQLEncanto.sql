use textC#8

create table Member (
ID varchar (10) not null primary key,
codegift varchar (10) not null,
namemember varchar (30) not null,
lastname varchar (30) not null,
phonenumber int ,
datebirth date,
roomnumber varchar(5) not null,
statusmember char not null
);

create table Gift (
codegift varchar (10) not null primary key,
descriptiongif varchar (30) not null,
dategif date,
statusgif char not null
);

alter table Member
add foreign key (codegift) 
references Gift(codegift);




create table Task (
codetask varchar (10) not null primary key,
descriptiontaks varchar (30) not null,
ubication varchar (30) not null,
codesubtask varchar (10) not null,
statustaks char not null
);

alter table Task
add foreign key (codesubtask) 
references Subtaks(codesubtask);


create table Subtaks (
codesubtask varchar (10) not null primary key,
descriptionsubtaks varchar (30) not null,
statussubtaks char not null
);


create table TaskMember(
codetaskmember varchar (10) not null primary key,
codetask varchar (10) not null,
ID varchar (10) not null,
datetask date,
statustk char not null
);

alter table TaskMember
add foreign key (codetask) 
references Task(codetask);

alter table TaskMember
add foreign key (ID) 
references Member(ID);

create table Gossip(
codegossip varchar (10) not null primary key,
descriptiongossip varchar (30) not null,
IDmember varchar (10) not null,
statusgossip char not null,
);

alter table Gossip
add foreign key (IDmember) 
references Member(ID);




