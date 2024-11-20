use master;
go

drop database if exist LigaLegendi;
go

create database LigaLegendi;
go

use database LigaLegendi;
go

create table Legende(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null 
cijena decimal(18,2)null,
kostimi bit
);

create table kostimi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2)null
);

create table mape(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null,
velicina bit
);