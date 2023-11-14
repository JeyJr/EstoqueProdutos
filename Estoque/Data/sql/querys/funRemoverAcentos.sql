CREATE FUNCTION RemoveAcentos(@texto NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @resultado NVARCHAR(MAX);
    
    SET @resultado = @texto;
    
    -- Substitui caracteres acentuados por equivalentes n�o acentuados
    SET @resultado = REPLACE(@resultado, N'�', 'a');
    SET @resultado = REPLACE(@resultado, N'�', 'e');
    SET @resultado = REPLACE(@resultado, N'�', 'i');
    SET @resultado = REPLACE(@resultado, N'�', 'o');
    SET @resultado = REPLACE(@resultado, N'�', 'u');
    SET @resultado = REPLACE(@resultado, N'�', 'a');
    SET @resultado = REPLACE(@resultado, N'�', 'e');
    SET @resultado = REPLACE(@resultado, N'�', 'i');
    SET @resultado = REPLACE(@resultado, N'�', 'o');
    SET @resultado = REPLACE(@resultado, N'�', 'u');
    -- Adicione mais substitui��es conforme necess�rio
    
    RETURN @resultado;
END;
