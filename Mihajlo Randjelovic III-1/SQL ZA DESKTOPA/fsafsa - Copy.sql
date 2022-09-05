Use nesto;
GO
INSERT INTO Korisnik
VALUES(1,'Ana',null),
(2,'Steva','m'),
(3,'Marta','z'),
(4,'Petra','z');
GO
INSERT INTO Prijatelji
VALUES(1,2),
(1,3),
(2,3);
GO
SELECT * FROM Korisnik
SELECT * FROM Prijatelji
SELECT k.ime, COUNT(*) as [broj_prijatelja] from Korisnik as k
LEFT JOIN Prijatelji as p on p.korisnik1 = k.id or p.korisnik2 = k.id WHERE k.pol ='z' 
GROUP BY k.id, k.ime