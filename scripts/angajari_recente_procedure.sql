CREATE OR ALTER PROCEDURE getAngajariRecente
AS
BEGIN
SELECT  TOP 10
idAngajat, NumeAngajat, dataAngajare FROM
istoric_angajari
ORDER BY dataAngajare desc
END

