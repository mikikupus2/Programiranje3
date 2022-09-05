CREATE DATABASE MA1;
GO
USE MA1;
GO
CREATE TABLE Autor
(
	AutorID INT PRIMARY KEY IDENTITY(1,1),
	Ime CHAR(30) NOT NULL,
	Prezime CHAR(30) NOT NULL,
	DatumRodjenja DATE  NOT NULL,
	Adresa CHAR(30) NOT NULL,
	Zvanje CHAR(30) NOT NULL
);
GO
CREATE TABLE Knjiga
(
	KnjigaID INT PRIMARY KEY IDENTITY(1,1),/*nema ovamo identity*/
	UDK CHAR(15) NOT NULL,
	ISBN CHAR(13) NOT NULL,
	Naziv CHAR(30) NOT NULL
);
GO
CREATE TABLE Napisali
(
	AutorID INT NOT NULL,
	KnjigaID INT NOT NULL
	PRIMARY KEY(AutorID, KnjigaID)
	CONSTRAINT napisali_autor FOREIGN KEY(AutorID) 
    REFERENCES Autor(AutorID),
	CONSTRAINT napisali_knjiga FOREIGN KEY(KnjigaID) 
    REFERENCES Knjiga(KnjigaID)
);
GO
CREATE TABLE Citalac
(
	CitalacID INT PRIMARY KEY IDENTITY(1,1),
	MaticniBroj CHAR(13) NOT NULL,
	Ime CHAR(30) NOT NULL,
	Prezime CHAR(30) NOT NULL,
	Mesto CHAR(30) NOT NULL,
	Adresa CHAR(30) NOT NULL,
	Telefon CHAR(15) NOT NULL
);
GO
CREATE TABLE Na_Citanju
(
	KnjigaID INT NOT NULL,
	CitalacID INT NOT NULL,
	DatumUzimanja DATE NOT NULL,
	DatumVracanja DATE,
	PRIMARY KEY(KnjigaID,CitalacID,DatumUzimanja),
	CONSTRAINT Na_Citanju_Knjiga FOREIGN KEY(KnjigaID) 
    REFERENCES Knjiga(KnjigaID),
	CONSTRAINT Na_Citanju_Citalac FOREIGN KEY(CitalacID) 
    REFERENCES Citalac(CitalacID)
);
GO
CREATE TABLE Izdavac
(
	IzdavacID INT PRIMARY KEY IDENTITY(1,1),/*nema ovamo identity*/
	NazivIzdavaca CHAR(30) NOT NULL,
	Adresa CHAR(30) NOT NULL
);
GO
CREATE TABLE Izdali
(
	IzdavacID INT NOT NULL,
	KnjigaID INT NOT NULL,
	Godina INT NOT NULL,
	PRIMARY KEY(IzdavacID,KnjigaID),
	CONSTRAINT Izdali_Izdavac FOREIGN KEY(IzdavacID) 
    REFERENCES Izdavac(IzdavacID),
	CONSTRAINT Izdali_Knjiga FOREIGN KEY(KnjigaID) 
    REFERENCES Knjiga(KnjigaID)
);
GO
INSERT INTO Autor(Ime,Prezime,DatumRodjenja,Adresa,Zvanje)
VALUES('Mirko','Markovic','1999-12-06','Neka tamo budjava 1','Pisac'),
('Aleksa','Jankovic','1989-01-12','Marka Petrovica 2','Pesnik'),
('Nemanja','Petrovic','2005-02-06','Kralja Petra 15','Pisac');
GO
INSERT INTO Knjiga(UDK,ISBN,Naziv)
VALUES('64363463','643634643264','Budjava Knjiga'),
('745754745','342942384092','Najjaca Knjiga'),
('346364643','7457457423','Dosadna Knjiga');
GO
INSERT INTO Napisali
VALUES(1,2),
(2,3),
(3,1);
GO
INSERT INTO Citalac(MaticniBroj,Ime,Prezime,Mesto,Adresa,Telefon)
VALUES('5352535232323','Marko','Petrovic','Smederevo','neka tamo 1','0616234234'),
('5352535232323','Milos','Jankovic','Beograd','neka tamo 2','0616234234'),
('5352535232323','Nikola','Simic','Pozarevac','neka tamo 3','0616234234');
GO
INSERT INTO Na_Citanju
VALUES(1,2,'2006-12-06','2022-05-03'),
(2,3,'2016-01-02','2022-05-03'),
(3,1,'2020-03-23','2022-06-07');
GO
INSERT INTO Izdavac(NazivIzdavaca,Adresa)
VALUES('NekiTamoLik','fsafsfaf'),
('NekiTamoDrugiLik','hfdhdfhdfh'),
('NekiTamoTreciLik','asdaggsgesg');
GO
INSERT INTO Izdali
VALUES (1,2,2005),
(2,3,2016),
(3,1,2)

/*Prikazati Ime i Prezime Autor, Ukupan broj iznajmljivanja njegovih dela u poslednjih @G godina i za one autore ciji je ukupan broj iznajmljivanja najmanje@P*/
/*Prikazati Citalac ID, Ime, Prezime, Knjiga ID, Naziv Knjige, Datum Uzimanja, za knjige koje nije vratio pri cemu je Citalac ID parametar*/
/*Prikazati Citalac ID, Ime, Prezime, Broj nevracenih knjiga sortirano po broju nevracenih knjiga(opadajuce) za citaoce koji imaju vise od @P nevracenih knjiga*/
/*Prikazati podatke o citaocima koji su procitali sve knjige kojima raspolaze biblioteka od autora cije su ime i prezime parametri*/
/*Prikazati podatke o citaocima koji nisu procitali nijednu knjigu kojima raspolaze biblioteka od autora cije su ime i prezime parametri*/