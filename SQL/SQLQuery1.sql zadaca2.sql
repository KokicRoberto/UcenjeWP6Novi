--use master;
--go

--drop datebase if exist zadaca2;
--go

--create datebase zadaca2;
--go

--use zadaca2;
--go

--create table knjige(
--sifra int not null primary key identity (1,1),
--naslov varchar(50),
--pisac varchar(50),
--vlasnik int(11),
--clan int(11),
--datumposudbe datetime not null references datumposudbe,
--datumvracanja datetime not null references datumvracanja
--);

--create table clan(
--sifra int not null primary key identity(1,1),
--clanskibroj int not null
--);

--create table vlasnik(
--sifra int not null primary key identity(1,1),
--kjniga int not null
--);

--create table osobe(
--sifra int not null primary key identity(1,1),
--ime varchar(50),
--prezime varchar(50),
--adresa varchar(20),
--email varchar(50),
--);