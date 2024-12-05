create table Destiny(
codedestiny varchar (10) primary key,
namedestiny date,
countrycode varchar (10),
provincecode varchar (10),
citycode varchar (10),
statex char
);

create table Country(
countrycode varchar (10) primary key,
namecountry varchar(50),
statex char
);

create table Province(
provincecode varchar (10) primary key,
nameprovince varchar(50),
statex char
);

create table City(
citycode varchar (10) primary key,
namecountry varchar(50),
statex char
);

alter table Destiny
add foreign key (countrycode)
references Country(countrycode)

alter table Destiny
add foreign key (provincecode)
references Province(provincecode)

alter table Destiny
add foreign key (citycode)
references City(citycode)




create table Client(
ID varchar (10) primary key,
namex varchar(50),
lastnamex varchar (50),
phonenumberx varchar (50),
countrycode varchar (10),
provincecode varchar (10),
citycode varchar (10),
emergencyphone varchar (50),
statex char
);

alter table Client
add foreign key (countrycode)
references Country(countrycode)

alter table Client
add foreign key (provincecode)
references Province(provincecode)

alter table Client
add foreign key (citycode)
references City(citycode)


create table JourneyClient(
codejourneyclient varchar (10) primary key,
codejourney varchar(10),
ID varchar (10),
typeofpayment varchar(10),
quantitymax int
);

alter table JourneyClient
add foreign key (codejourney)
references Journey(codejourney)

alter table JourneyClient
add foreign key (ID)
references Client(ID)

create table Journey(
codejourney varchar (10) primary key,
datejourney date,
codedestiny varchar (10),
price float (50),
statex char
);

alter table Journey
add foreign key (codedestiny)
references Destiny(codedestiny)

