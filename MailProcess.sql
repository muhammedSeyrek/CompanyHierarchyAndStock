Create Table Email(
	MailId int Identity(1, 1) Primary Key,
	Mail varchar(50),
	SenderId int, 
	SentPersonId int,
	MailText varchar(Max),
	SendDate DATETIME,
	Foreign Key (SenderId) References Emp(EMPNO),
	Foreign Key (SentPersonId) References Emp(EMPNO)
); 

UPDATE Email
SET Mail = Emp.Mail
FROM Email
JOIN Emp ON Email.SenderID = Emp.EmpNo OR Email.SentPersonId = Emp.EmpNo;

Insert into Email(Mail) Select Distinct e1.Mail from EMP e1, EMP e2 where e1.EMPNO >= e2.EMPNO

Select * from Email

ALTER TABLE Emp
DROP CONSTRAINT CK_Mail;

ALTER TABLE Emp
DROP COLUMN Mail;

ALTER TABLE Emp
ADD MailId INT;

ALTER TABLE Emp
ADD FOREIGN KEY (MailId) REFERENCES Email(MailId);


UPDATE Emp
SET MailId = Email.SenderId
FROM Emp
JOIN Email ON SUBSTRING(Email.SenderId, 1, CHARINDEX('@', Email.SenderId) - 1) = Emp.ENAME;

UPDATE Emp
SET MailId = Email.SenderID
FROM Emp
JOIN Email ON SUBSTRING(Email.Mail, 1, CHARINDEX('@', Email.Mail) - 1) = Emp.ENAME;

UPDATE Emp
SET MailId = Email.MailId
FROM Emp
JOIN Email ON SUBSTRING(Email.Mail, 1, CHARINDEX('@', Email.Mail) - 1) = Emp.ENAME;

SELECT @@ROWCOUNT AS 'Etkilenen Satır Sayısı';


Select SUBSTRING(Email.Mail, 1, CHARINDEX('@', Email.Mail) - 1) from EMP, Email Where
SUBSTRING(Email.Mail, 1, CHARINDEX('@', Email.Mail) - 1) = EMP.ENAME

SELECT * FROM Emp

Update Email 
Set SenderId = Emp.EMPNO from Email JOIN Emp ON Emp.MailId = Email.MailId;

Select * from Email














