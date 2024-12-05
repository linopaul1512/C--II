use textC#12;

create table Client(
IDclient varchar(10) not null primary key,
nameclient varchar(30) not null,
lastname varchar(30) not null,
adress varchar(30) not null,
datebirth date not null,
phonenumber varchar(30) not null,
statusclient char not null
);



create table Service(
codeservice varchar(10) not null primary key,
descriptionservice varchar(30) not null,
price float not null,
statuservice char not null
);

create table Service_Appointment(
codeSA varchar(10) not null primary key,
codeservice varchar(10) not null,
codeappointment varchar(10) not null
);

alter table Service_Appointment
add foreign key (codeservice)
references Service(codeservice);

alter table Service_Appointment
add foreign key (codeappointment)
references Appointment(codeappointment);

create table Materials(
codematerials varchar(10) not null primary key,
descriptionservice varchar(30) not null,
puccharseprice float not null,
saleprice float not null,
statusmaterials char not null,
quantityavailable int not null
);


create table Materials_Appointment(
codeMA varchar(10) not null primary key,
codematerials varchar(10) not null,
codeappointment varchar(10) not null,
quantityma int not null
);

alter table Materials_Appointment
add foreign key (codematerials)
references Materials(codematerials);

alter table Materials_Appointment
add foreign key (codeappointment)
references Appointment(codeappointment);



create table Worker(
IDworker varchar(10) not null primary key,
nameworker varchar (30) not null,
lastname varchar(30) not null,
phonenumber varchar(30) not null,
datebirth date not null,
adress varchar(30)  not null,
sex char not null,
statusworker char not null,
);

create table Appointment(
codeappointment varchar(10) not null primary key,
IDclient varchar(10) not null,
IDworker varchar(10) not null,
instalationdate date not null,
possibledate date not null,
statusappoinment char not null
);

alter table Appointment
add foreign key (IDclient)
references Client(IDclient);

alter table Appointment
add foreign key (IDworker)
references Worker(IDworker);


create table Invoice(
codeinvoice varchar(10) not null primary key,
codeappointment varchar(10) not null,
dateinvoice date not null,
IVA float not null,
saleprice float not null,
statusinvoice char not null
);


alter table Invoice
add foreign key (codeappointment)
references Appointment(codeappointment);


create table Role(
coderole varchar(10) not null primary key,
descriptionrole varchar(30) not null,
statusrole char not null
);


create table Userx(
codeuser varchar(30) not null primary key, 
coderole varchar(10) not null,
personalname varchar(30) not null, 
lastname varchar(30) not null, 
username varchar(30) not null, 
adress varchar(30) not null,
password varchar(30) not null,
statususer char not null
);

alter table Userx
add foreign key (coderole)
references Role(coderole);


