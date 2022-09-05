/*Sastaviti upit koji prikazuje za svakog nastavnika njegovo ime i prezime, broj studenata 
koji su polagali kod njega i prosecnu ocenu 
id nastavnika i broj studenata*/
USE Fakultet2019;
SELECT n.idNastavnika,n.ime, n.prezime, p.Broj, p.Prosek
FROM nastavnik AS n, (SELECT i.idNastavnika, COUNT(i.idNastavnika) AS Broj, AVG(ocena) AS Prosek
FROM ispit AS i GROUP BY i.idNastavnika) AS p 
WHERE n.idNastavnika = p.idNastavnika AND Prosek > 7;

/*prikaati broj indeksa, ime i prezime studenta i broj polozenihy ispita za sve studente 
trece godine studije
a) vezivanjem tabela
b) podupiti*/
SELECT S.brojIndeksa,S.ime,S.prezime,p.Broj FROM student AS S INNER JOIN(SELECT i.brojIndeksa, COUNT(i.brojIndeksa) AS Broj
FROM ispit AS i GROUP BY i.brojIndeksa) AS p ON s.brojIndeksa = p.brojIndeksa WHERE s.godStudija = 3;

SELECT S.brojIndeksa,S.ime,S.prezime,COUNT(I.brojIndeksa)FROM student AS S INNER JOIN ispit AS I ON S.brojIndeksa = i.brojIndeksa 
WHERE s.godStudija = 3 GROUP BY S.brojIndeksa,S.ime,S.prezime;
