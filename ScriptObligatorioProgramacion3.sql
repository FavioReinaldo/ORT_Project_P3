-- ********************* Borrar base si existe y crear nueva *********************

USE master;
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name='ObligaotrioProgramacion3')
	DROP DATABASE ObligaotrioProgramacion3
GO

CREATE DATABASE ObligaotrioProgramacion3;
GO

USE ObligaotrioProgramacion3;
GO


-- ********************* Creacion de tablas *********************

CREATE TABLE Usuario (
	mail VARCHAR(200) NOT NULL,
	password VARCHAR(200) NOT NULL,	
	
	PRIMARY KEY (mail)	
);
GO

Create table dbo.Tipo(
			Nombre varchar(50) not null,
			Descripcion varchar(200));
GO

-- ********************* Inserts de Datos *********************



-- Usuario 

INSERT INTO Usuario (mail, password)
	VALUES 	

		('Usuario1@mail.com', 'Usuario1'),
		('Usuario2@mail.com', 'Usuario2'),
		('Usuario3@mail.com', 'Usuario3');
		
insert into dbo.Tipo values('Hierbas','Es una planta que no presenta órganos decididamente leñosos. Los tallos de las hierbas son verdes y generalmente mueren al acabar la buena estación, siendo luego reemplazados por otros nuevos.'),
			('Matas','La mata es un subarbusto o arbusto enano que se distingue del arbusto por la disposición de las ramas a ras del suelo, y por tener menor altura (no suelen superar los 20 cm).'),
			('Arbustos','Llamamos arbusto a una planta leñosa que, a diferencia del árbol, no se eleva sobre un solo tronco o fuste, sino que se ramifica desde la misma base.'),
			('Arbol','Los árboles son plantas con tallo leñoso que se ramifica a cierta altura del suelo. ');


		
