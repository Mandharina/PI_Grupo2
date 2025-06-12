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
(10001, 'Lucia', 'Pérez', 12345678, '1990-05-12', 'Femenino', '1123456789', 'Av. Siempre Viva 123', '2024-01-15', '2025-01-15'),
(10002, 'Juan', 'Gómez', 27654321, '1985-09-23', 'Masculino', '1198765432', 'Calle Falsa 456', '2023-11-10', '2024-11-10'),
(10003, 'Ana', 'Lopez', 23456789, '1992-03-08', 'Femenino', '1134567890', 'Pasaje 3 de Febrero', '2024-03-01', '2025-03-01'),
(10004, 'Pedro', 'Ramirez', 34567891, '1978-12-30', 'Masculino', '1145678901', 'Barrio Centro', '2022-06-20', '2023-06-20'),
(10005, 'Camila', 'Fernandez', 45678902, '2000-07-14', 'Femenino', '1156789012', 'Zona Norte', '2024-08-01', '2025-08-01');

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
(10001, '2025-01-15', '2024-12-15', 5000, 'Efectivo', 1),
(10002, '2024-11-10', '2024-09-10', 14000, 'Tarjeta', 3),
(10003,'2025-03-01', '2025-02-01', 5000, 'Tarjeta', 1),
(10004, '2023-06-20', '2022-06-20', 50000, 'Efectivo', 1),
(10005, '2025-08-01', '2025-07-01', 5000, 'Tarjeta', 1);

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
(1, 1, 2000, '2024-05-01'), 
(2, 2, 2500, '2024-05-02'),  
(3, 3, 2200, '2024-05-03'),
(4, 5, 2700, '2024-05-04'), 
(5, 4, 2300, '2024-05-05');  


