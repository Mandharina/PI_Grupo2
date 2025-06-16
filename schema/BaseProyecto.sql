drop database if exists Proyecto;
create database Proyecto;
use Proyecto;

create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'Admin','Admin123',120);


create table socio(
NroCarnet int auto_increment,
Nombre varchar (20),
Apellido varchar (20),
Dni int,
FechaNac date,
Genero varchar (20),
NumCel varchar(12),
Domicilio varchar (50),
AptoFisico bool default true,
FechaIngreso date,
VencCuota date,
EsActivo bool default true,
CarnetEntregado bool default true,
constraint pk_carnet primary key (NroCarnet)
);

insert into socio(NroCarnet, Nombre, Apellido, Dni, FechaNac, Genero, NumCel, Domicilio, FechaIngreso, VencCuota) values
(10001, 'Lucia', 'Pérez', 12345678, '1990-05-12', 'Femenino', '1123456789', 'Av. Siempre Viva 123', '2025-04-01', '2025-06-01'),
(10002, 'Juan', 'Gómez', 27654321, '1985-09-23', 'Masculino', '1198765432', 'Calle Falsa 456', '2025-05-15', '2025-06-15'),
(10003, 'Ana', 'Lopez', 23456789, '1992-03-08', 'Femenino', '1134567890', 'Pasaje 3 de Febrero', '2025-05-20', '2025-06-20'),
(10004, 'Pedro', 'Ramirez', 34567891, '1978-12-30', 'Masculino', '1145678901', 'Barrio Centro', '2022-05-20', '2023-06-20'),
(10005, 'Camila', 'Fernandez', 45678902, '2000-07-14', 'Femenino', '1156789012', 'Zona Norte', '2024-06-01', '2025-07-01');


create table cuota(
NroCuota int auto_increment,
NroSocio int,
FechaVencimiento date,
FechaPago date,
Importe double,
MetodoPago varchar (30),
CantCuotas int,
constraint pk_nroCuota primary key(NroCuota),
constraint fk_socio foreign key (NroSocio) references socio(NroCarnet)
);

insert into cuota (NroSocio, FechaVencimiento, FechaPago, Importe, MetodoPago, CantCuotas) values
(10001, '2025-05-01', '2025-05-12', 15000, 'Efectivo', 1),
(10002, '2025-06-01', '2025-06-14', 15000, 'Tarjeta', 3),
(10003,'2025-06-20', '2025-06-15', 15000, 'Tarjeta', 1),
(10004, '2025-06-20', '2025-06-16', 150000, 'Efectivo', 1),
(10001, '2025-06-01', '2025-06-12', 15000, 'Efectivo', 1);

create table actividad(
NroActividad int auto_increment,
Nombre varchar (40),
Descripcion varchar(200),
Costo double,
Dia varchar(20),
Horario varchar(5),
Cupos int,
constraint pk_actividad primary key(NroActividad)
);

insert into actividad (Nombre, Descripcion, Costo, Dia, Horario, Cupos) values
('Yoga para Principiantes', 'Clase suave de yoga para todos los niveles', 2000, 'Lunes', '08:00', 20),
('Entrenamiento Funcional', 'Sesión intensa para mejorar fuerza y resistencia', 2500, 'Martes', '18:30', 15),
('Zumba', 'Clase de baile con música latina para quemar calorías', 2200, 'Miércoles', '19:00', 25),
('Pilates', 'Ejercicios de bajo impacto para fortalecer el core', 2300, 'Jueves', '09:00', 10),
('Boxeo Recreativo', 'Técnicas básicas de boxeo sin contacto', 2700, 'Viernes', '17:00', 12);

create table noSocio(
NroNoSocio int auto_increment,
Nombre varchar (20),
Apellido varchar (20),
Dni int,
FechaNac date,
Genero varchar (20),
NumCel varchar(12),
Domicilio varchar (50),
AptoFisico bool default true,
constraint pk_noSocio primary key (NroNoSocio)
);

insert into noSocio (Nombre, Apellido, Dni, FechaNac, Genero, NumCel, Domicilio) values
('Juana', 'Pérez', 12345679, '1990-05-12', 'Femenino', '1123456759', 'Av. Siempre Viva 123'),
('Mario', 'Gómez', 17654321, '1985-09-23', 'Masculino', '1198765422', 'Calle Falsa 456'),
('Analia', 'Lopez', 23456789, '1992-03-08', 'Femenino', '1134567840', 'Pasaje 3 de Febrero 789'),
('Patricio', 'Ramirez', 24567890, '1978-12-30', 'Masculino', '1145676901', 'Barrio Centro 12'),
('Jimena', 'Fernandez', 35678901, '2000-07-14', 'Femenino', '1156729012', 'Zona Norte 334');

create table pagoActividad(
NroPago int auto_increment,
NoSocio int,
Actividad int,
Monto double,
FechaPago date,
constraint pk_pago primary key (NroPago),
constraint fk_noSocio foreign key (NoSocio) references noSocio(NroNoSocio),
constraint fk_actividad foreign key (Actividad) references actividad(NroActividad)
);

insert into pagoActividad (NoSocio, Actividad, Monto, FechaPago) values
(1, 1, 2000, '2025-06-15'), 
(2, 2, 2500, '2025-06-15'),  
(3, 3, 2200, '2025-06-17'),
(4, 5, 2700, '2025-06-18'), 
(5, 4, 2300, '2025-06-19');  

/* PROCEDURES 
*************************************************   */


/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end 
//

/* ==========================
si queremos probar el procedure se usa call
====================================================== */

call IngresoLogin('dato1', 'dato2')//

/* ===============================
si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */

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


delimiter //

create procedure RegistrarCuota(
    in p_NroSocio int,
    in p_FechaVencimiento date,
    in p_FechaPago date,
    in p_Importe double,
    in p_MetodoPago varchar(30),
    in p_CantCuotas int
)
begin
    insert into cuota (
        NroSocio, FechaVencimiento, FechaPago, Importe, MetodoPago, CantCuotas
    ) values (
        p_NroSocio, p_FechaVencimiento, p_FechaPago, p_Importe, p_MetodoPago, p_CantCuotas
    );
    select last_insert_id() as nroCuota;
end //

delimiter ;
