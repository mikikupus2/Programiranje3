--2.
CREATE DATABASE KONTROLNI_3003;
USE KONTROLNI_3003;
CREATE TABLE SKOLE(
	SKID INT PRIMARY KEY IDENTITY(1,1),
	NAZIV VARCHAR(30),
	MESTO VARCHAR(30)
);
CREATE TABLE PROFESORI(
	PROFID INT PRIMARY KEY IDENTITY(1,1),
	IME VARCHAR(30),
	PREZIME VARCHAR(30),
	SKID INT,
	FOREIGN KEY (SKID) REFERENCES SKOLE(SKID)
);
CREATE TABLE UCENICI(
	UCID INT PRIMARY KEY IDENTITY(1,1),
	IME VARCHAR(30),
	PREZIME VARCHAR(30),
	RAZRED INT,
	ODELJENJE INT,
	PROSEK DECIMAL(2,1),
	SKID INT,
	PROFID INT,
	FOREIGN KEY (SKID) REFERENCES SKOLE(SKID),
	FOREIGN KEY (PROFID) REFERENCES PROFESORI(PROFID)
);
INSERT INTO SKOLE VALUES('Tehnicka','Smederevo'),('Cvijiceva','Smederevo'),('Gimnazija','Beograd');
INSERT INTO PROFESORI VALUES ('Milos','Gavrilovic',2),('Petar','Petrovic',1),('Darko','Jevtic',3);
INSERT INTO UCENICI VALUES ('Janko','Jankovic',4,1,4.6,1,3);

SELECT UCID,IME,PREZIME,PROSEK 
FROM UCENICI U JOIN SKOLE S 
ON U.UCID=S.SKID WHERE U.SKID=2;

SELECT NAZIV,MESTO,RAZRED,AVG(PROSEK) AS PROSEK_RAZREDA
FROM (SKOLE S JOIN UCENICI U ON U.SKID=S.SKID)
GROUP BY U.RAZRED,S.NAZIV,S.MESTO
HAVING U.RAZRED=2
ORDER BY AVG(PROSEK) DESC;

SELECT UCID,IME,PREZIME,PROSEK,S.* 
FROM UCENICI U JOIN SKOLE S 
ON U.SKID=S.SKID;

SELECT U.UCID,U.IME,U.PREZIME,S.NAZIV,S.MESTO,U.PROSEK,P.IME,P.PREZIME 
FROM ((UCENICI U LEFT JOIN SKOLE S ON U.SKID=S.SKID)
JOIN PROFESORI P ON U.PROFID=P.PROFID);

DECLARE @PROSEK AS INT
SET @PROSEK=5;
SELECT S.SKID,NAZIV,MESTO,IME,PREZIME,RAZRED,ODELJENJE,PROSEK 
FROM SKOLE S JOIN UCENICI U ON U.SKID=S.SKID
WHERE PROSEK<@PROSEK;

CREATE PROCEDURE PROC_2
@PROSEK DECIMAL(2,1)
AS
BEGIN
	SELECT S.SKID,NAZIV,MESTO,IME,PREZIME,RAZRED,ODELJENJE 
	FROM SKOLE S JOIN UCENICI U ON U.SKID=S.SKID
	WHERE PROSEK<@PROSEK;
END;

EXEC PROC_2 @PROSEK=4.8;
EXEC PROC_1 @ID=2,@RAZRED=4;