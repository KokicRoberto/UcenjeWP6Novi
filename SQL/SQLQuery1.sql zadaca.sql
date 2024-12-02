--use master;
--go

--drop datebase if exist zadaca;
--go

--create datebase zadaca;
--go

--use zadaca;
--go

--create table katalog(
--sifra int not null primary key identity(1,1),
--autor int not null references autor,
--naslov varchar(50),
--izdavac int not null references izdavac,
--mjesto int not null references mjesto 
--);

--create table mjesto(
--sifra int not null primary key identity(1,1),
--naziv varchar(50),
--adresa varchar(20),
--drzava varchar(50)
--);

--create table autor(
--sifra int not null primary key identity(1,1),
--ime varchar(50),
--prezime varchar(50),
--datum rodenja datetime not null
--);

--create table izdavac(
--sifra int not null primary key identity(1,1),
--naziv varchar(50),
--aktivan bit
--);