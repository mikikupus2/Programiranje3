USE master;
GO
USE KONTROLNI_3003;
GO
CREATE PROCEDURE procedura1(@parametar1 AS int,@parametar2 AS int)
AS
BEGIN
	Select UCID,Ime,Prezime,Prosek from Ucenici where SKID = @parametar1
	SELECT S.Naziv, S.Mesto, Razred, AVG(Prosek) AS Prosecna_ocena FROM Skole AS S LEFT JOIN Ucenici AS U ON U.SKID = S.SKID WHERE U.RAZRED =@parametar2 
	GROUP BY S.Naziv,S.Mesto,U.Razred ORDER BY Prosecna_ocena DESC
END
EXECUTE procedura1 1 , 4

SELECT U.UCID, U.ime, U.Prezime, S.Naziv,S.Mesto,U.Prosek,P.Ime + P.Prezime AS [Razredni staresina]
FROM Ucenici AS U LEFT JOIN Skole S ON U.SKID = S.SKID INNER JOIN Profesori AS P ON U.PROFID = P.PROFID

DECLARE @parametar3 AS FLOAT
SET @parametar3 = 4.6
SELECT S.SKID, S.Naziv, S.Mesto,U.Ime + U.Prezime AS [Ime i prezime ucenika], U.Razred, U.Odeljenje FROM Ucenici AS U LEFT JOIN Skole AS S ON U.SKID = S.SKID WHERE U.Prosek < @parametar3
