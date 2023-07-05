CREATE TABLE tblProduto (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   NOME VARCHAR(45),
   PRECO_UNITARIO DECIMAL(10, 2),
   FK_tblCategoria_ID INT,
   FK_tblFornecedor_ID INT,
   FK_tblTipoEmbalagem_ID INT,
   VOLUME DECIMAL(10, 2),
   FK_tblUnidadeMedida_ID INT,
   FK_Imagem_ID INT,
   DESCRICAO VARCHAR(100),
   FOREIGN KEY (FK_tblCategoria_ID) REFERENCES tblCategoria (PK_ID),
   FOREIGN KEY (FK_tblFornecedor_ID) REFERENCES tblFornecedor (PK_ID),
   FOREIGN KEY (FK_tblTipoEmbalagem_ID) REFERENCES tblTipoEmbalagem (PK_ID),
   FOREIGN KEY (FK_tblUnidadeMedida_ID) REFERENCES tblUnidadeMedida (PK_ID),
   FOREIGN KEY (FK_Imagem_ID) REFERENCES tblImagens (PK_ID)
);
CREATE TABLE tblFornecedor (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Nome VARCHAR(50),
   CNPJ VARCHAR(14),
   Endereco VARCHAR(100),
   Bairro VARCHAR(50),
   UF VARCHAR(2)
);
CREATE TABLE tblCategoria (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Categoria VARCHAR(50)
);

CREATE TABLE tblTipoEmbalagem (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Embalagem VARCHAR(40)
);

CREATE TABLE tblUnidadeMedida (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   Sigla VARCHAR(5),
   Extenso VARCHAR(20)
);

CREATE TABLE tblImagens (
   PK_ID INT IDENTITY(100, 1) PRIMARY KEY,
   IMAGEM VARBINARY
);




-- Inser��o de valores para tblFornecedor
INSERT INTO tblFornecedor (Nome, CNPJ, Endereco, Bairro, UF)
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


   -- Inser��o de valores para tblCategoria
INSERT INTO tblCategoria (Categoria)
VALUES
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


-- Inser��o de valores para tblTipoEmbalagem
INSERT INTO tblTipoEmbalagem (Embalagem)
VALUES
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


   -- Inser��o de valores para tblUnidadeMedida
INSERT INTO tblUnidadeMedida (Sigla, Extenso)
VALUES
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
