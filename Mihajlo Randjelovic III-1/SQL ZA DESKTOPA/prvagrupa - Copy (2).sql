USE master;
GO
USE VideoKlub;
GO
SELECT FROM VideoKlub
/*1 a) Koliko članova ima video klub?*/
SELECT COUNT(*) AS [Broj clanova] FROM clan;
/*1.b) Po koliko clanova iz svakog mesta ima video klub?*/
SELECT mesto.naziv,COUNT(*) AS [Broj clanova] FROM clan LEFT JOIN mesto ON clan.ptt = mesto.ptt GROUP BY mesto.naziv;
/*2.	U kojim filmovima glumi Dajana Kruger?*/
SELECT F.naziv FROM film AS F LEFT JOIN glumi AS G ON F.idfilma = G.idfilma 
RIGHT JOIN glumac AS Gl ON G.idglumca = Gl.idglumca WHERE Gl.ime = 'Diane' AND Gl.prezime = 'Kruger';
USE master;
GO
USE Fakultet2019;
GO
/*3.	Izračunati prosečne ocene svih studenata.*/
SELECT S.ime,S.prezime, AVG(I.ocena)FROM student AS S INNER JOIN ispit AS I ON S.brojIndeksa = I.brojIndeksa 
GROUP BY S.ime,S.prezime
/*4.	Kreirati uskladištenu proceduru proceduru za prikaz nastavnika imaju veću mesečnu platu od 
plate nekog nastavnika, čiji se podaci */
CREATE PROCEDURE procedura(@ime AS CHAR(30),@prezime AS CHAR(30))
AS
BEGIN
SELECT (N.ime + ' ' + N.prezime) AS Nastavnik FROM nastavnik AS N WHERE N.plata > 
(SELECT N.plata FROM nastavnik AS N WHERE N.ime = @ime AND N.prezime = @prezime);
END
EXEC procedura 'Petar','Hotomski'