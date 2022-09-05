CREATE PROCEDURE Firmicaaa (@brproj AS INT) 
AS
BEGIN
SELECT u.brproj,imeproj,r.idbr,ime,prezime,brsati,funckija FROM Radnik r INNER JOIN Ucesce u ON r.idbr=u.idbr INNER JOIN Projekat p ON u.brproj=p.brproj WHERE u.brproj=@brproj
END
EXEC Firmicaaa 100
CREATE PROCEDURE Firma (@brproj AS INT) 
AS
BEGIN
SELECT u.brproj,imeproj,r.idbr,ime,prezime,brsati,funckija FROM Radnik r INNER JOIN Ucesce u ON r.idbr=u.idbr INNER JOIN Projekat p ON u.brproj=p.brproj WHERE u.brproj=@brproj
SELECT u.brproj,p.imeproj,count(u.idbr),sum(u.brsati) FROM Ucesce u INNER JOIN Projekat p ON u.brproj=p.brproj
GROUP BY u.brproj,p.imeproj
END
EXEC Firma 100