CREATE PROCEDURE queryTicketByName
	@eventName varchar(50)
	AS
	SELECT EventName, EventType, EventDate, EventLocation, Price
	FROM Ticket
	WHERE EventName = @eventName AND Sold = 0;