use master
drop database aula02
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
	id_cliente int, --FK
	data date,
	vlrtotal money,
	desconto float,
	vlrpago money
	)
go
create table tb_vendas_itens(
	id_item int NOT NULL PRIMARY KEY IDENTITY (1,1),
	id_venda int, --FK
	id_hardware int, --FK
	total_item money
	)
go

alter table tb_vendas add constraint fk_tb_clientes foreign key (id_cliente) references tb_clientes (id_cliente)
go
alter table tb_vendas_itens add constraint fk_tb_hardware foreign key (id_hardware) references tb_hardware (id_hardware)
go
alter table tb_vendas_itens add constraint fk_tb_venda foreign key (id_venda) references tb_vendas (id_venda)
go