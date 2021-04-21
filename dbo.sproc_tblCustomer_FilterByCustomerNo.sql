CREATE PROCEDURE sproc_tblCustomer_FilterByCustomerNo
	@CustomerNo int
AS
	SELECT * from tblCustomer where CustomerNo = @CustomerNo

RETURN 0
