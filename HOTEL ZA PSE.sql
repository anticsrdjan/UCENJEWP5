use master;
go
drop database if exists hotelzapse;
go
create database hotelzapse collate Croatian_CI_AS;
go
use hotelzapse;


create table djelatnici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar (50) not null,
brojzaduzenja int,
);

create table psi(
sifra int not null primary key identity(1,1),
ime varchar(50),
oznaka varchar(50) not null,
sifraboksa int not null,
datumdolaska datetime not null,
datumodlaska datetime,
korisnici int not null,
djelatnici int not null
);


Create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
brojtelefona varchar(50) not null
);

alter table psi add foreign key (korisnici) references korisnici(sifra);
alter table psi add foreign key (djelatnici) references djelatnici(sifra);
ALTER TABLE korisnici  
--
ADD CONSTRAINT uc1 UNIQUE (brojtelefona);
delete from korisnici;

-- 1 - 4
insert into korisnici(ime,prezime,brojtelefona) values
('Marko','Matić','091/5689-663'),
('Karla','Matić','091/5683-663'),
('Đuro','Matić','091/5682-663'),
('Katica','Matić','091/5688-663');


select * from korisnici;
-- 1 - 4
insert into djelatnici(ime,prezime) values
('Ana','Katić'),
('Marta','Katić'),
('Željana','Katić'),
('Emina','Katić');

insert into psi (sifraboksa,datumdolaska,korisnici,djelatnici,
ime, oznaka)
values
(1,'2024-06-15',3,1,null,'2024/12'),
(1,'2024-06-15',2,1,'Fifi','2024/18');