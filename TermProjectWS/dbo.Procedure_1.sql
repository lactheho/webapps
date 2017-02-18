CREATE PROCEDURE Reserve
	@Agency varbinary(50),
	@Car varbinary(50),
	@Customer varbinary(50)
AS
	UPDATE Car
	SET Reserved = 1
	WHERE AgencyID = @Agency AND CarID = @Car AND Customer = @Customer

