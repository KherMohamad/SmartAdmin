IF NOT EXISTS(SELECT TOP 1 1 FROM sys.foreign_keys AS F 
WHERE OBJECT_NAME(F.[parent_object_id]) = 'PLATI' AND OBJECT_NAME(F.[referenced_object_id]) = 'ANGAJATI'
AND F.[name] = 'fk_plati_angajati')
ALTER TABLE PLATI
ADD CONSTRAINT fk_plati_angajati
FOREIGN KEY (idAngajat) REFERENCES ANGAJATI(idAngajat);

IF NOT EXISTS(SELECT TOP 1 1 FROM sys.foreign_keys AS F 
WHERE OBJECT_NAME(F.[parent_object_id]) = 'PLATI' AND OBJECT_NAME(F.[referenced_object_id]) = 'TIPPLATI'
AND F.[name] = 'fk_plati_tipPlati')
ALTER TABLE PLATI
ADD CONSTRAINT fk_plati_tipPlati
FOREIGN KEY (idTipPlata) REFERENCES TIPPLATI(idTipPlata);

IF NOT EXISTS(SELECT TOP 1 1 FROM sys.foreign_keys AS F 
WHERE OBJECT_NAME(F.[parent_object_id]) = 'PLATI' AND OBJECT_NAME(F.[referenced_object_id]) = 'VALUTE'
AND F.[name] = 'fk_plati_valute')
ALTER TABLE PLATI
ADD CONSTRAINT fk_plati_valute
FOREIGN KEY (idValuta) REFERENCES VALUTE(idValuta);



