CREATE FUNCTION getnumarManageri
( @dept_id INT )
RETURNS INT

AS

BEGIN
DECLARE @nrManageri as INT
SET @nrManageri = 
(SELECT count(*)
	FROM Angajati
	WHERE isManager = 'DA' AND idDepartament = @dept_id
)
RETURN @nrManageri

END

SELECT  a.idDepartament, sum(p.valoarePlata)
	from Plati p, Angajati a
	where p.idAngajat = a.IDAngajat
	group by a.idDepartament
