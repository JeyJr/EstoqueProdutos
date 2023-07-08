USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_GuardarImagem]
GO


CREATE PROCEDURE [dbo].[pr_GuardarImagem]
	@Nome VARCHAR(30) null,
	@Formato VARCHAR(5) null,
	@Imagem VARBINARY(MAX) null

AS
BEGIN
	
	--IF @Imagem IS NULL
 --   BEGIN
 --       RAISERROR ('A imagem � obrigat�ria.', 16, 1)
 --       RETURN
 --   END

	IF LEN(@Nome) > 30
	BEGIN
        RAISERROR ('A descri��o deve ter no m�ximo 30 caracteres.', 16, 1)
        RETURN
    END

	IF LEN(@Formato) > 5
	BEGIN
        RAISERROR ('O formato deve ter no m�ximo 5 caracteres.', 16, 1)
        RETURN
    END

	IF @Imagem Is not null
		BEGIN
			INSERT INTO tblImagens (NOME, FORMATO, IMAGEM)
			VALUES (@Nome, @Formato, @Imagem)
		END
END
GO


