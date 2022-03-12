CREATE TRIGGER istoricAngajari_trigger
ON Angajati
AFTER INSERT
AS
INSERT INTO istoric_angajari
	SELECT CONCAT(nume, ' ', prenume), GETDATE() FROM inserted

