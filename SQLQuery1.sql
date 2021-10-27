USE MASTER

GO

CREATE DATABASE ProvaConceitoDB

GO

USE ProvaConceitoDB

GO

CREATE TABLE dbo.cliente (
	Id uniqueidentifier default newid() not null primary key,
	Nome varchar(100) not null,
	Endereco varchar(100) not null
)

GO

INSERT INTO dbo.cliente(Nome, Endereco)
values
('Joir Neto','Rua dos Curios, 371, Caoçu, Eusebio-CE'),
('Pamela Luara','Rua C, 288, Luciano Cavalcante, Fortaleza-CE'),
('Evaldo da Silva','Rua Rev Bolicar Pinto Bandeira, 5900, Fortaliza-Ce')

GO

SELECT * from cliente