/*Iz baze firma trazimo radnike koji imaju najmanju platu
u firmi*/
USE Firma;
SELECT ime + prezime AS Radnik, posao, plata FROM Radnik WHERE plata = (SELECT MIN(plata) FROM Radnik)
/*ime,  posao platu za radnike koji imaju vecu platu od Milosa*/
SELECT ime, posao, plata FROM Radnik WHERE plata > (SELECT plata FROM Radnik WHERE ime = 'Milos')
SELECT ime, posao, plata FROM Radnik WHERE plata > (SELECT plata FROM Radnik WHERE ime = 'Janko')
/*sifra odeljenja, minimalna plata u odeljenju ali za ona odeljenja u kojima je minimalna plata veca 
od minimalne plate u odeljenju broj 20*/
SELECT O.brod, MIN(R.plata) FROM Odeljenje AS O INNER JOIN Radnik AS R ON O.brod = R.brod 
GROUP BY O.brod HAVING MIN(R.plata) > (SELECT MIN(R.plata)FROM Radnik AS R WHERE r.brod = 20) 


SELECT R.brod, MIN(R.plata) FROM Radnik AS R
GROUP BY R.brod HAVING MIN(R.plata) > (SELECT MIN(R.plata)FROM Radnik AS R
WHERE R.brod = 20) 

/*Broj odeljenja, ime radnika, posao i plata za sve one cija je plata veca ili jednaka prosecnoj plati
u odeljenju*/
SELECT brod, ime , posao, plata FROM Radnik R1 WHERE plata >=(SELECT AVG(plata)
FROM Radnik R2 GROUP BY brod HAVING R1.brod = R2.brod)

SELECT brod, ime , posao, plata FROM Radnik R1 WHERE plata >=(SELECT AVG(plata)
FROM Radnik R2)
