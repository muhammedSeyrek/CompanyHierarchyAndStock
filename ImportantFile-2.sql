Create Table Brand(
	BrandName varchar(30) Primary Key,
	OwnerName varchar(30),
	MailId int Foreign Key (MailId) References Email(MailId)
);

Drop Table Brand

Create Table Branch(
	BranchId int identity(1, 1)
	BranchName varchar(30)
);


Insert into Brand(BrandName, OwnerName, MailId) Values('MMS', (Select Ename from EMP Where Job = 'PRESIDENT'), 
(Select MailId from EMP Where Job = 'PRESIDENT'));

Delete from Brand Where BrandName = 'MMS'

Select * from EMP

Create Table Branch(
	BranchId int Identity(1, 1) Primary Key,
	BranchName varchar(30),
	EmpNo int Foreign Key (EmpNo) References Emp(EmpNo)
);

Create Table Supplier(
	SupplierName varchar(30),
	MailId int Foreign Key (MailId) References Email(MailId),
	BranchId int Foreign Key (BranchId) References Branch(BranchId)
);



Select * from Branch

Insert into Branch(BranchName, EmpNo) Values((Select d.LOC from emp e, DEPT d where d.DEPTNO = e.DEPTNO And ENAME = 'Jones'), 
(Select Empno from EMP Where ENAME = 'JONES'));
Insert into Branch(BranchName, EmpNo) Values((Select d.LOC from emp e, DEPT d where d.DEPTNO = e.DEPTNO And ENAME = 'BLAKE'),
(Select Empno from EMP Where ENAME = 'BLAKE'));
Insert into Branch(BranchName, EmpNo) Values((Select d.LOC from emp e, DEPT d where d.DEPTNO = e.DEPTNO And ENAME = 'CLARK'),
(Select Empno from EMP Where ENAME = 'CLARK'));

Drop Table Category;
Drop table Price;

Create Table Category(
	CategoryId int identity(1, 1) Primary Key,
	CategoryName varchar(30),
	Area char
);

Create Table Price(
	PriceId int identity(1, 1) Primary Key,
	PurchasePrice Money,
	SalesPrice Money
);

Create Table Product(
	ProductId int Primary Key identity(1000, 1), 
	ProductName varchar(50),
	CategoryId int Foreign Key (CategoryId) References Category(CategoryId),
	PriceId int Foreign Key (PriceId) References Price(PriceId)
);

Insert into Category(CategoryName, Area) Values('Nutrition', 'A');
Insert into Category(CategoryName, Area) Values('Cosmetic', 'B');
Insert into Category(CategoryName, Area) Values('Electronic', 'C');

Select p.PriceId from Product e, Price p Where e.PriceId = p.PriceId;

-- Tabloları doldurmak icin array gibi tablolar yapildi.
Create Table City(
	CityId int Identity(1, 1) Primary Key,
	City varchar(30)
);

Select * from Person
Select * from Collar
Select * from Branch
Select * from Supplier
Select * from Category
Select * from Brand
Select * from Price
Select * from Product
Select * from Email



SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'DUMMY';

IF OBJECT_ID('DUMMY', 'U') IS NOT NULL
BEGIN
    DROP TABLE DUMMY;
END

Drop Table DUMMY

Drop Table BONUS


Insert into Supplier(SupplierName, BranchId, CategoryId) 
Values('Lenovo', 4, (Select CategoryId from Category Where Area = 'C'));
Insert into Supplier(SupplierName, BranchId, CategoryId) 
Values('Apple', 5, (Select CategoryId from Category Where Area = 'C'));
Insert into Supplier(SupplierName, BranchId, CategoryId) 
Values('JBL', 6, (Select CategoryId from Category Where Area = 'C'));


Update Emp Set Job = 'Worker' Where Job = 'Clerk'
Update Emp Set Job = 'It Analyst' Where Job = 'Analyst'
Update Emp Set Job = 'Boss' Where Job = 'President'

Alter Table Email Add Seen Bit
 
Select * from Email

