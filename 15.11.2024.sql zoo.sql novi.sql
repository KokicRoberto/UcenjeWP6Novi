use master;
go

drop database if exists zoo;
go

create database zoo;
go

use zoo;
go

create table djelatnik(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
iban varchar(50)
);

create table datum(
sifra int not null primary key identity(1,1),
datumrodenja datetime not null,
datumdolaska datetime not null,
datumsmrti datetime not null
);



create table prostorija(
sifra int not null primary key identity(1,1),
dimenzije varchar(50) not null,
maksbroj int not null,
mjesto varchar(50),
);

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null,
ime varchar(50) not null,
djelatnik int not null references djelatnik (sifra),
prostorija int not null references prostorija (sifra),
datum datetime not null references datum(sifra)
);