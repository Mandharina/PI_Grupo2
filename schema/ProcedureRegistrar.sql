DELIMITER //

CREATE DEFINER=`root`@`localhost` PROCEDURE `ProcedureRegistrar`(
    IN Nom VARCHAR(30),
    IN Ape VARCHAR(40),
    IN pDni INT,
    IN Fec DATE,
    IN Gen VARCHAR(15),
    IN Cel VARCHAR(15),
    IN Dom VARCHAR(100),
    OUT rta INT
)
BEGIN
    DECLARE filas INT DEFAULT 0;
    DECLARE existe INT DEFAULT 0;

    SET filas = (SELECT COUNT(*) FROM cliente);

    IF filas = 0 THEN
        SET filas = 1000;
    ELSE
        SET filas = (SELECT MAX(NroCarnet) + 1 FROM cliente);
    END IF;

    SET existe = (SELECT COUNT(*) FROM cliente WHERE DNI = pDni);

    IF existe = 0 THEN
        INSERT INTO cliente (
            NroCarnet, Nombre, Apellido, DNI, FechaNacimiento, Genero, NumCel, Domicilio
        ) VALUES (
            filas, Nom, Ape, pDni, Fec, Gen, Cel, Dom
        );
        SET rta = filas;
    ELSE
        SET rta = 1;
    END IF;
END //

DELIMITER ;
