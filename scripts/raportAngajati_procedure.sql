USE [windsoft_projDB]
GO
/****** Object:  StoredProcedure [dbo].[spProject_GetEmployeeData]    Script Date: 24.01.2022 22:51:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER procedure [dbo].[spProject_GetEmployeeData]
	@idAngajat int,
	@dataInceput date,
	@dataFinal date
as
begin
	if (@idAngajat = -1 or @idAngajat IS NULL) 
	begin
	WITH CTE_subClause
	AS (
		select Plati.dataPlata as dataPlata, Angajati.IDAngajat as id, Angajati.isManager as isManager, nume as nume, prenume as prenume,
		case
			when (DATEADD(yy, DATEDIFF(yy, dataNasterii, GETDATE()), dataNasterii) < GETDATE())
			then
				year(getdate()) - year(dataNasterii)
			else 
				(year(getdate()) - year(dataNasterii) - 1)
			end
		as varsta, 
		case 
		when (Angajati.IDAngajat = Plati.idAngajat and Plati.idTipPlata = 1 
		and dataPlata >= @dataInceput 
		and dataPlata <= @dataFinal) 
		then sum(valoarePlata)
		else 
		0
		end as salarii
		,
		case 
		when (Angajati.IDAngajat = Plati.idAngajat and Plati.idTipPlata = 2 
		and dataPlata >= @dataInceput 
		and dataPlata <= @dataFinal) 
		then sum(valoarePlata)
		else 
		0
		end as bonusuri,
		case 
		when (Angajati.IDAngajat = Plati.idAngajat and Plati.idTipPlata = 3 
		and dataPlata >= @dataInceput 
		and dataPlata <= @dataFinal) 
		then sum(valoarePlata)
		else 
		0
		end as prime
		from Angajati, Plati
		group by Angajati.IDAngajat, dataPlata, nume, prenume, dataNasterii, Plati.idAngajat, Angajati.isManager, Plati.idTipPlata
		)
		select id, isManager, varsta, nume, prenume, 
		case
		when (max(salarii) = 0)
		then '0.00'
		else
			CONCAT(str(max(salarii), len(max(salarii))), numevaluta)
		end as salarii
		,
		case
		when (max(bonusuri) = 0)
		then '0.00'
		else
			CONCAT(str(max(bonusuri), len(max(bonusuri))), numevaluta)
		end as bonusuri,
		case
		when (max(prime) = 0)
		then '0.00'
		else 
			CONCAT(str(max(prime), len(max(prime))), numevaluta)
		end as prime
		from CTE_subClause, Valute, Plati
		where Valute.idValuta = Plati.idValuta and Plati.idAngajat = id
		group by id, nume, prenume, varsta, isManager, numeValuta
		order by isManager
	end
	else 
	begin
		WITH CTE_subClause 
		AS (
		select Plati.dataPlata as dataPlata, Angajati.IDAngajat as id, Angajati.isManager as isManager, nume as nume, prenume as prenume,
		year(getdate()) - year(dataNasterii) as varsta, 
		case 
		when (Angajati.IDAngajat = Plati.idAngajat and Plati.idTipPlata = 1 
		and dataPlata >= @dataInceput 
		and dataPlata <= @dataFinal) 
		then sum(valoarePlata)
		else 
		0
		end as salarii
		,
		case 
		when (Angajati.IDAngajat = Plati.idAngajat and Plati.idTipPlata = 2 
		and dataPlata >= @dataInceput 
		and dataPlata <= @dataFinal) 
		then sum(valoarePlata)
		else 
		0
		end as bonusuri,
		case 
		when (Angajati.IDAngajat = Plati.idAngajat and Plati.idTipPlata = 3 
		and dataPlata >= @dataInceput 
		and dataPlata <= @dataFinal) 
		then sum(valoarePlata)
		else 
		0
		end as prime
		from Angajati, Plati
		group by Angajati.IDAngajat, dataPlata, nume, prenume, dataNasterii, Plati.idAngajat, Angajati.isManager, Plati.idTipPlata
		)
		select id, isManager, varsta, nume, prenume, 
		case
		when (max(salarii) = 0)
		then '0.00'
		else
			CONCAT(str(max(salarii), len(max(salarii))), numevaluta)
		end as salarii
		,
		case
		when (max(bonusuri) = 0)
		then '0.00'
		else
			CONCAT(str(max(bonusuri), len(max(bonusuri))), numevaluta)
		end as bonusuri,
		case
		when (max(prime) = 0)
		then '0.00'
		else 
			CONCAT(str(max(prime), len(max(prime))), numevaluta)
		end as prime
		from CTE_subClause, Valute, Plati
		where Valute.idValuta = Plati.idValuta and id = Plati.idAngajat and id = @idAngajat
		group by id, nume, prenume, varsta, isManager, numeValuta
		order by isManager
	end
end