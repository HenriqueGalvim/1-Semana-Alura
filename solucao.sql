-- Missão Criar Tabela Clientes
CREATE TABLE Clientes(
	id SERIAL PRIMARY KEY,
	nome TEXT NOT NULL,
	email TEXT NOT NULL,
	dataNascimento DATE NOT NULL,
	cidade TEXT NOT NULL
);
-- Missão Criar Tabela Pedidos
CREATE TABLE Pedidos(
	id SERIAL PRIMARY KEY,
	dataPedido DATE NOT NULL,
	valorTotal DECIMAL NOT NULL,
	clientId INTEGER NOT NULL,
	FOREIGN KEY (clientId)
         REFERENCES Clientes (id)
);
-- Missão Inserir Dados no banco
--Clientes
INSERT INTO clientes(nome, email, datanascimento, cidade)
	VALUES ('Henrique', 'henrixe80@gmail.com', '2003-10-30', 'Itacoatiara');
	
INSERT INTO clientes(nome, email, datanascimento, cidade)
	VALUES ('Rafael', 'rafael@gmail.com', '1996-06-08', 'Itacoatiara');

INSERT INTO clientes(nome, email, datanascimento, cidade)
	VALUES ('Ivanilce', 'ivanilce@gmail.com', '1969-06-28', 'Itacoatiara');

INSERT INTO clientes(nome, email, datanascimento, cidade)
	VALUES ('Leo', 'leo@gmail.com', '1996-08-30', 'São Paulo');

--Pedidos
INSERT INTO pedidos(datapedido, valortotal, clientid)
	VALUES ('2024-08-19', 200, 1);

INSERT INTO pedidos(datapedido, valortotal, clientid)
	VALUES ('2024-08-18', 50, 2);

INSERT INTO pedidos(datapedido, valortotal, clientid)
	VALUES ('2024-08-17', 300, 3);

-- Verificando se foi inserido mesmo
select nome,email from clientes;

-- Missão Atualizar e Deletar Dados do Banco
UPDATE clientes
	SET email='henrixe@email.com'
	WHERE id = 1;
	
UPDATE pedidos
	SET valortotal=100
	WHERE id = 1;
	
select * from clientes;
select * from pedidos;

DELETE FROM pedidos
	WHERE id = 1;

select * from clientes;
select * from pedidos;

--Missão Filtrar com where
select * from clientes where cidade = 'Itacoatiara';
select * from pedidos where valorTotal >= 100;

--Missão Ordenar com o ORDER BY
select * from clientes ORDER BY nome;
select * from pedidos ORDER BY valorTotal DESC;

--Missão Junção de tabelas com os Join
select clientes.nome AS "Nome do Cliente", pedidos.valorTotal As "Valor Total" from clientes join pedidos ON pedidos.clientId = clientes.id ORDER BY pedidos.valorTotal DESC;
select clientes.nome AS "Nome do Cliente", pedidos.valorTotal As "Valor Total" from clientes left join pedidos ON pedidos.clientId = clientes.id ORDER BY pedidos.valorTotal;