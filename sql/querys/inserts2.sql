INSERT INTO Formato (Nome, Descricao)
VALUES 
    ('S�lido', 'Produtos com forma f�sica s�lida.'),
    ('L�quido', 'Produtos em estado l�quido.'),
    ('Gasoso', 'Produtos em estado gasoso.'),
    ('P�', 'Produtos em forma de p� fino.'),
    ('Gel', 'Produtos com textura de gel.'),
    ('Creme', 'Produtos com consist�ncia de creme.'),
    ('Aerossol', 'Produtos em formato de aerossol.'),
    ('Granulado', 'Produtos em forma de gr�nulos.'),
    ('Pastilha', 'Produtos em formato de pastilha.'),
    ('Espuma', 'Produtos com consist�ncia de espuma.');



INSERT INTO Imagem (Nome, Formato, ImgBinary) 
SELECT 'STANDARD', 'PNG', BulkColumn
FROM OPENROWSET(BULK 'C:\Users\jeyjr\OneDrive\Imagens\Capturas de tela\std.png', SINGLE_BLOB) AS Imagem;


INSERT INTO Categoria (Nome, Descricao)
VALUES
    ('Eletr�nicos', 'Produtos eletr�nicos e gadgets.'),
    ('Vestu�rio', 'Roupas e acess�rios de moda.'),
    ('Alimentos', 'Produtos aliment�cios e bebidas.'),
    ('Cuidados Pessoais', 'Produtos de cuidados pessoais e beleza.'),
    ('Casa e Decora��o', 'Produtos para decora��o e itens para casa.'),
    ('Esportes e Lazer', 'Artigos esportivos e produtos para lazer.'),
    ('Automotivo', 'Pe�as e acess�rios para autom�veis.'),
    ('Livros e Educa��o', 'Livros, materiais educacionais e papelaria.'),
    ('Brinquedos', 'Brinquedos e jogos para todas as idades.'),
    ('Sa�de e Bem-Estar', 'Produtos relacionados � sa�de e bem-estar.'),
    ('Limpeza', 'Produtos de limpeza e saneamento.'),
    ('Higiene', 'Produtos de higiene pessoal.'),
    ('Bebidas Alco�licas', 'Bebidas que cont�m �lcool.'),
    ('Bebidas N�o Alco�licas', 'Bebidas n�o alco�licas, como sucos e refrigerantes.'),
    ('Alimentos Perec�veis', 'Alimentos que t�m prazo de validade curto.'),
    ('Alimentos N�o Perec�veis', 'Alimentos de longa durabilidade.'),
    ('Alimentos Estrag�veis', 'Alimentos que podem estragar rapidamente ap�s abertos.'),
    ('Outros', 'Outras categorias n�o especificadas.');

INSERT INTO Marca (Nome, Descricao)
VALUES
    ('Dell', 'Produtos eletr�nicos da marca Dell.'),
    ('Apple', 'Produtos eletr�nicos da marca Apple.'),
    ('Samsung', 'Produtos eletr�nicos da marca Samsung.'),
    ('Yp�', 'Produtos de limpeza da marca Yp�.'),
    ('Veja', 'Produtos de limpeza da marca Veja.'),
    ('Omo', 'Produtos de limpeza da marca Omo.'),
    ('Ambev', 'Bebidas alco�licas da empresa Ambev.'),
    ('Diageo', 'Bebidas alco�licas da empresa Diageo.'),
    ('Pernod Ricard', 'Bebidas alco�licas da empresa Pernod Ricard.');


INSERT INTO Embalagem (Nome, Descricao)
VALUES
    ('Caixa', 'Embalagem em forma de caixa.'),
    ('Garrafa', 'Embalagem em forma de garrafa.'),
    ('Lata', 'Embalagem em forma de lata.'),
    ('Saco', 'Embalagem em forma de saco.'),
    ('Frasco', 'Embalagem em forma de frasco.'),
    ('Envelope', 'Embalagem em forma de envelope.'),
    ('Pote', 'Embalagem em forma de pote.'),
    ('Tubo', 'Embalagem em forma de tubo.'),
    ('Bandeja', 'Embalagem em forma de bandeja.'),
    ('Ampola', 'Embalagem em forma de ampola.'),
    ('Blister', 'Embalagem em formato blister.'),
    ('Pacote', 'Embalagem em formato de pacote.');


INSERT INTO UnidadeMedida (Sigla, Extenso)
VALUES
    ('g', 'Grama'),
    ('kg', 'Quilograma'),
    ('mg', 'Miligrama'),
    ('ml', 'Mililitro'),
    ('L', 'Litro'),
    ('cm', 'Cent�metro'),
    ('m', 'Metro'),
    ('mm', 'Mil�metro'),
    ('un', 'Unidade'),
    ('cx', 'Caixa'),
    ('p�', 'Pe�a'),
    ('dz', 'D�zia');

