USE Firma;
GO
SELECT * FROM Radnik;
SELECT plata FROM Radnik;
SELECT DISTINCT plata FROM Radnik;
SELECT ime + prezime, plata, posao FROM Radnik WHERE plata < 1000;
SELECT ime + prezime, plata FROM Radnik WHERE plata > 2000 ORDER BY datzap;
SELECT ime + prezime, plata FROM Radnik WHERE plata > 2000 AND datzap > '01-01-2000' ORDER BY datzap;
SELECT ime + prezime, plata FROM Radnik WHERE plata > 2000 AND (datzap <'01-01-1972' or datzap > '01-01-2000');
SELECT ime + prezime, plata FROM Radnik WHERE plata BETWEEN 1000 AND 2000;
SELECT ime + prezime, plata FROM Radnik WHERE plata NOT BETWEEN 1000 AND 2000;
SELECT ime + prezime, plata FROM Radnik WHERE NOT plata BETWEEN 1000 AND 2000;
SELECT ime + prezime, plata FROM Radnik WHERE plata IN (900, 1000, 2600);
SELECT ime + prezime, plata FROM Radnik WHERE ime LIKE 'S%D_N';
SELECT plata, prezime FROM Radnik GROUP BY plata, prezime;
SELECT plata, premija FROM Radnik GROUP BY plata, premija;