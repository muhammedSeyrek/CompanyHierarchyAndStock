CREATE TRIGGER trg_AfterInsertPerson
ON Person
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Email (Mail, SenderId)
    SELECT
        p.Name + CAST(i.PersonId AS NVARCHAR) + '@gmail.com',
        i.PersonId
    FROM
        inserted i
        JOIN Person p ON i.PersonId = p.PersonId
    WHERE
        NOT EXISTS (
            SELECT 1
            FROM Email e
            WHERE e.SenderId = i.PersonId
        );
	UPDATE p
	SET p.MailId = e.MailId
	FROM Person p
	INNER JOIN Email e ON p.PersonId = e.SenderId;
	UPDATE Person
	SET Password = CAST(PersonId * 1000 AS NVARCHAR)
	WHERE Password IS NULL; 
END;