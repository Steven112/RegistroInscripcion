CREATE DATABASE EstudianteDb
GO 
USE EstudianteDb
GO

CREATE TABLE Estudiante
(
    EstudianteId int primary key identity,
	Matricula  varchar(9),
	Nombres varchar(30),
	Apellidos varchar(30),
	Cedula varchar(30),
	Telefono varchar(13),
	Celular varchar(13),
	Email varchar(40),
	FechaNacimiento date,
	Sexo varchar(15),
	Balance int
);


CREATE TABLE Inscripciones
(
   InscripcioId int primary key identity,
   Fecha date,
   EstudianteId int,
   Foreign key (EstudianteId) references Estudiante (EstudianteId),
   Comentario varchar(500),
   Monto int,
   Deposito int,
   Balance int, 
);





