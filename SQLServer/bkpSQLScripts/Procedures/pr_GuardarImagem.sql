USE [EstoqueProdutos]
GO

DROP PROCEDURE [dbo].[pr_GuardarImagem]
GO

CREATE PROCEDURE [dbo].[pr_GuardarImagem]
	@Descricao VARCHAR(30) null,
	@Imagem VARBINARY(MAX)

AS
BEGIN
	
	--IF @Imagem IS NULL
 --   BEGIN
 --       RAISERROR ('A imagem � obrigat�ria.', 16, 1)
 --       RETURN
 --   END

	IF LEN(@Descricao) > 30
	BEGIN
        RAISERROR ('A descri��o deve ter no m�ximo 30 caracteres.', 16, 1)
        RETURN
    END


	IF @Imagem Is not null
	BEGIN
		INSERT INTO tblImagens (Descricao, IMAGEM)
		VALUES (@Descricao, @Imagem)
	END

END
GO


