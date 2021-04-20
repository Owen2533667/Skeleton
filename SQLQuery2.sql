USE [p2533667]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrderProcessing_FilterByOrderNo]
		@OrderNo = 1

SELECT	@return_value as 'Return Value'

GO
