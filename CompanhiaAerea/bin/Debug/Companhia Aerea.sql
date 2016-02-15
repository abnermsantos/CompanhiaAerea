create table piloto(
	cht int,
	nome varchar(50),
	datanasc date,
	primary key(cht));

create table aviao(
	numeroserie int,
	modelo varchar(20),
	primary key(numeroserie));

create table cliente(
	cpf varchar(11),
	nome varchar(50),
	cidade varchar(30),
	primary key(cpf));

create table assento(
	codigo int,
	tipo varchar(20),
	cpf_cliente varchar(11),
	numeroserie int,
	primary key(codigo),
	foreign key(numeroserie) references aviao,
	foreign key(cpf_cliente) references cliente);
	
create table aeroporto(
	codigo int,
	nome varchar(30),
	cidade varchar(30),
	primary key(codigo));

create table voo(
	codigo int,
	cod_aeroporto int,
	data date,
	origem varchar(30),
	destino varchar(30),
	primary key(codigo),
	foreign key(cod_aeroporto) references aeroporto);

create table pilota(
	numeroserie int,
	cht int,
	primary key(numeroserie, cht),
	foreign key(numeroserie) references aviao,
	foreign key(cht) references piloto);