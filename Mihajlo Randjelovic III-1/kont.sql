USE Fakultet2019
SELECT * FROM slusa
/*1*/
/*A*/
USE VideoKlub
DECLARE @id INT;
SET @id = 1;
SELECT G.idglumca,G.prezime,G.ime,F.[inventarni broj],F.naziv FROM glumac AS G INNER JOIN 
glumi AS GL ON G.idglumca = GL.idglumca INNER JOIN 
film AS F ON GL.[inventarni broj] = F.[inventarni broj]
WHERE G.idglumca = @id
/*B*/
DECLARE @glumacid as INT; 
SET @glumacid = 1; 
SELECT G.idglumca, G.prezime, G.ime, F.[inventarni broj], F.naziv FROM glumac AS G,
film AS F WHERE G.idglumca = ANY(SELECT Gl.idglumca FROM glumi GL WHERE GL.[inventarni broj] = F.[inventarni broj]) 
AND G.idglumca = @glumacid;
/*2*/
/*A*/
SELECT F.[inventarni broj],F.naziv,F.[godina snimljen],G.idglumca,G.prezime,G.ime FROM film AS F INNER JOIN
glumi as GL ON F.[inventarni broj] = GL.[inventarni broj]
INNER JOIN glumac AS G ON G.idglumca = GL.idglumca
WHERE G.ime = 'Milutin' AND G.prezime = 'Miloševic'


USE Fakultet2019;
/*4*/
SELECT N.idNastavnika,P.idPredmeta,P.nazivPredmeta, COUNT(SL.brojIndeksa) FROM nastavnik AS N INNER JOIN 
predaje AS PR ON N.idNastavnika = PR.idNastavnika INNER JOIN 
predmet AS P ON PR.idPredmeta = P.idPredmeta INNER JOIN 
slusa AS SL ON SL.idPredmeta = P.idPredmeta GROUP BY N.idNastavnika,P.idPredmeta,P.nazivPredmeta

/*5*/
SELECT P.idPredmeta, p.nazivPredmeta, AVG(I.ocena) [PROSECNA OCENA] FROM predmet P INNER JOIN ispit I
ON P.idPredmeta = I.idPredmeta WHERE I.ocena > 5 GROUP BY P.idPredmeta, nazivPredmeta,I.ocena
HAVING AVG(ocena) > 8


select film.[inventarni broj],film.naziv,film.[godina snimljen],glumac.idglumca,glumac.ime,glumac.prezime
from glumi join glumac on glumac.idglumca=glumi.idglumca join film on
film.[inventarni broj] = glumi.[inventarni broj] where film.[inventarni broj]=(select film.[inventarni broj] from glumi join glumac on
glumac.idglumca=glumi.idglumca join film on film.[inventarni broj]=glumi.[inventarni broj] where glumac.ime='leonardo'and glumac.prezime='di kaprio')


DECLARE @dnevnaKazna INT
SET @dnevnaKazna = 5

SELECT DISTINCT c.[broj licne karte], prezime,ime, f.[inventarni broj] as 'idfilma', DATEDIFF(day,i.[datum vracanja], GETDATE()) as 'kasnjenje',  
DATEDIFF(day,i.[datum vracanja], GETDATE())*@dnevnaKazna as 'kazna' FROM clan c join iznajmljuje i on c.[broj clanske karte] = i.[broj clanske karte]
join film f on f.[inventarni broj] = i.[inventarni broj] WHERE DATEDIFF(day,i.[datum vracanja], GETDATE()) > 2;