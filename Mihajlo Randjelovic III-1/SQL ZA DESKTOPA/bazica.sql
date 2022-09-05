CREATE DATABASE nekabaza;
GO
USE nekabaza;
GO
CREATE TABLE Zarada
(
	R_ID INT NOT NULL,
	Ime CHAR(20) NOT NULL,
	Prezime CHAR(30) NOT NULL,
	B_ID INT NOT NULL,
	RJ_ID INT NOT NULL,
	Mesec INT NOT NULL,
	Godina INT NOT NULL,
	Iznos FLOAT NOT NULL
);
GO

INSERT INTO Zarada
VALUES(1,'Marko', 'Markovic',1,1,7,2018,25005.5),
(1,'Marko', 'Markovic',2,1,12,2018,35006.5),
(1,'Marko', 'Markovic',2,1,8,2021,75006.5),
(2,'Nemanja', 'Petrovic',1,2,6,2019,54000.78),
(2,'Nemanja', 'Petrovic',3,2,1,2021,54000.78),
(3,'Darko', 'Maksimovic',4,4,4,2017,65806.97),
(4,'Boris', 'Petrovic',2,3,2,2018,67006.67),
(5,'Mladen', 'Nikolic',3,2,8,2020,95006.564),
(6,'Marko', 'Markovic',4,3,3,2019,34006.56)
GO
SELECT R_ID, Ime,Prezime,AVG(Iznos)Prosecna_Zarada FROM Zarada GROUP BY R_ID,Ime,Prezime
SELECT R_ID, Ime,Prezime,AVG(Iznos)Prosecna_Zarada FROM Zarada WHERE Godina = 2021 GROUP BY R_ID,Ime,Prezime
SELECT RJ_ID,Godina,Mesec,COUNT(DISTINCT R_ID)Broj_Zaposlenih FROM Zarada GROUP BY RJ_ID,Mesec,Godina
SELECT B_ID,Godina,Mesec,SUM(Iznos)Suma_isplata FROM Zarada WHERE B_ID= 1 GROUP BY B_ID,Godina,Mesec
SELECT B_ID,Godina,Mesec,SUM(Iznos)Suma_isplata FROM Zarada GROUP BY B_ID,Godina,Mesec HAVING B_ID = 1
SELECT TOP 3 R_ID,Ime,Prezime,SUM(Iznos)Najveca_plata FROM Zarada GROUP BY R_ID,Ime,Prezime ORDER BY Najveca_plata DESC
/*Prikazati sifru radnika,ime, prezime i prosecnu zaradu za svakog radnika
izmeniti ovaj upit da prikaze prosecnu zaradu u 2021 godini*/
/*sifra radne jedinice,godina,mesec,broj zaposlenih,za svaku radnu jedinicu i svaki mesec u 2021 godini*/
/*identifikator banke,godina,mesec,suma isplata za banku ciji je id=1 po mesecima*/
/*prikazati id radnika,ime,prezime ukupnu zaradu, za tri radnika sa najvecom ukupnom platom u 2021.