Create Table MailTexts(
	MailTextId int identity(1, 1) Primary Key,
	MailId int Foreign Key (MailId) References Email(MailId),
	MailText varchar(Max)
);

Drop Table MailTexts;

ALTER TABLE MailTexts
DROP Constraint MailId;

ALTER TABLE Email
ADD MailTextId INT FOREIGN KEY REFERENCES MailTexts(MailTextId);


Select * from Email

SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('MailTexts');


ALTER TABLE MailTexts
DROP CONSTRAINT FK__MailTexts__MailI__318258D2; 

ALTER TABLE MailTexts
DROP COLUMN MailTextsId;

-- Veritabanını bağlı olan kullanıcıları at
ALTER DATABASE EMP
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;

-- Veritabanının adını değiştir
ALTER DATABASE EMP
MODIFY NAME = MMS;

-- Veritabanını tekrar çoklu kullanıcı moduna al
ALTER DATABASE MMS
SET MULTI_USER;

EXEC sp_rename 'DEPT', 'Collar';

Exec sp_rename 'EMP', 'Person';

Select * from Person
Select * from SALGRADE

UPDATE Person SET DeptNo = 20 WHERE JOB = 'It Analyst';

Update Person Set JOB = 'Salesman' Where Job = 'SALESMAN';

Update Person Set JOB = 'Owner' Where Job = 'PRESIDENT';

Select * from Collar

Delete from Collar Where DEPTNo = 40

Update Collar Set DName = 'Yellow' Where DNAME = 'ACCOUNTING'
Update Collar Set DName = 'White' Where DNAME = 'RESEARCH'
Update Collar Set DName = 'Blue' Where DNAME = 'SALES'

Alter Table Collar Drop Column LOC

Drop Table SALGRADE

Alter Table Brand Add BrandLoc varchar(30) Default 'Ankara'



SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('Email');

ALTER TABLE Email
DROP CONSTRAINT FK__Email__MailTextI__32767D0B;

Drop Table MailTexts



SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('Email');

ALTER TABLE Person
ADD CONSTRAINT FK_Person_Email_MailId
FOREIGN KEY (MailId)
REFERENCES Email(MailId);


ALTER TABLE Email
DROP CONSTRAINT FK__Email__SentPerso__0B91BA14;

Select * from Email

--Person tablosu duzenlenecek sonra Inbox acilacak.s


Select * from Email

Create Table Inbox(
	InboxId int identity(1, 1) Primary Key,
	MailText varchar(Max),
	SendDate Date,
	Seen bit Default 0,
	MailId int Foreign Key (MailId) References Email(MailId)
);

Alter Table Inbox Add SentPersonId int Foreign Key References Person(PersonId);

Alter table Email Drop Column MailTextId

Select * from Inbox
Select * from Email

SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('Inbox');

ALTER TABLE Inbox
DROP CONSTRAINT FK__Inbox__IdInbox__6ABAD62E;

Alter table Inbox Drop Column IdInbox

Alter Table Email Add InboxId int Foreign Key References Inbox(InboxId);

SELECT name
FROM sys.tables;

Update Brand Set BrandLoc = 'Ankara'

Update Branch Set BranchName = 'Cankaya' Where BranchId = 4;
Update Branch Set BranchName = 'Yeni Mahalle' Where BranchId = 5;
Update Branch Set BranchName = 'Etimesgut' Where BranchId = 6;

Alter Table Person Add Work int default 0 not null

SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('Supplier');


ALTER TABLE Supplier
DROP CONSTRAINT FK__Supplier__MailId__74794A92;

Alter table Supplier Drop Column MailId


Alter Table Supplier Add InboxId int Foreign Key (InboxId) References Inbox(InboxId);

Insert into Email(Mail, SenderId) Values('Muhammed@gmail.com', (Select PersonId from Person Where PersonId = 1111));

Select * from Person
Select * from Collar
Select * from Branch
Select * from Supplier
Select * from Category
Select * from Brand
Select * from Price
Select * from Product
Select * from Email
Select * from Inbox

