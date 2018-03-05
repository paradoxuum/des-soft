--use master
--drop database aula02
create database aula02
go
use aula02
go
create table tb_clientes (
	id_cliente int NOT NULL PRIMARY KEY IDENTITY (1,1), 
	nome nvarchar(100), 
	endereco nvarchar(500),
	fone nvarchar (30),
	email nvarchar (255)
	)
go
create table tb_hardware (
	id_hardware int NOT NULL PRIMARY KEY IDENTITY (1,1),
	descricao nvarchar(500),
	preco money,
	qtde int,
	qtde_min int
	)
go
create table tb_vendas(
	id_venda int NOT NULL PRIMARY KEY IDENTITY (1,1),
	id_cliente nvarchar(500),
	data date,
	vlrtotal money,
	desconto float,
	vlrpago money
	)
go
create table tb_vendas_itens(
	id_item int NOT NULL PRIMARY KEY IDENTITY (1,1),
	id_venda int,
	id_hardware int,
	total_item money
	)
go
