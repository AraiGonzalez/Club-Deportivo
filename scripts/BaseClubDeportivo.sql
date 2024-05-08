drop database if exists ClubDeportivo;
create database ClubDeportivo;
use ClubDeportivo;

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

create table Inscripcion (
    IdInscripcion int,
    Nombre varchar(30),
    Apellido varchar(40),
    DNI int,
    Aptitud bool,
    constraint pk_Inscripcion primary key(IdInscripcion)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(27,'Omega7','123456',120),
(28,'Omeguitas','123456',121);

create table Socio (
	IdSocio int,
    IdInscripcion int,
    constraint pk_Socio primary key(IdSocio),
    constraint fk_Socio foreign key(IdInscripcion) references Inscripcion(IdInscripcion)
);

create table NoSocio (
	IdNoSocio int,
    IdInscripcion int,
    constraint pk_NoSocio primary key(IdNoSocio),
    constraint fk_NoSocio foreign key(IdInscripcion) references Inscripcion(IdInscripcion)
);

create table Pago (
	IdPago int,
    IdInscripcion int,
    FormaPago varchar(20),
	Plan varchar(20),
    Monto double,
    Cuotas int,
    Fecha varchar(10),
    constraint pk_Pago primary key(IdPago),
    constraint fk_Pago foreign key(IdInscripcion) references Inscripcion(IdInscripcion)
);

create table Carnet (
	IdCarnet int,
    IdSocio int,
    Vencimiento varchar(10),
    constraint pk_Carnet primary key(IdCarnet),
    constraint fk_Carnet foreign key(IdSocio) references Socio(IdSocio)
);


