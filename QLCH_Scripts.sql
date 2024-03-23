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