

INSERT INTO Fornecedor (Nome, CNPJ, Endereco, Bairro, UF)
VALUES
   ('Distribuidora Brasil Verde', '12345678000123', 'Av. Paulista, 123', 'Bela Vista', 'SP'),
   ('Supermercado Tropical', '98765432000110', 'Rua das Flores, 456', 'Centro', 'RJ'),
   ('Hortifruti Sabor Natural', '87654321000199', 'Rua do Mercado, 789', 'Vila Nova', 'MG'),
   ('Atacad�o dos Gr�os', '54321678000187', 'Av. das Ind�strias, 321', 'Distrito Industrial', 'RS'),
   ('Mercado do Interior', '23876541000122', 'Rua do Mercado, 987', 'Bairro Novo', 'PR'),
   ('Distribuidora Flor do Cerrado', '65432789000154', 'Av. dos Ip�s, 741', 'Jardim das Flores', 'GO'),
   ('Supermercado Estrela do Norte', '34218534000111', 'Av. da Liberdade, 852', 'Vila Esperan�a', 'BA'),
   ('Sacol�o Frutas Frescas', '71456123000112', 'Rua das Mangueiras, 951', 'Centro', 'PE'),
   ('Distribuidora Hortali�as do Vale', '18329742000115', 'Av. das Palmeiras, 654', 'Vale Encantado', 'SC'),
   ('Mercado do Campo', '92731643000120', 'Rua das Oliveiras, 159', 'Campo Grande', 'MS');

INSERT INTO Categoria (Nome)
VALUES
   ('Nenhum'),
   ('Limpeza'),
   ('Alimentos'),
   ('Eletr�nicos'),
   ('Moda'),
   ('Cosm�ticos'),
   ('M�veis'),
   ('Automotivo'),
   ('Brinquedos'),
   ('Esportes'),
   ('Livros');

INSERT INTO TipoEmbalagem (Nome)
VALUES
('Nenhum'),
   ('Caixa'),
   ('Garrafa'),
   ('Lata'),
   ('Pote'),
   ('Saco'),
   ('Tubo'),
   ('Envelope'),
   ('Bisnaga'),
   ('Spray'),
   ('Bandeja');

INSERT INTO UnidadeMedida (Sigla, Extenso)
VALUES
('n','Nenhum'),
   ('kg', 'Quilograma'),
   ('g', 'Grama'),
   ('L', 'Litro'),
   ('ml', 'Mililitro'),
   ('m', 'Metro'),
   ('cm', 'Cent�metro'),
   ('mm', 'Mil�metro'),
   ('un', 'Unidade'),
   ('dz', 'D�zia'),
   ('p�', 'Pe�a');

INSERT INTO Operadores(Sigla, Extenso)
VALUES
   ('n', 'Nenhum'),
   ('=', 'Igual'),
   ('<', 'Menor que'),
   ('>', 'Maior que'),
   ('<>', 'Diferente de'),
   ('>=', 'Maior ou igual que'),
   ('<=', 'Menor ou igual que')
   
INSERT INTO OperadoresEspeciais (Sigla, Extenso)
VALUES
   ('n', 'Nenhum'),
   ('IS NULL', '� nulo'),
   ('IS NOT NULL', 'N�o � nulo'),
   ('BETWEEN', 'Entre '),
   ('NOT BETWEEN', 'Fora do intervalo'),
   ('IN', 'Est� em uma lista'),
   ('NOT IN', 'N�o est� em uma lista'),
   ('LIKE', 'Corresponde a um padr�o'),
   ('NOT LIKE', 'N�o corresponde a um padr�o');


INSERT INTO Imagem (Imagem) 
SELECT BulkColumn
FROM OPENROWSET(BULK 'C:...standard.png', SINGLE_BLOB) AS Imagem;


UPDATE Imagem
SET Nome = 'STANDARD'
WHERE PK_Imagem = 100 



INSERT INTO Produto
VALUES
	('Produto Exemplo 1', 11.11, 22.22, 'Descri��o do Produto 1', 101, 102, 103, 104, 100),
	('Produto Exemplo 2', 33.33, 44.44, 'Descri��o do Produto 2', 104, 103, 102, 101, 100),
	('Produto Exemplo 3', 55.55, 66.66, 'Descri��o do Produto 3', 105, 105, 105, 105, 100)