CREATE PROCEDURE dbo.FillStartDate
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDate DATETIME = GETDATE();

    UPDATE Person
    SET StartDate = @CurrentDate
    WHERE StartDate IS NULL;
END;

EXEC dbo.FillStartDate;