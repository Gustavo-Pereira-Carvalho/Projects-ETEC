create database exercicio;
use exercicio

create table contato(
codigo int identity(1,1) primary key not null,
nome varchar(50)  not null,
email varchar(100) unique,
ativo bit not null
);

create table telefone(
idcodigo int identity(1,1) primary key not null,
codcontato int not null unique constraint fk references contato,
tipoTelefone varchar(15) not null,
telefone varchar(15) not null,
ramal varchar(4)
);

create table endereco(
idcodigo int identity(1,1) primary key not null,
codcontato int not null unique constraint fk1 references contato,
endereco varchar(80) not null,
numero int not null,
complemento varchar(30),
bairro varchar(30),
cidade varchar(30),
estado char,
cep varchar(9)
);

select * from contato
select * from telefone
select * from endereco