USE VideoKlub;
/*Prikazati id glumca, prezime, ime, inventarni broj filma i naziv gde je naziv filma Troja*/
CREATE VIEW troja
AS
SELECT G.idglumca, G.prezime, G.ime, F.[inventarni broj], F.naziv FROM glumac AS G 
INNER JOIN glumi AS GL ON Gl.idglumca = G.idglumca
INNER JOIN film AS F ON GL.[inventarni broj] = F.[inventarni broj] WHERE F.naziv='Troja';
SELECT * FROM troja

/*Prikazati inventarni broj filma, naziv filma, godinu snimanja filma gde je glumac Milutin Miloševic*/
CREATE VIEW milutin
AS
SELECT F.[inventarni broj],F.naziv,F.[godina snimljen],G.idglumca,G.prezime,G.ime FROM film AS F INNER JOIN
glumi as GL ON F.[inventarni broj] = GL.[inventarni broj]
INNER JOIN glumac AS G ON G.idglumca = GL.idglumca
WHERE G.ime = 'Milutin' AND G.prezime = 'Miloševic'
SELECT * FROM milutin

/*Napisati broj licne karte, ime, prezime svih clanova koji zive u Zrenjaninu*/
CREATE VIEW mestoclana
AS
SELECT c.[broj licne karte], c.ime, c.prezime FROM clan AS c INNER JOIN mesto AS m
ON c.[ptt stanuje] = m.ptt WHERE m.naziv = 'Zrenjanin';

SELECT * FROM mestoclana;