Insert into Inbox(MailText, SendDate, Seen, MailId, SentPersonId) 
Values('Hey Jude', GETDATE(), 0, (Select MailId from Email Where SenderId = 1111), 1111);

Insert into Inbox(MailText, SendDate, Seen, MailId, SentPersonId) 
Values('Dont let me down', GETDATE(), 0, (Select MailId from Email Where SenderId = 1111), 7698);

Insert into Inbox(MailText, SendDate, Seen, MailId, SentPersonId) 
Values('Dont let me down', GETDATE(), 0, (Select MailId from Email Where SenderId = 7788), 7839);

Insert into Inbox(MailText, SendDate, Seen, MailId, SentPersonId) 
Values('Hey Jude', GETDATE(), 0, (Select MailId from Email Where SenderId = 7900), 7844);

Insert into Inbox(MailText, SendDate, Seen, MailId, SentPersonId) 
Values('Merhabalar', GETDATE(), 0, (Select em.MailId from Email em, Person p Where p.PersonId = em.SenderId), 
(Select i.SentPersonId from Inbox i, Person p, Email em Where em.SenderId = p.PersonId and em.MailId = i.InboxId));

Select i.SentPersonId, p.Name from Inbox i, Person p, Email em Where em.SenderId = p.PersonId and em.MailId = i.InboxId;

Delete from Inbox Where InboxId = 9;

SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('Email');

ALTER TABLE Email
DROP CONSTRAINT FK__Email__InboxId__6BAEFA67;

Alter table Email Drop Column InboxId


Select * from Supplier

Alter Table Inbox Add SupplierName varchar(30)

Insert into Inbox(MailText, SendDate, Seen, MailId, SupplierName) 
Values('We need Laptop', GETDATE(), 0, (Select MailId from Email Where SenderId = 7900), 'Lenovo');


Select * from Branch
Select * from Person
Select * from Brand

Select * from Branch b, Person p Where p.Mgr = b.PersonId And b.BranchName = 'Etimesgut';
Select * from Branch b, Person p Where p.PersonId = b.PersonId
Select * from Person Where Mgr = (Select PersonId from Person Where Name = 'KING')

Select * from Supplier

SELECT
    OBJECT_NAME(object_id) AS ConstraintName,
    type_desc AS ConstraintType
FROM
    sys.objects
WHERE
    parent_object_id = OBJECT_ID('Supplier');

ALTER TABLE Supplier
DROP CONSTRAINT FK__Supplier__InboxI__178D7CA5;

Alter Table Supplier Drop Column InboxId

Select * from Person

Update Person Set Mgr = (Select PersonId from Person Where Name = 'Jones') Where PersonId = 1111;

Update Person Set Birthday = '2000-10-22' Where PersonId = 1111;

Update Person Set Job = 'Accounting' Where PersonId = 1111;

Update Person Set Comm = 1.0 Where PersonId = 1111;

Update Person Set Gender = 'M' Where PersonId = 1111;

Select * from Email

Declare @x int;
Select @x = e.MailId from Email e, Person p Where SenderId = 1111

Update Person Set MailId = @x;


Update Person Set MailId = Email.MailId from Email Where Person.PersonId = Email.SenderId

Select * from Person Where Job != 'Manager'

Alter Table Person 
Add Constraint DF_Person_Comm Default 1.0 For Comm;

Select * from Brand;

Alter Table Person Add Password bigint;

Select * from Person



