
SELECT imeod FROM ODELJENJE

SELECT Ime,imeod FROM Radnik,odeljenje

SELECT Ime,posao,imeod from radnik,odeljenje WHERE radnik.brod = odeljenje.brod
GO

SELECT * FROM RADNIK
GO
SELECT * FROM ODELJENJE
GO

SELECT ime,imeod, from radnik AS R, odeljenje AS O where R.brod = O.brod
SELECT Ime,imeod FROM Radnik,odeljenje
select ime,imeod from radnik cross join odeljenje

select ime,imeod from radnik as r inner join  odeljenje as o on r.brod=o.brod

select ime,posao,p.* from radnik as r inner join ucesce as u
on r.idbr = u.idbr
inner join projekat as p on u.brproj = p.brproj