CREATE PROCEDURE GetCarsByAgency
	@AgencyID varbinary(50),
	@City varchar(50),
	@State varchar(50)
AS
	SELECT CarID FROM Car
	WHERE AgencyID = @AgencyID AND City = @City AND State = @State