USE master
GO
CREATE TABLE vrednosti
(vrednost DEC(7,3));
GO
INSERT INTO vrednosti
VALUES(32.5),
(-178.465),
(132.5),
(-678.445);
GO
SELECT *FROM vrednosti;
GO
SELECT ABS(-45.78);
GO
SELECT ABS(vrednost) FROM vrednosti;
GO
SELECT CEILING(vrednost) FROM vrednosti;
GO
SELECT vrednost AS vrednost, CEILING(vrednost) AS prva_veca, FLOOR(vrednost) AS prva_manja FROM vrednosti;
GO
SELECT vrednost AS vrednost, FLOOR(vrednost)AS prva_manja FROM vrednosti;
GO
SELECT POWER(2,3), POWER(2.00,3);
GO
SELECT POWER(2,3.6), POWER(2.00,3.6);
GO
SELECT vrednost AS vrednost, POWER(vrednost,2) AS STEPEN FROM vrednosti;
GO
SELECT SQUARE(vrednost) FROM vrednosti;
GO
SELECT vrednost AS vrednost,SQUARE(vrednost)AS kvadrat FROM vrednosti;
GO
SELECT vrednost AS vrednost,SQUARE(vrednost)AS kvadrat, SQRT(ABS(vrednost)) AS koren FROM vrednosti;
GO
SELECT RAND();
GO
SELECT RAND() prazno,RAND() prazno,RAND() prazno,RAND() prazno,RAND() prazno;
GO
SELECT RAND(1) j,RAND(1) j,RAND ()prazno,RAND() prazno,RAND(2) d;
GO
SELECT RAND(2) d,RAND(2) d,RAND(4) c,RAND(4) c,RAND(4) c;
GO
SELECT RAND() *100;
GO
SELECT CEILING (RAND() *100);
GO
SELECT FLOOR (RAND() *100);
GO
SELECT ROUND (567.345,1),  ROUND (567.345,2);
GO
SELECT ROUND (567.345,1,1),  ROUND (567.345,2,1);
GO
SELECT ROUND (567.345,-1),  ROUND (567.345,-2);
GO
SELECT ROUND (567.345,-1,1),  ROUND (567.345,-2,1);
GO