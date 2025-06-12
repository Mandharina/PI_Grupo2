DELIMITER //
create procedure VerificarDni(
    IN p_dni INT,
    OUT existe BOOLEAN,
    OUT es_socio BOOLEAN,
    OUT numero_identificador INT
)
BEGIN
    -- Verificar si es socio
    IF EXISTS (SELECT 1 FROM socio WHERE Dni = p_dni) THEN
        SET existe = TRUE;
        SET es_socio = TRUE;
        SELECT NroCarnet INTO numero_identificador
        FROM socio
        WHERE Dni = p_dni
        LIMIT 1;

    -- Si no es socio, verificar si es no socio
    ELSEIF EXISTS (SELECT 1 FROM noSocio WHERE Dni = p_dni) THEN
        SET existe = TRUE;
        SET es_socio = FALSE;
        SELECT NroNoSocio INTO numero_identificador
        FROM noSocio
        WHERE Dni = p_dni
        LIMIT 1;

    -- Si no se encuentra en ninguna
    ELSE
        SET existe = FALSE;
        SET es_socio = FALSE;
        SET numero_identificador = NULL;
    END IF;
END;
//
DELIMITER ;
