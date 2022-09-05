/*Primer 1*/
CREATE DATABASE PRODAVNICA;
GO
USE PRODAVNICA;
GO
CREATE TABLE BREND
(
	brend_id INT IDENTITY(1,1) PRIMARY KEY,
	brend_ime CHAR(20)
);
GO
CREATE TABLE KATEGORIJA
(
	kateg_id INT IDENTITY(1,1) PRIMARY KEY,
	kateg_ime CHAR(20)
);
GO
CREATE TABLE PROIZVOD
(
	pr_id INT IDENTITY(1,1) PRIMARY KEY,
	pr_ime CHAR(20),
	brend_id INT,
	kateg_id INT,
	model_god CHAR(4),
	cena FLOAT
	CONSTRAINT proizvod_brend FOREIGN KEY(brend_id)
	REFERENCES BREND(brend_id),
	CONSTRAINT proizvod_kategorija FOREIGN KEY(kateg_id)
	REFERENCES KATEGORIJA(kateg_id)
);
GO
INSERT INTO BREND(brend_ime)
VALUES('Brend1'),
('Brend2'),
('Brend3'),
('Brend4'),
('Brend5');
GO
INSERT INTO KATEGORIJA(kateg_ime)
VALUES('Kategorija1'),
('Kategorija2'),
('Kategorija3');
GO
INSERT INTO PROIZVOD(pr_ime,brend_id,kateg_id,model_god,cena)
VALUES('Proizvod1',2,3,'2005',543.6),
('Proizvod2',1,2,'2006',573.6),
('Proizvod3',5,1,'2007',743.6),
('Proizvod4',5,3,'2008',443.6),
('Proizvod5',2,1,'2009',744.6),
('Proizvod6',5,3,'2010',547.6);
GO
SELECT * FROM BREND;
SELECT * FROM KATEGORIJA;
SELECT * FROM PROIZVOD;
SELECT pr_ime,brend_ime,kateg_ime,cena FROM PROIZVOD AS P INNER JOIN BREND AS B ON B.brend_id = P.brend_id INNER JOIN KATEGORIJA AS K ON K.kateg_id = P.kateg_id
/*Primer 2*/
USE master;
GO
CREATE DATABASE izlozba_pasa;
GO
USE izlozba_pasa;
GO
CREATE TABLE izlozba
(
	sifra INT PRIMARY KEY IDENTITY(1,1) ,
	mesto CHAR(20),
	datum DATE
);
CREATE TABLE kategorija
(
	kat_id INT PRIMARY KEY,
	kat_naziv char(1)
);
CREATE TABLE pas
(
	p_id INT PRIMARY KEY IDENTITY(1,1),
	p_ime CHAR(15),
	tezina INT

);
CREATE TABLE rezultat
(
	sifra INT,
	kat_id INT,
	p_id INT
	PRIMARY KEY(sifra,kat_id,p_id)
	CONSTRAINT izlozba_rezultat FOREIGN KEY(sifra)
	REFERENCES izlozba(sifra),
	CONSTRAINT kategorija_rezultat FOREIGN KEY(kat_id)
	REFERENCES kategorija(kat_id),
	CONSTRAINT pas_rezultat FOREIGN KEY(p_id)
	REFERENCES pas(p_id)
);
INSERT INTO pas(p_ime,tezina)
VALUES('Dzeki',2),
('Bleki',3),
('Luks',1)
GO
INSERT INTO kategorija
VALUES(11,'l'),
(22,'d'),
(33,'i')
GO
INSERT INTO izlozba(mesto,datum)
VALUES('Beograd','2020-03-23'),
('Nis','2021-04-12'),
('Smederevo','2021-12-19')
GO
INSERT INTO rezultat
VALUES(1,11,1),
(1,11,2),
(1,22,3),
(2,11,1),
(2,11,2),
(2,22,1),
(2,22,2),
(2,33,2),
(2,33,3),
(3,33,2),
(3,33,3);
SELECT * FROM pas
SELECT * FROM kategorija
SELECT * FROM izlozba
SELECT * FROM rezultat
SELECT r.sifra,k.kat_naziv,p.p_ime FROM rezultat AS r INNER JOIN kategorija AS k ON r.kat_id = k.kat_id INNER JOIN pas AS p ON r.p_id = p.p_id
SELECT i.sifra, k.kat_naziv,COUNT(p.p_id) FROM rezultat AS r INNER JOIN kategorija AS k ON k.kat_id = r.kat_id INNER JOIN pas AS p ON p.p_id = r.p_id INNER JOIN izlozba AS i ON i.sifra = r.sifra GROUP BY i.sifra,kat_naziv
SELECT r.sifra, k.kat_naziv,COUNT(p_id) FROM rezultat AS r INNER JOIN kategorija AS k ON k.kat_id = r.kat_id GROUP BY r.sifra,kat_naziv