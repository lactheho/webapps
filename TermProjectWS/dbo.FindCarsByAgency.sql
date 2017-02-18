CREATE PROCEDURE FindCarsByAgency
	@Agency varbinary(50),
	@Requirements varbinary(50),
	@City varchar(50),
	@State varchar(50)
AS
SELECT CarID FROM Car
	WHERE AgencyID = @Agency AND Requirements = @Requirements AND City = @City AND State = @State