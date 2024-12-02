--update naredba
select * from smjerovi;


update smjerovi set cijena=1100
where sifra=2; -- ako mijenjamo po PK tada mijenjamo 1 red

update smjerovi set 
izvodiseod='2024-12-05', 
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;

update polaznici set prezime='Franjić' where sifra=16;

select * from polaznici where sifra=16;

--unjeti 5 novih smjerova s cijenom 

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('Nogomet',999.99,'2024-11-25 15:00',1);

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('Košarka',899.99,'2024-12-25 11:00',1);

insert into smjerovi (naziv, cijena, izvodiseod, vaucer)
values ('Rukomet',799.99,'2024-12-20 10:00',1);


update smjerovi set cijena = cijena * 0.9; 

select * from smjerovi;

--uvećajte sve cijene za 35%

select * from smjerovi;

update smjerovi set cijena = cijena * 1.35; 

select * from smjerovi;


--smanjite svim smjerovima cijenu za 10 eura
select * from smjerovi;

update smjerovi set cijena = cijena - 10; 

select * from smjerovi;

-- uvjet vanjskog ključa 

update grupe set smjer=5 where sifra=1;


-- delete naredba
select * from smjerovi;
delete from smjerovi where sifra>4;
select * from smjerovi;

select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;
update clanovi set grupa=2 where grupa=1;
