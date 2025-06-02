delimiter //

create procedure RegistrarNoSocio(
    in p_nombre varchar(50),
    in p_apellido varchar(50),
    in p_dni int,
    in p_fechaNac date,
    in p_genero varchar(10),
    in p_numCel varchar(12),
    in p_domicilio varchar(100),
    in p_aptoFisico boolean,
    out p_nroNoSocio int
)
begin
    insert into noSocio (
        Nombre, Apellido, Dni, FechaNac, Genero, NumCel, Domicilio, AptoFisico
    )
    values (
        p_nombre, p_apellido, p_dni, p_fechaNac, p_genero, p_numCel, p_domicilio, p_aptoFisico
    );

    set p_nroNoSocio = LAST_INSERT_ID();
end //

delimiter ;