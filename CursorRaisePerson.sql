CREATE PROCEDURE GetARaise
    @altSinirMiktar DECIMAL(10, 2)
AS
BEGIN
    DECLARE zamCursor CURSOR FOR
    SELECT PersonId, Salary
    FROM Person
    WHERE Salary < @altSinirMiktar;

    DECLARE @personId INT, @currentSalary DECIMAL(10, 2), @newSalary DECIMAL(10, 2);

    OPEN zamCursor;

    FETCH NEXT FROM zamCursor INTO @personId, @currentSalary;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @newSalary = @currentSalary + (@currentSalary * 0.10);

        UPDATE Person
        SET Salary = @newSalary
        WHERE PersonId = @personId;

        FETCH NEXT FROM zamCursor INTO @personId, @currentSalary;
    END

    CLOSE zamCursor;
    DEALLOCATE zamCursor;
END