delimiter //

create procedure RegistrarCuota(
    in p_NroSocio int,
    in p_FechaVencimiento date,
    in p_FechaPago date,
    in p_Importe double,
    in p_MetodoPago varchar(30),
    in p_CantCuotas varchar(1)
)
begin
    insert into cuota (
        NroSocio, FechaVencimiento, FechaPago, Importe, MetodoPago, CantCuotas
    ) values (
        p_NroSocio, p_FechaVencimiento, p_FechaPago, p_Importe, p_MetodoPago, p_CantCuotas
    );
    select LAST_INSERT_ID() as nroCuota
end //

delimiter ;