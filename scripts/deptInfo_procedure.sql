
CREATE OR ALTER PROCEDURE [dbo].[spProject_getInfoDepartamente] @data_inceput date, 
													   @data_sfarsit date
AS
BEGIN
WITH CTE_Subclause
AS (
	SELECT  a.idDepartament, sum(p.valoarePlata) AS totalPlati
	from Plati p, Angajati a
	where p.idAngajat = a.IDAngajat and p.dataPlata >= @data_inceput and p.dataPlata <= @data_sfarsit
	group by a.idDepartament
	)
	
SELECT nume, nrAngajati, [dbo].getnumarManageri(d.idDepartament), Venit, CTE_Subclause.totalPlati AS CostDepartament
from Departamente d, CTE_Subclause 
WHERE d.idDepartament = CTE_Subclause.idDepartament
ORDER by nrAngajati DESC
END

select * from Angajati
