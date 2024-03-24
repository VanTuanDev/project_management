USE QLCH
GO

CREATE PROCEDURE GetCategories
AS
BEGIN
    SELECT * FROM Category;
END
GO

CREATE PROCEDURE DeleteCategory
    @CategoryID INT
AS
BEGIN
    DELETE FROM Category
    WHERE id = @CategoryID

    SELECT 1 AS Success
END
GO

CREATE PROCEDURE InsertCategory
    @CategoryId INT,
    @CategoryName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Category(id, name)
    VALUES (@CategoryId, @CategoryName)
END
GO

CREATE PROCEDURE UpdateCategory
    @CategoryId INT,
    @NewCategoryName NVARCHAR(100)
AS
BEGIN
    UPDATE Category
    SET name = @NewCategoryName
    WHERE id = @CategoryId
END
GO

CREATE PROCEDURE GetClients
AS
BEGIN
    SELECT * FROM Customer;
END
GO

CREATE PROCEDURE DeleteClient
    @ClientID INT
AS
BEGIN
    DELETE FROM Customer
    WHERE id = @ClientID

    SELECT 1 AS Success
END
GO

CREATE PROCEDURE InsertClient
    @ClientId INT,
    @ClientName NVARCHAR(100),
	@ClientAddress NVARCHAR(255),
    @ClientPhone CHAR(10)
AS
BEGIN
    INSERT INTO Customer(id, fullname, address, phonenumber)
    VALUES (@ClientId, @ClientName, @ClientAddress, @ClientPhone)
END
GO

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
GO

CREATE PROCEDURE GetFoods
AS
BEGIN
    SELECT * FROM Item;
END
GO

CREATE PROCEDURE DeleteFood
    @FoodId INT
AS
BEGIN
    DELETE FROM Item
    WHERE id = @FoodId

    SELECT 1 AS Success
END
GO

CREATE PROCEDURE InsertFood
    @FoodId INT,
    @FoodName VARCHAR(255),
    @Unit VARCHAR(50),
    @Price DECIMAL(10, 2),
    @CategoryId INT
AS
BEGIN
    INSERT INTO Item(id, name, unit, price, cateid)
    VALUES (@FoodId, @FoodName, @Unit, @Price, @CategoryId)
END
GO

CREATE PROCEDURE UpdateFood
    @FoodId INT,
    @NewFoodName VARCHAR(255),
    @NewUnit VARCHAR(50),
    @NewPrice DECIMAL(10, 2),
    @NewCategoryId INT
AS
BEGIN
    UPDATE Item
    SET name = @NewFoodName,
		unit = @NewUnit,
		price = @NewPrice,
		cateid = @NewCategoryId
    WHERE id = @FoodId
END
GO