-- Yeni trigger'ı oluştur
CREATE TRIGGER trgGeneratePasswordOnInsert
ON Person
INSTEAD OF INSERT
AS
BEGIN
    -- Yeni eklenen kayıtları geçici bir tabloya kopyala
    SELECT * INTO #InsertedPersons FROM inserted;

    -- Şifre oluşturma ve Person tablosuna ekleme işlemleri
    DECLARE @PersonId INT, @Name NVARCHAR(50), @GeneratedPassword NVARCHAR(50);

    WHILE (SELECT COUNT(*) FROM #InsertedPersons) > 0
    BEGIN
        SELECT TOP 1 @PersonId = PersonId, @Name = Name FROM #InsertedPersons;

        -- Şifre oluşturma mantığı burada eklenecek, aşağıda basit bir örnek var
        SET @GeneratedPassword = CONVERT(NVARCHAR(50), @PersonId * 1000);

        -- Yeni şifreyi Person tablosuna ekle
        UPDATE Person SET Password = @GeneratedPassword WHERE PersonId = @PersonId;

        -- Geçici tablodan ilgili kaydı sil
        DELETE FROM #InsertedPersons WHERE PersonId = @PersonId;
    END

    INSERT INTO Person
    SELECT * FROM #InsertedPersons;
END;


CREATE TRIGGER GenerateEmailAfterPersonInsert
ON Person
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Yeni eklenen kayıtları seç
    INSERT INTO Email (Mail, SenderId)
    SELECT 
        p.Name + CAST(p.PersonId AS NVARCHAR(10)) + '@gmail.com', p.PersonId
    FROM 
        INSERTED i
        INNER JOIN Person p ON i.PersonId = p.PersonId;
END;


Insert into Person(PersonId, Name, Job, Mgr, Birthday, Salary, CollarId, Gender, Work)
Values(1112, 'Merve', 'Developer', 7566, '2002-08-01', 6000, 10, 'F', 0)
Insert into Person(PersonId, Name, Job, Mgr, Birthday, Salary, CollarId, Gender, Work)
Values(1112, 'Merve', 'Developer', 7566, '2002-08-01', 6000, 10, 'F', 0)

INSERT INTO Person (Name, Job, Mgr, Birthday, Salary, CollarId, Gender, Work)
VALUES ('John Doe', 'Developer', 7566, '2004-08-01', 6000, 10, 'F', 0);

Select * from Person
Select * from Branch
Select * from Supplier
Select * from Product
Select * from Email
Select * from Category
Select * from Price


Insert into Product Values('Lenovo Y520 Pc', (Select CategoryId from Category Where CategoryName = 'Electronic'), 
Insert into Price Values(6999));


INSERT INTO Price (PurchasePrice, SalesPrice)
VALUES (6999, 0);

DECLARE @NewPriceId INT;
SET @NewPriceId = SCOPE_IDENTITY();

INSERT INTO Product (ProductName, CategoryId, PriceId)
VALUES ('Lenovo Y520 Pc', (SELECT CategoryId FROM Category WHERE CategoryName = 'Electronic'), @NewPriceId);

ALTER TABLE Product
ADD ProductCount INT DEFAULT 0;





Delete from Product Where ProductName = 'Lenovo Y520 Pc'
Delete from Price



EXEC AddPriceAndProduct 'Lenovo Y520 Pc', 'Electronic', 100, 120;

Select * from Product
Select * from Price
Select * from Person

Select Name from Person Where Job = 'Manager'



Update Person Set Password = CONVERT(NVARCHAR(50), PersonId * 1000)

Select * from Person

Delete from Person Where Name = 'Merve';
Delete from Person Where Name = 'Ali';
Delete from Person Where Name = 'Elif';

--Insert isleminde programda son kaydedilen kayidin PersonId sine 1 eklenerek devam ettirilecek
Insert into Person(PersonId, Name, Job, Mgr, Birthday, Salary, CollarId, Gender) Values(1112, 'Merve', 'Developer', 7566,'2002-08-01', 6000, 30,'F')
Insert into Person(PersonId, Name, Job, Mgr, Birthday, Salary, CollarId, Gender) Values(1113, 'Ali', 'Accounting', 7566,'1996-07-22', 5000, 30,'M')

Select * from Email
Select * from Inbox

Delete From Email Where SenderId = 1;

Select * from Person

Drop Trigger trg_AfterInsertPerson

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
	EXEC dbo.FillStartDate;
END;

Alter Table Person Add StartDate Date;

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


Select * from Person

