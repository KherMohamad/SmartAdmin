IF NOT EXISTS(SELECT TOP 1 1 FROM sys.foreign_keys AS F 
WHERE OBJECT_NAME(F.[parent_object_id]) = 'ANGAJATI' AND OBJECT_NAME(F.[referenced_object_id]) = 'DEPARTAMENTE'
AND F.[name] = 'fk_angajati_dept')
ALTER TABLE ANGAJATI
ADD CONSTRAINT fk_angajati_dept
FOREIGN KEY (idDepartament) REFERENCES DEPARTAMENTE(idDepartament);