--Validar el nivel de aislamiento en nuestrar bases de datos
SELECT name, snapshot_isolation_state, is_read_committed_snapshot_on FROM sys.databases;

--Cambiamos el nivel de aislamiento según sea el caso
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;  
GO  
BEGIN TRANSACTION;  
GO  
SELECT *   
    FROM Warehouse.StockItemTransactions  
GO  
SELECT *   
    FROM Warehouse.StockItems;  
GO  
COMMIT TRANSACTION;  
GO 

--Niveles de aislamiento
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
SET TRANSACTION ISOLATION LEVEL SNAPSHOT
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE



--Cambiar el nivel de aislamiento
ALTER DATABASE WideWorldImporters  
SET ALLOW_SNAPSHOT_ISOLATION ON

ALTER DATABASE WideWorldImporters  
SET ALLOW_SNAPSHOT_ISOLATION OFF

--Cambiar el nivel de aislamiento
ALTER DATABASE WideWorldImporters  
SET READ_COMMITTED_SNAPSHOT ON

ALTER DATABASE WideWorldImporters  
SET READ_COMMITTED_SNAPSHOT OFF 

