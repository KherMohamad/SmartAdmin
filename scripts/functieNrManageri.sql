
CREATE OR ALTER FUNCTION [dbo].[getnumarManageri]
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