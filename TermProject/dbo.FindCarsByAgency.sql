CREATE PROCEDURE FindCarsByAgency
	@City varchar(50),
	@State varchar(50),
	@AgencyID int,
	@FourDoor bit,
	@Automatic bit,
	@SUV bit,
	@30MPG bit
AS
	SELECT CarID, CarName, City, State, AgencyID, AgencyName FROM Car
	WHERE City = @City AND State = @State AND AgencyID = @AgencyID AND FourDoors = @FourDoor AND Automatic = @Automatic AND SUV = @SUV AND [30MPGInCity] = @30MPG