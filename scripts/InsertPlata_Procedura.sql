
CREATE OR ALTER procedure [dbo].[spProject_insertPlata] @idAngajat int,
										   @idTipPlata int,
										   @valoarePlata int,
										   @idValuta int,
										   @dataPlata date
as
begin
insert into Plati 
	values(
		@idAngajat,
		@idTipPlata,
		@valoarePlata,
		@idValuta,
		@dataPlata)
end