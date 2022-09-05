CREATE DATABASE biblioteka;
GO
USE biblioteka;

CREATE TABLE clan
(
	SIFC INT IDENTITY(1,1) PRIMARY KEY,
	Prezime CHAR(30),
	Ime CHAR (30),
	Telefon CHAR(20),
);
GO
INSERT INTO clan
VALUES ('Popovic','Marija', '123456889'),
('Trifunovic','Dusan','552556565');
GO
INSERT INTO clan(Prezime,Ime,Telefon)
VALUES ('Popovic','Marija','123456889'),
('Trifunovic','Dusan','552556565'),
('Blagojevic','Lidija','52352352'),
('Simic','Katarina','987978'),
('Popovic','Dejan','5346347'),
('Stanojevic','Dusan','5236262'),
('Markovic','Sanja','5236262464'),
('Jovanovic','Stefan','1241656')
GO
SELECT*FROM clan;
GO
INSERT INTO clan (Ime)
VALUES ('Marija');
GO    
UPDATE clan
SET Prezime = 'Brankovic' WHERE Prezime = 'Blagojevic';
GO
UPDATE clan
SET Prezime = 'Antic' WHERE SIFC = 11;
GO
/* zvezdica znaci sve tabele iz baze*/
/*INSERT INTO clan(Prezime,Ime,Telefon)
VALUES (,'Popovic','Marija', '123456889'),
('Trifunovic','Dusan','552556565');
GO*/
/*INSERT INTO tabela1 (kol1,kol2,..,kolm)
SELECT kol1,kol2,..,koln FROM tabela2*/
SELECT Ime,Prezime FROM clan WHERE Ime = 'Dusan';
GO
DELETE FROM clan WHERE Ime = 'Dusan';
GO
CREATE TABLE knjige
(
	SIFKNJ INT IDENTITY(1,1) PRIMARY KEY,
	Naslov CHAR(30),
	Zanr CHAR (30),
	Autor CHAR(30),
	Izdavac CHAR(30)
);
GO

INSERT INTO knjige(Naslov,Zanr,Autor,Izdavac)
VALUES ('Lovac na zmajave','Roman-drama','Hajed Hoseini','LAGUNA'),
('Neka komedija','Komedija','KomedijasNeki','LAGUNA'),
('Lovac na tigrove','Roman-drama','NekiLik','LAGUNA'),
('Ide Mile','horor','LajkovackaPruga','LAGUNA'),
('NekaKnjiga','triler','NekiLik','LAGUNA'),
('DramaNeka','Roman-drama','Dramaticar','LAGUNA')
GO
UPDATE knjige
SET Naslov = 'Hiljadu cudesnih sunaca' WHERE Naslov = 'Lovac na zmajave';
GO
SELECT*FROM knjige;
GO
DELETE FROM knjige WHERE Autor = 'Hajed Hoseini';
GO