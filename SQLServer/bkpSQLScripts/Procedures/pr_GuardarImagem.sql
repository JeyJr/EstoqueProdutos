USE [EstoqueProdutos]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 07/07/2023 19:03:23 ******/
DROP PROCEDURE [dbo].[pr_GuardarImagem]
GO

/****** Object:  StoredProcedure [dbo].[pr_GuardarImagem]    Script Date: 07/07/2023 19:03:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[pr_GuardarImagem]
	@Nome VARCHAR(30) null,
	@Formato VARCHAR(5) null,
	@Imagem VARBINARY(MAX)

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


