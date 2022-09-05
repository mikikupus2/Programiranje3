USE Firma;
GO
CREATE PROCEDURE Radnik_od(@IDBR AS INT)
AS
BEGIN
	SELECT R.idbr, R.ime,R.prezime, O.imeod, O.mesto
	FROM Radnik R LEFT JOIN Odeljenje O ON R.brod = O.brod
	WHERE R.idbr > @IDBR
	SELECT * FROM Radnik
	SELECT * FROM Odeljenje
END;

EXEC Radnik_od 7000