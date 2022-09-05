USE FAKULTET2019;
USE VideoKlub;
/* 1. */

/* a) */
DECLARE @GODINA AS INT = 2006;
SELECT f.[inventarni broj],f.naziv,g.ime,g.prezime,f.[godina snimljen]
FROM ((FILM F JOIN glumi GL ON F.[inventarni broj]=GL.[inventarni broj]) JOIN glumac G ON G.idglumca=GL.idglumca)
WHERE [godina snimljen]=@GODINA;

/* b. */
SELECT f.[inventarni broj],f.naziv,g.ime,g.prezime,f.[godina snimljen] 
FROM glumac G, film F,(SELECT * FROM GLUMI GL WHERE GL.[inventarni broj] IN (SELECT [inventarni broj] FROM FILM WHERE [godina snimljen]=2006)) AS TAB_1 
WHERE TAB_1.idglumca=G.idglumca AND TAB_1.[inventarni broj]=f.[inventarni broj];


SELECT f.[inventarni broj],f.naziv,g.ime,g.prezime,f.[godina snimljen] 
FROM glumac G, film F
WHERE G.idglumca = ANY (SELECT GL.idglumca FROM GLUMI GL WHERE GL.[inventarni broj] IN (SELECT [inventarni broj] FROM FILM WHERE [godina snimljen]=2006))
AND F.[godina snimljen]=2006 ;

SELECT G.idglumca, G.prezime, G.ime, F.[inventarni broj], F.naziv FROM glumac AS G,
film AS F WHERE G.idglumca = ANY(SELECT Gl.idglumca FROM glumi GL WHERE GL.[inventarni broj] = F.[inventarni broj]) 
AND G.idglumca = 1;

/* 2. */
/* a. */
USE Fakultet2019;
SELECT n.ime,n.prezime,COUNT(*) as broj_studenata
FROM ((nastavnik N JOIN predaje PR ON N.IDNASTAVNIKA=PR.idNastavnika) JOIN slusa sl on sl.idPredmeta=pr.idPredmeta) 
GROUP BY n.ime,n.prezime
HAVING COUNT(*) > 2; 

/* 3. */

/* 4. */

SELECT S.brojIndeksa,S.ime,S.prezime,COUNT(sl.idPredmeta) AS Broj_Predemta
FROM STUDENT S JOIN SLUSA SL ON SL.brojIndeksa=S.brojIndeksa
GROUP BY S.brojIndeksa,S.ime,S.prezime
HAVING S.brojIndeksa IN (SELECT brojIndeksa FROM student where godStudija=3);

/* 5. */
SELECT S.brojIndeksa,ime,prezime,avg(ocena) as Prosek 
FROM student S JOIN ispit I ON S.brojIndeksa=I.brojIndeksa 
GROUP BY S.brojIndeksa,ime,prezime
HAVING AVG(OCENA)>8;