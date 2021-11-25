CREATE DATABASE instituto;
go
USE instituto;
go

CREATE TABLE alumnos(
id int primary key,
nombre varchar(30) not null,
apellido varchar(30) not null);

CREATE TABLE materias(
id int primary key,
nombre varchar(30) not null);