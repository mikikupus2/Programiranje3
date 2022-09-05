/*12 GRUPA*/
/*1*/
USE Fakultet2019;
GO
SELECT DISTINCT S.brojIndeksa,S.prezime,S.ime FROM student AS S 
INNER JOIN slusa AS SL ON S.brojIndeksa = SL.brojIndeksa 
INNER JOIN ispit AS I ON SL.idPredmeta = I.idPredmeta
WHERE S.godStudija = 3 AND I.ocena > 5;

SELECT DISTINCT S.brojIndeksa,S.prezime,S.ime FROM student AS S 
INNER JOIN ispit AS I ON S.brojIndeksa = I.brojIndeksa
WHERE S.godStudija = 3 AND I.ocena > 5;
/*2*/
USE Fakultet2019;
GO
SELECT COUNT(brojIndeksa) AS Broj_studenata,nazivPredmeta, AVG(I.ocena) AS Prosecna_ocena FROM predmet AS P
INNER JOIN ispit AS I on P.idPredmeta=I.idPredmeta WHERE I.ocena> 5 GROUP BY nazivPredmeta,i.idPredmeta 
ORDER BY Prosecna_ocena DESC
/*3*/
USE VideoKlub;
GO
CREATE PROCEDURE Spisak_filmova_glumca(@ime AS CHAR(30), @prezime AS CHAR(30))
AS
BEGIN
	SELECT F.naziv,F.zanr,F.[godina snimljen] FROM film AS F 
	LEFT JOIN glumi AS GL ON F.[inventarni broj] = GL.[inventarni broj]
	INNER JOIN glumac AS G ON GL.idglumca = G.idglumca WHERE G.ime = @ime AND G.prezime=@prezime;
END
EXEC Spisak_filmova_glumca 'Diane', 'Kruger'