--use master;
--go

--drop database if exists nogomet;
--go

--create database nogomet;
--go

--use nogomet;
--go

--create table klub(
--sifra int not null primary key identity(1,1),
--naziv varchar(50) not null,
--osnovan int not null,
--stadion varchar(20),
--predsjednik varchar(30),
--drzava varchar(50),
--liga varchar(30)
--);

--create table utakmica(
--sifra int not null primary key identity(1,1),
--datum int not null,
--vrijeme varchar(50) not null,
--lokacija varchar(50),
--stadion varchar(50),
--domaciklub int not null references klub(sifra),
--gostujuciklub int not null references klub(sifra)
--);

--create table igrac(
--sifra int not null primary key identity(1,1),
--ime varchar(50),
--prezime varchar(50),
--datumrodenja int not null,
--pozicija varchar(30) not null,
--brojdresa int,
--klub int not null references klub(sifra)
--);

--create table trener(
--sifra int not null primary key identity(1,1),
--ime varchar(50),
--prezime varchar(50),
--klub int not null references klub(sifra),
--nacionalnost varchar(50),
--iskustvo varchar(30)
