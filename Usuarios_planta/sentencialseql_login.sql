CREATE DEFINER=`root`@`localhost` PROCEDURE `Informe_horario`(
in _fecha_inicio varchar(20),
in _fecha_final varchar (20)
)
BEGIN
SELECT *
    FROM control_horarios    
    WHERE Fecha between _fecha_inicio and  _fecha_final order by Fecha asc;
END

tabla control_horarios
id               | int          | NO   | PRI | NULL    | auto_increment |
| Identificacion   | int          | YES  |     | NULL    |                |
| Nombre           | varchar(150) | YES  |     | NULL    |                |
| Etapa            | varchar(45)  | YES  |     | NULL    |                |
| Fecha            | varchar(45)  | YES  |     | NULL    |                |
| Entrada          | varchar(20)  | YES  |     | NULL    |                |
| Salida_Break     | varchar(20)  | YES  |     | NULL    |                |
| Entrada_Break    | varchar(20)  | YES  |     | NULL    |                |
| Total_Break      | varchar(20)  | YES  |     | NULL    |                |
| Salida_Almuerzo  | varchar(20)  | YES  |     | NULL    |                |
| Entrada_Almuerzo | varchar(20)  | YES  |     | NULL    |                |
| Total_Almuerzo   | varchar(20)  | YES  |     | NULL    |                |
| Salida           | varchar(20)  | YES  |     | NULL    |                |
| Total_Dia        | varchar(20)  | YES  |     | NULL    |                |
| Observaciones    | varchar(200) | YES  |     | NULL


#Procedimiento almacenado entrada 
CREATE DEFINER=`root`@`localhost` PROCEDURE `Entrada`(
in _Identificacion int,
in _Nombre VARCHAR(150),
in _Etapa varchar(45),
in _Fecha varchar(45),
in _Entrada varchar(20),
in _Observaciones varchar(200)
)
BEGIN
DECLARE prueba int;
SELECT count(Identificacion) into @prueba FROM
control_horarios
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
IF @prueba > 0 then
rollback;
else
insert into control_horarios(Identificacion,Nombre,Etapa,Fecha,Entrada,Observaciones)
			values (_Identificacion,_Nombre,_Etapa,_Fecha,_Entrada,_Observaciones); 
end if;
END
#Procedimiento almacenado salida al break
CREATE DEFINER=`root`@`localhost` PROCEDURE `break1`(
in _Identificacion int,
in _Fecha varchar(45),
in _Salida_Break varchar(20)
)
BEGIN
DECLARE prueba int;
SELECT count(Salida_Break) into @prueba FROM
control_horarios
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
IF @prueba > 0 then
rollback;
ELSE
update control_horarios set
Salida_Break=_Salida_Break
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
END IF;
END
#Procedimiento almacenado entrada del break
CREATE DEFINER=`root`@`localhost` PROCEDURE `break2`(
in _Identificacion int,
in _Fecha varchar(45),
in _Entrada_Break varchar(20)
)
BEGIN
DECLARE prueba int;
SELECT count(Entrada_Break) into @prueba FROM
control_horarios
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
IF @prueba > 0 then
rollback;
ELSE
update control_horarios set
Entrada_Break=_Entrada_Break
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
END IF;
END
#Procedimiento almacenado salida a almorzar
CREATE DEFINER=`root`@`localhost` PROCEDURE `almuerzo1`(
in _Identificacion int,
in _Fecha varchar(45),
in _Salida_Almuerzo varchar(20)
)
BEGIN
DECLARE prueba int;
SELECT count(Salida_Almuerzo) into @prueba FROM
control_horarios
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
IF @prueba > 0 then
rollback;
ELSE
update control_horarios set
Salida_Almuerzo=_Salida_Almuerzo
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
END IF;
END
#Procedimiento almacenado entrada del almuerzo
CREATE DEFINER=`root`@`localhost` PROCEDURE `almuerzo2`(
in _Identificacion int,
in _Fecha varchar(45),
in _Entrada_Almuerzo varchar(20)
)
BEGIN
DECLARE prueba int;
SELECT count(Entrada_Almuerzo) into @prueba FROM
control_horarios
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
IF @prueba > 0 then
rollback;
ELSE
update control_horarios set
Entrada_Almuerzo=_Entrada_Almuerzo
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
END IF;
END
#Procedimiento almacenado salida
CREATE DEFINER=`root`@`localhost` PROCEDURE `salida`(
in _Identificacion int,
in _Fecha varchar(45),
in _Salida varchar(20)
)
BEGIN
DECLARE prueba int;
SELECT count(Salida) into @prueba FROM
control_horarios
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
IF @prueba > 0 then
rollback;
else
update control_horarios set
Salida=_Salida
WHERE Identificacion=_Identificacion and Fecha=_Fecha;
end if;
END