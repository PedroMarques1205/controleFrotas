CREATE DATABASE DB_SAE_FROTAS;
GO

USE DB_SAE_FROTAS;
GO

CREATE TABLE Veiculo(
	placa varchar(20) PRIMARY KEY,
	marca varchar(40),
	modelo varchar(40),
	ano int,
	familia varchar(30),
	isProprietarioSae bit,
	inicioVigencia date,
	fimVigencia date,
	numContrato int,
	numOrdemCompra int,
	valorLocacao float,
	valorOrdemCompra float,
	saldoOrdemCompra float,
	saldoOcProxMes float,
	proprietario varchar(40),
	observacao varchar(2000)
);

CREATE TABLE Motorista(
	cpf varchar(15) PRIMARY KEY,
	nome varchar (100) NOT NULL,
	carteiraPossuida varchar NOT NULL,
	validadeCarteira date
);

CREATE TABLE TipoVeiculo(
	nomeTipo varchar(200) PRIMARY KEY,
	numRodas int,
	capacidadePassageiros int,
	carteiraNecessaria varchar NOT NULL,
);

INSERT INTO TipoVeiculo(nomeTipo,numRodas,capacidadePassageiros,carteiraNecessaria)VALUES('Automotores',4,5,'B');

CREATE TABLE LancamentoDiario(
	idTipoAtividade int NOT NULL,
	placa varchar(20) NOT NULL,
	motorista varchar(40),
	data date,
	horarioChegada time,
	horarioSaida time,
	kmRodados float,
	nomeAtividade varchar(40),
	isResponsabilidadeSae bit,
	descontoDiarias float,
	valorManutencao float NOT NULL,
	litrosOleoUsado float,
	valorLitro float,
	valorTotalLitro float,
	valorDiaria float,
	PRIMARY KEY(data,placa,idTipoAtividade),
	FOREIGN KEY (placa) REFERENCES Veiculo(placa)
);


SELECT SUM(valorLitro),SUM(valorTotalLitro),SUM(valorDiaria),SUM(valorManutencao),SUM(descontoDiarias),placa
FROM LancamentoDiario
GROUP BY placa