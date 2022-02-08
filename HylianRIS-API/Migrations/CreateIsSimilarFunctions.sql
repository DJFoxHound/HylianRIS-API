CREATE FUNCTION [dbo].[SplitString](
	@s nvarchar(4000)
)
RETURNS TABLE
WITH SCHEMABINDING
AS
RETURN(
	SELECT TRIM(value) AS value FROM STRING_SPLIT(REPLACE(REPLACE(REPLACE(REPLACE(@s, '/', '-'),'&', '-'),'+', '-'),'\', '-'), '-', NULL)  
	WHERE RTRIM(value) <> ''
);
GO
CREATE FUNCTION [dbo].[IsSimilar](
    @s nvarchar(4000)
  , @t nvarchar(4000)
)
RETURNS BIT
AS
BEGIN
	
	IF (@s = 'fam' OR @s = 'fam.' OR @t = 'fam' OR @t = 'fam.')
		return 1

	IF (LEN(TRIM(@s)) > 0 AND LEN(TRIM(@t)) > 0)
	BEGIN
		RETURN (SELECT IIF (EXISTS(SELECT [sT].[value] FROM (SELECT [value] FROM [dbo].[SplitString](@s)) AS sT INNER JOIN (SELECT [value] FROM [dbo].[SplitString](@t)) AS tT ON (((LEN([sT].[value]) = 1 OR LEN([tT].[value]) = 1 OR SUBSTRING([sT].[value], 2, 1) IN ('.', ' ') OR SUBSTRING([tT].[value], 2, 1) IN ('.', ' ')) AND SUBSTRING([sT].[value], 1, 1) = SUBSTRING([tT].[value], 1, 1)) OR (NOT(SUBSTRING([sT].[value], 2, 1) IN ('.', ' ') OR SUBSTRING([tT].[value], 2, 1) IN ('.', ' ')) AND (SELECT [dbo].[Levenshtein]([sT].[value],[tT].[value], 5)) IS NOT NULL)) ), 1, 0))
	END
	RETURN 0
END
GO

