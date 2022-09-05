/*SELECT ime,prezime,ID_PREDMETA FROM dosije,ispit WHERE dosije.INDEKS = ispit.INDEKS;
SELECT ime,prezime,ID_PREDMETA from dosije INNER JOIN ispit ON dosije.INDEKS = ispit.INDEKS;
SELECT d.INDEKS,d.ime,d.prezime,p.NAZIV FROM dosije AS d INNER JOIN ispit AS i ON d.INDEKS = i.INDEKS INNER JOIN predmet AS p ON i.ID_PREDMETA = p.ID_PREDMETA WHERE i.OCENA > 5.0;
SELECT d.INDEKS,d.ime,d.prezime,p.NAZIV FROM dosije AS d, ispit AS i ,predmet AS p WHERE d.INDEKS = i.INDEKS AND i.ID_PREDMETA = p.ID_PREDMETA AND i.OCENA > 5.0;
/*Consolas*/
SELECT d.INDEKS, i.ID_PREDMETA, i.OCENA, i.DATUM_ISPITA FROM dosije AS d LEFT JOIN ispit AS i ON d.INDEKS = i.INDEKS
SELECT d.INDEKS, i.ID_PREDMETA, i.OCENA, i.DATUM_ISPITA FROM ispit AS i RIGHT JOIN dosije AS d ON d.INDEKS = i.INDEKS
/*SELECT d.INDEKS, i.ID_PREDMETA, i.OCENA, i.DATUM_ISPITA FROM ispit AS i JOIN dosije AS d ON d.INDEKS = i.INDEKS*/
*/
CREATE PROCEDURE spOceneSaIspita 
AS
BEGIN

SELECT d.INDEKS, i.ID_PREDMETA, i.OCENA, i.DATUM_ISPITA 
FROM dosije AS d LEFT JOIN ispit AS i 
ON d.INDEKS = i.INDEKS

END;

EXECUTE spOceneSaIspita;