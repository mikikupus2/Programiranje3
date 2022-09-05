CREATE DATABASE FIRMAMR;
GO
USE FIRMAMR;
GO;
CREATE TABLE RADNIK
(
	idbr int NOT NULL,
	ime char(25) NOT NULL,
	prezime char(25),
	posao char(10),
	kvalif char(3),
	rukovodilac int,
	datzap datetime,
	premija float(1),
	plata float(1) DEFAULT(0)
);
GO
CREATE TABLE ODELJENJE
(
	brod smallint PRIMARY KEY NOT NULL,
	imeod char(15) NOT NULL,
	mesto char(20),
	sefod int
);
GO
CREATE TABLE PROJEKAT
(
	brproj int PRIMARY KEY,
	imeproj char(25) NOT NULL UNIQUE,
	sredstva float(2),
	rok datetime
);
GO
CREATE TABLE UCESCE
(
	idbr int NOT NULL,
	brproj int NOT NULL,
	brsati int,
	fukcija char(15),
	CONSTRAINT ucesce_projekat FOREIGN KEY(brproj)
	REFERENCES PROJEKAT(brproj)
);
GO
ALTER TABLE ODELJENJE
ADD brzap int;
GO
ALTER TABLE RADNIK
ADD brod smallint;
GO
ALTER TABLE UCESCE
ALTER COLUMN brsati smallint;
GO
ALTER TABLE RADNIK
ALTER COLUMN prezime char(25) NOT NULL;
GO
ALTER TABLE PROJEKAT
ADD CONSTRAINT ck_rok_projekta
CHECK(rok>GETDATE());
GO
ALTER TABLE RADNIK
ADD CONSTRAINT ck_kvalif
CHECK(kvalif in('VKV','KV','VSS'));
GO
ALTER TABLE ODELJENJE
ADD CONSTRAINT ime_odeljenja UNIQUE (imeod);
GO
ALTER TABLE RADNIK
ADD PRIMARY KEY (idbr);
GO
ALTER TABLE UCESCE
ADD PRIMARY KEY(idbr,brproj);
GO
ALTER TABLE RADNIK
ADD CONSTRAINT radnik_odeljenje FOREIGN KEY(brod)
REFERENCES ODELJENJE(brod);
GO
ALTER TABLE ODELJENJE
ADD CONSTRAINT odeljenje_radnik FOREIGN KEY(sefod)
REFERENCES RADNIK(idbr);
/*15*/