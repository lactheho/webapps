CREATE PROCEDURE checkCustomer
	@CustomerID varchar(50),
	@Password varchar(50) OUTPUT
AS
	SELECT Password
	FROM Customer
	WHERE CustomerID = @CustomerID
