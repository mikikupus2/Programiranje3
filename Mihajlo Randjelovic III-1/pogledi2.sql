/*USE Firma;
SELECT * FROM Odeljenje;
SELECT * FROM Ucesce;
CREATE VIEW ODELJ10
AS
SELECT brod,ime,prezime,plata,premija FROM Radnik
WHERE brod = 10 WITH CHECK OPTION;
SELECT * FROM ODELJ10;
UPDATE ODELJ10;
SET brod=30  WHERE premija is null;*/
/*

USE Fakultet2019;
GO

CREATE TABLE KatedraLog
(
    idKatedra INT,
    naziv NVARCHAR(30),
    datum DATE,
    vrsta NCHAR(10)
);*/
CREATE TRIGGER Kat_I_D
ON katedra
AFTER INSERT, DELETE
AS
BEGIN
SET NOCOUNT ON
INSERT INTO KatedraLog(idKatedra,naziv,datum,vrsta)
SELECT i.idKatedre,i.naziv,GETDATE(),'I'
FROM inserted AS i
UNION ALL
SELECT d.idKatedre,d.naziv,GETDATE(),'D'
FROM deleted AS d
END

DELETE FROM katedra
WHERE idKatedre = 5;
SELECT * FROM KatedraLog;