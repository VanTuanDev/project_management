USE QLCH
GO

CREATE PROCEDURE GetCategories
AS
BEGIN
    SELECT * FROM Category;
END

CREATE PROCEDURE DeleteCategory
    @CategoryID INT
AS
BEGIN
    DELETE FROM Category
    WHERE id = @CategoryID

    SELECT 1 AS Success
END

CREATE PROCEDURE InsertCategory
    @CategoryId INT,
    @CategoryName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Category(id, name)
    VALUES (@CategoryId, @CategoryName)
END

CREATE PROCEDURE UpdateCategory
    @CategoryId INT,
    @NewCategoryName NVARCHAR(100)
AS
BEGIN
    UPDATE Category
    SET name = @NewCategoryName
    WHERE id = @CategoryId
END

CREATE PROCEDURE GetClients
AS
BEGIN
    SELECT * FROM Customer;
END

CREATE PROCEDURE DeleteClient
    @ClientID INT
AS
BEGIN
    DELETE FROM Customer
    WHERE id = @ClientID

    SELECT 1 AS Success
END

CREATE PROCEDURE InsertClient
    @ClientId INT,
    @ClientName NVARCHAR(100),
	@ClientAddress NVARCHAR(255),
    @ClientPhone CHAR(10)
AS
BEGIN
    INSERT INTO Client (id, fullname, address, phonenumber)
    VALUES (@ClientId, @ClientName, @ClientAddress, @ClientPhone)
END

CREATE PROCEDURE UpdateClient
    @ClientId INT,
    @NewClientName NVARCHAR(100),
	@NewClientAddress NVARCHAR(255),
    @NewClientPhone CHAR(10)
AS
BEGIN
    UPDATE Customer
    SET fullname = @NewClientName,
		address = @NewClientAddress,
		phonenumber = @NewClientPhone
    WHERE id = @ClientId
END