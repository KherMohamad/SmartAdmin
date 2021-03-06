
CREATE OR ALTER procedure [dbo].[spProject_insertAngajat] @nume varchar(50),
											 @prenume varchar(50),
											 @data_nasterii date,
											 @isManager varchar(2),
											 @numeDepartament varchar(50)
as
begin
DECLARE @idDept AS int
SET @idDept = (SELECT idDepartament from departamente WHERE nume = @numeDepartament)
insert into Angajati values (
	@nume,
	@prenume,
	@data_nasterii,
	@isManager,
	@idDept
	)
if @idDept is not NULL
	BEGIN
	UPDATE Departamente
	SET nrAngajati = nrAngajati + 1
	WHERE idDepartament = @idDept
	END
end