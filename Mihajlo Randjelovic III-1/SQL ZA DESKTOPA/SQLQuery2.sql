USE FIRMA;
/*SELECT ime,plata,premija  FROM Radnik WHERE posao='elektricar' ORDER BY PREZIME DESC;*/
/*SELECT IME,kvalif,plata,premija FROM RADNIK ORDER BY premija DESC,kvalif DESC,plata ASC;*/
/*SELECT IME,PREZIME,brod FROM Radnik WHERE IME LIKE 'M%' ORDER BY IME DESC;*/
/*SELECT IME,PREZIME FROM Radnik WHERE IME LIKE '[A,B]%'  ORDER BY IME DESC;
SELECT IME,PREZIME FROM Radnik WHERE IME LIKE 'M[O,I]%';*/
/*SELECT IME,PREZIME FROM Radnik WHERE IME NOT LIKE '%A%';*/
/*SELECT IME,kvalif,PREMIJA FROM RADNIK WHERE premija IS NOT NULL;*/
/*SELECT IME FROM RADNIK WHERE PLATA BETWEEN 1000 AND 2000;*/
/*SELECT IME,PLATA FROM RADNIK WHERE PLATA IN(1000,2600,900);*/
/*SELECT MIN(PLATA) AS MINIMALNA,MAX(PLATA) AS MAKSIMALNA,AVG(PLATA) AS PROSECA FROM Radnik;*/
/*SELECT ROUND(AVG(PLATA),2,1) FROM RADNIK WHERE posao='ANALITICAR';*/
/*SELECT COUNT(IME) FROM RADNIK WHERE posao='ANALITICAR';*/
/*SELECT COUNT(DISTINCT POSAO) FROM Radnik;*/
/*SELECT SUM(PLATA) FROM Radnik WHERE kvalif='VSS';
SELECT SUM(PLATA) FROM Radnik WHERE kvalif='VSS';*/
SELECT SUM(PLATA) FROM Radnik WHERE BROD IN(30,40);
