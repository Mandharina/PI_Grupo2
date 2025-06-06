delimiter //

create procedure RegistrarSocio(
    in p_nombre varchar(20),
    in p_apellido varchar(20),
    in p_dni int,
    in p_fechaNac date,
    in p_genero varchar(20),
    in p_numCel varchar(12),
    in p_domicilio varchar(50),
    in p_aptoFisico boolean,
    in p_fechaIngreso date,
    in p_vencCuota date,
    out p_nroCarnet int
)
begin
    insert into socio (
        Nombre, Apellido, Dni, FechaNac, Genero, NumCel, Domicilio, AptoFisico,
        FechaIngreso, VencCuota, EsActivo, CarnetEntregado
    ) values (
        p_nombre, p_apellido, p_dni, p_fechaNac, p_genero, p_numCel, p_domicilio, p_aptoFisico,
        p_fechaIngreso, p_vencCuota, true, true
    );

    set p_nroCarnet = last_insert_id();
end //

delimiter ;
