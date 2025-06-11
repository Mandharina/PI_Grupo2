DELIMITER //
create procedure VerificarDni(
    in p_dni int,
    out existe boolean,
	out es_socio boolean,
    out numero_identificador int
)
begin
    declare nroCarnet int;
    declare nroNoSocio int;

    select NroCarnet into nroCarnet
    from socio
    where Dni = p_dni
    limit 1;

    if nroCarnet is not null then
        set existe = true;
        set es_socio = true;
        set numero_identificador = nroCarnet;
    else
        select NroNoSocio into nroNoSocio
        from noSocio
        where Dni = p_dni
        limit 1;

        if nroNoSocio is not null then
            set existe = true;
            set es_socio = false;
            set numero_identificador = nroNoSocio;
        else
            set existe = false;
            set es_socio = false;
            set numero_identificador = null;
        end if;
    end if;
end;
//
DELIMITER ;

