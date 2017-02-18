CREATE PROCEDURE buyTicket
	@userName varchar (50),
	@eventName varchar (50)

AS
	UPDATE Ticket
	SET SoldTo = @userName, Sold = 1
	WHERE EventName = @eventName