SELECT MAX(r.plata),SUM(r.plata + ISNULL(r.premija,0))FROM Radnik AS r GROUP BY r.brod
/*----------------*/
CREATE PROCEDURE sredstva(@brod INT)
AS
BEGIN
SELECT MAX(r.plata),SUM(r.plata + ISNULL(r.premija,0))FROM Odeljenje AS o LEFT JOIN Radnik AS r ON o.brod = r.brod WHERE o.brod = @brod;
END
EXEC sredstva 20
/*----------------*/
CREATE PROCEDURE sredstva2(@brod INT)
AS
BEGIN
SELECT MAX(r.plata),SUM(r.plata + ISNULL(r.premija,0))FROM Radnik AS r WHERE r.brod = @brod;
END
EXEC sredstva2 10
/*----------------*/
SELECT u.brproj,p.imeproj,u.idbr,r.ime,r.prezime,u.brsati,u.funckija FROM Radnik AS r RIGHT JOIN Ucesce AS u ON r.idbr = u.idbr JOIN Projekat AS p ON u.brproj = p.brproj;
/*ukupan broj radnika po projektu i ukupan broj sati za projekat*/
SELECT p.brproj,COUNT(r.idbr) AS Broj_radnika, SUM(u.brsati) AS Broj_sati FROM Projekat AS p RIGHT JOIN UCESCE AS u ON p.brproj = u.brproj JOIN Radnik AS r ON r.idbr = u.idbr GROUP BY p.brproj
/*----------------*/
CREATE PROCEDURE projekti(@brproj INT)
AS
BEGIN
SELECT p.brproj,COUNT(u.idbr) AS Broj_radnika, SUM(u.brsati) AS Broj_sati FROM Projekat AS p RIGHT JOIN UCESCE AS u ON p.brproj = u.brproj WHERE p.brproj = @brproj GROUP BY p.brproj;
END
EXEC projekti 100
/*----------------*/
SELECT * FROM Projekat;
SELECT * FROM Radnik;
SELECT * FROM Ucesce;
SELECT * FROM Odeljenje;
/*----------------*/
/*Odeljenje i broj radnika po odeljenjima cije ime pocinje sa j*/
SELECT o.brod, COUNT(r.idbr) FROM Odeljenje AS o LEFT JOIN Radnik AS r ON o.brod = r.brod AND r.ime LIKE 'J%' GROUP BY o.brod;