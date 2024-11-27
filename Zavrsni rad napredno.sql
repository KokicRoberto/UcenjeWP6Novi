use master;
go

drop database if exists LigaLegendi;
go

create database LigaLegendi collate Croatian_CI_AS;
go

use LigaLegendi;
go

create table kostimi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2)null
);

create table Legende(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null, 
cijena decimal(18,2)null,
kostim int not null references kostimi(sifra)
);

create table mape(
sifra int not null primary key identity(1,1),
naziv varchar(50)not null,
velicina int not null
);

create table LigaLegendi(
mapa int not null references mape(sifra),
legenda int not null references legende(sifra)
);

insert into kostimi (naziv,cijena)
values('project yasuo', 1300);

insert into kostimi (naziv,cijena)
values ('krvaviyasuo', 1500);

insert into kostimi (naziv,cijena)
values ('Trashuo',999.99);

insert into kostimi (naziv,cijena)
values ('sjenazed',1500);

insert into kostimi (naziv,cijena)
values ('MracniZed',999.99);

insert into kostimi (naziv,cijena)
values ('LudaKatarina',2125);




insert into Legende (naziv,cijena,kostim)
values ('Yasuo',6300,3);

insert into Legende (naziv,cijena,kostim)
values ('Zed', 4800,2);

insert into Legende (naziv,cijena,kostim)
values ('Katarina', 3150, 1);


insert into mape (naziv,velicina)
values ('summonersrift',210);

insert into mape (naziv,velicina)
values ('aram',110);

insert into mape (naziv,velicina)
values ('mracna tama',70);

