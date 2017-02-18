CREATE PROCEDURE checkBuyer
	@ID int,
	@userName varchar(50)
AS
	SELECT ID, UserName
	FROM Buyer
	WHERE Id = @ID AND UserName = @userName;

