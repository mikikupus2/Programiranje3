USE Firma;
CREATE TABLE tabela1
(
	id INT, 
	Ime CHAR(30),
	Godine INT,
);
GO
CREATE TABLE tabela2
(
	id INT, 
	Ime CHAR(30),
	Godine INT,
);
GO
INSERT INTO tabela1
VALUES (1,'Marko',26),
(2,'Darko',25),
(3,'Nikola',23),
(4,'Marin',53),
(5,'Borko',34),
(6,'Jovan',35);
GO
INSERT INTO tabela2
SELECT * FROM tabela1;
GO
SELECT * FROM tabela1;
SELECT * FROM tabela2;
INSERT INTO tabela2(Ime,Godine)
SELECT Ime,Godine FROM tabela1;
GO
SELECT Ime,LEN(ime) FROM Radnik GROUP BY ime HAVING LEN(ime) > (SELECT AVG(LEN(ime)) FROM Radnik);
SELECT * FROM Radnik;
/*Radnici koji imaju primanja(premija i plata) vece od 2500 */
SELECT ime + prezime AS Radnik,isnull(plata,0) + isnull(premija,0) AS Primanja FROM Radnik WHERE (isnull(plata,0)+isnull(premija,0)) > 2500;

SELECT ime, prezime,plata + premija AS Zarada FROM 
(SELECT ime, prezime, plata, premija FROM Radnik WHERE premija IS NOT NULL) AS Pomocna 

SELECT ime, prezime,plata + premija AS Zarada FROM 
(SELECT ime, prezime, plata, premija FROM Radnik WHERE plata+premija> 2500) AS Pomocna 

SELECT ime, prezime,isnull(plata,0) + isnull(premija,0) AS Zarada FROM 
(SELECT ime, prezime, plata, premija FROM Radnik WHERE isnull(plata,0)+isnull(premija,0) > 2500) AS Pomocna 

/*ime, prezime i platu za radnike koji su angazovani na nekom projektu ali tako da im je broj sati
angazovanja manji ili jednak broju sati bilo kog radnika na projektu sa sifrom 200*/
SELECT * FROM Radnik
SELECT * FROM Projekat
SELECT * FROM Ucesce
SELECT DISTINCT ime, prezime,plata FROM Radnik AS R INNER JOIN Ucesce AS U ON R.idbr = U.idbr
WHERE U.brsati <= ANY(SELECT brsati FROM Ucesce WHERE brproj = 200)