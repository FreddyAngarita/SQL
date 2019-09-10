-- =============================================
-- Author:		<Juan Camilo Urrego Serna,,Freddy Angarita>
-- Description:	<SET NOCOUNT ON/OFF,,>
-- =============================================
CREATE PROCEDURE PrintTransactions 
	
AS
BEGIN
	

    -- Insert statements for procedure here
	SELECT * 
	FROM Warehouse.StockItemTransactions
END
GO

EXECUTE PrintTransactions

ALTER PROCEDURE dbo.PrintTransactions
	
AS
BEGIN
	
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT * 
	FROM Warehouse.StockItemTransactions
END
GO

EXECUTE PrintTransactions
