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

-- ********************* Inserts de Datos *********************



-- Usuario 

INSERT INTO Usuario (mail, password)
	VALUES 	

		('Usuario1@mail.com', 'Usuario1'),
		('Usuario2@mail.com', 'Usuario2'),
		('Usuario3@mail.com', 'Usuario3');
		