CREATE PROCEDURE insertBuyer
	@firstName varchar (50),
	@lastName varchar (50)
AS
	INSERT INTO Buyer 
	(FirstName, LastName)
	VALUES (@firstName, @lastName)