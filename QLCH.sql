CREATE DATABASE QLCH
GO

USE QLCH	
GO

-- Tạo bảng Role
CREATE TABLE Role (
    id INT PRIMARY KEY,
    rolename NVARCHAR(255)
);

-- Tạo bảng Account
CREATE TABLE Account (
    username VARCHAR(255) PRIMARY KEY,
    pwd VARCHAR(255),
    roleid INT,
    fullname NVARCHAR(255),
	status nvarchar(255),
    FOREIGN KEY (roleid) REFERENCES Role(id),
);

-- Tạo bảng Category
CREATE TABLE Category (
    id INT PRIMARY KEY,
    catename VARCHAR(255),
	status nvarchar(255),
);

-- Tạo bảng Item
CREATE TABLE Item (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    unit VARCHAR(50),
    price DECIMAL(10, 0),
    cateid INT,
	status nvarchar(255),
    FOREIGN KEY (cateid) REFERENCES Category(id)
);

-- Tạo bảng Customer
CREATE TABLE Customer (
    id INT PRIMARY KEY,
    fullname NVARCHAR(255),
	address NVARCHAR(255),
	phonenumber CHAR(10),
	status nvarchar(255)
);

-- Tạo bảng Bill
CREATE TABLE Bill (
    id INT IDENTITY(1,1) PRIMARY KEY,
    customerid INT,
    status NVARCHAR(50),
	time DATE,
    FOREIGN KEY (customerid) REFERENCES Customer(id)
);

-- Tạo bảng BillDetail
CREATE TABLE BillDetail (
    id INT IDENTITY(1,1) PRIMARY KEY,
    billid INT,
    itemid INT,
    quantity INT,
	total DECIMAL(10, 0),
    FOREIGN KEY (billid) REFERENCES Bill(id),
    FOREIGN KEY (itemid) REFERENCES Item(id)
);

-- Thêm dữ liệu vào bảng Role
INSERT INTO Role (id, rolename) VALUES(1, 'Admin'),(2, 'Staff')
GO

-- Thêm dữ liệu vào bảng User
INSERT INTO Account (username, pwd, roleid, fullname ,status) 
VALUES ('levantuan', '202CB962AC59075B964B07152D234B70', 1, N'Lê Văn Tuấn', N'Using'),
('nguyenthiennhan', '202CB962AC59075B964B07152D234B70', 1, N'Nguyễn Thiện Nhân', N'Using'),
('letanphat', '202CB962AC59075B964B07152D234B70', 2, N'Lê Tấn Phát', N'Using'), 
('user4', '202CB962AC59075B964B07152D234B70', 2, N'User 4', N'Using'),
('user5', '202CB962AC59075B964B07152D234B70', 2, N'User 5', N'Using'),
('user6', '202CB962AC59075B964B07152D234B70', 2, N'User 6', N'Using'),
('user7', '202CB962AC59075B964B07152D234B70', 2, N'User 7', N'Using'),
('user8', '202CB962AC59075B964B07152D234B70', 2, N'User 8', N'Using'),
('user9', '202CB962AC59075B964B07152D234B70', 2, N'User 9', N'Using'),
('user10', '202CB962AC59075B964B07152D234B70', 2, N'User 10', N'Using'),
('user11', '202CB962AC59075B964B07152D234B70', 2, N'User 11', N'Using'),
('user12', '202CB962AC59075B964B07152D234B70', 2, N'User 12', N'Using'),
('user13', '202CB962AC59075B964B07152D234B70', 2, N'User 13', N'Using'),
('user14', '202CB962AC59075B964B07152D234B70', 2, N'User 14', N'Using'),
('user15', '202CB962AC59075B964B07152D234B70', 2, N'User 15', N'Using'),
('user16', '202CB962AC59075B964B07152D234B70', 2, N'User 16', N'Using'),
('user17', '202CB962AC59075B964B07152D234B70', 2, N'User 17', N'Using'),
('user18', '202CB962AC59075B964B07152D234B70', 2, N'User 18', N'Using'),
('user19', '202CB962AC59075B964B07152D234B70', 2, N'User 19', N'Using'),
('user20', '202CB962AC59075B964B07152D234B70', 2, N'User 20', N'Using'),
('user21', '202CB962AC59075B964B07152D234B70', 2, N'User 21', N'Using'),
('user22', '202CB962AC59075B964B07152D234B70', 2, N'User 22', N'Using'),
('user23', '202CB962AC59075B964B07152D234B70', 2, N'User 23', N'Using'),
('user24', '202CB962AC59075B964B07152D234B70', 2, N'User 24', N'Using'),
('user25', '202CB962AC59075B964B07152D234B70', 2, N'User 25', N'Using'),
('user26', '202CB962AC59075B964B07152D234B70', 2, N'User 26', N'Using')
GO

-- Thêm dữ liệu mẫu vào bảng Category
INSERT INTO Category (id, catename, status)
VALUES(1, 'Electronics', N'Using'),(2, 'Clothing', N'Using'),(3, 'Home Decor', N'Using'),
(4, 'Appliances', N'Using'),(5, 'Books', N'Using'),(6, 'Beauty', N'Using'),
(7, 'Toys', N'Using'),(8, 'Sports', N'Using'),(9, 'Jewelry', N'Using'),
(10, 'Food', N'Using'),(11, 'Furniture', N'Using'),(12, 'Stationery', N'Using'),
(13, 'Automotive', N'Using'),(14, 'Pets', N'Using'),(15, 'Health', N'Using'),
(16, 'Garden', N'Using'),(17, 'Music', N'Using'),(18, 'Movies', N'Using'),
(19, 'Baby', N'Using'),(20, 'Tools', N'Using'),(21, 'Crafts', N'Using'),(22, 'Party', N'Using'),
(23, 'Office', N'Using'),(24, 'Travel', N'Using'),(25, 'Fitness', N'Using'),(26, 'Fashion', N'Using'),
(27, 'Hobbies', N'Using'),(28, 'Technology', N'Using'),(29, 'Gifts', N'Using'),(30, 'Outdoors', N'Using');
GO

-- Thêm dữ liệu mẫu vào bảng Item
INSERT INTO Item (id, name, unit, price, cateid, status)
VALUES (1, 'Laptop', N'Cái', 15000000, 1, N'Using'),(2, 'T-Shirt', N'Cái', 250000, 2, N'Using'),
(3, 'Cushion', N'Cái', 100000, 3, N'Using'),(4, 'Refrigerator', N'Cái', 8000000, 4, N'Using'),
(5, 'Novel', N'Cái', 129900, 5, N'Using'),(6, 'Lipstick', N'Cái', 85000, 6, N'Using'),
(7, 'Action Figure', N'Cái', 150000, 7, N'Using'),(8, 'Basketball', N'Cái', 200000, 8, N'Using'),
(9, 'Necklace', N'Cái', 500000, 9, N'Using'),(10, 'Chocolate', N'Cái', 59900, 10, N'Using'),
(11, 'Sofa', N'Cái', 6000000, 11, N'Using'),(12, 'Notebook', N'Cái', 39900, 12, N'Using'),
(13, 'Car Battery', N'Cái', 1000000, 13, N'Using'),(14, 'Dog Toy', N'Cái', 79900, 14, N'Using'),
(15, 'Vitamin C', N'Cái', 99900, 15, N'Using'),(16, 'Garden Hose', N'Cái', 159900, 16, N'Using'),
(17, 'CD Album', N'Cái', 99900, 17, N'Using'),(18, 'DVD Movie', N'Cái', 79900, 18, N'Using'),
(19, 'Baby Bib', N'Cái', 35000, 19, N'Using'),(20, 'Hammer', N'Cái', 129900, 20, N'Using'),
(21, 'Scrapbook', N'Cái', 89900, 21, N'Using'),(22, 'Party Hat', N'Cái', 19900, 22, N'Using'),
(23, 'Stapler', N'Cái', 59900, 23, N'Using'),(24, 'Luggage', N'Cái', 800000, 24, N'Using'),
(25, 'Yoga Mat', N'Cái', 250000, 25, N'Using'),(26, 'Dress', N'Cái', 450000, 26, N'Using'),
(27, 'Guitar', N'Cái', 2000000, 27, N'Using'),(28, 'Smartphone', N'Cái', 8000000, 28, N'Using'),
(29, 'Gift Card', N'Cái', 500000, 29, N'Using'),(30, 'Camping Tent', N'Cái', 1000000, 30, N'Using');
GO

INSERT INTO Customer (id, fullname, address, phonenumber, status)
VALUES(1, N'Nguyễn Thị Xuyến', N'Hà Nội', '0123456789', N'Using'),(2, N'Trần Văn Giang', N'Hồ Chí Minh', '0987654321', N'Using'),
(3, N'Lê Thị Thanh', N'Đà Nẵng', '0369852147', N'Using'),(4, N'Phạm Văn Thưởng', N'Hải Phòng', '0798541236', N'Using'),
(5, N'Huỳnh Thị Tuyết Nhi', N'Cần Thơ', '0923658741', N'Using'),(6, N'Đặng Văn Sang', N'Bình Dương', '0852147963', N'Using'),
(7, N'Bùi Thị Kiều My', N'Hải Dương', '0769852143', N'Using'),(8, N'Ngô Văn Phong', N'Nam Định', '0369852147', N'Using'),
(9, N'Trương Thị Thu', N'Hưng Yên', '0987456321', N'Using'),(10, N'Vũ Văn Nam', N'Hải Dương', '0912345678', N'Using'),
(11, N'Lý Thị Hảo', N'Bắc Giang', '0876543210', N'Using'),(12, N'Hoàng Văn Linh', N'Quảng Ninh', '0923658741', N'Using'),
(13, N'Chu Thị Hà', N'Thái Bình', '0769852143', N'Using'),(14, N'Dương Văn Khang', N'Ninh Bình', '0798541236', N'Using'),
(15, N'Trịnh Thị Lan', N'Yên Bái', '0369852147', N'Using'),(16, N'Võ Văn Hiếu', N'Hòa Bình', '0987456321', N'Using'),
(17, N'Tôn Thị Liên', N'Thanh Hóa', '0912345678', N'Using'),(18, N'Thái Văn Tài', N'Hà Nam', '0876543210', N'Using'),
(19, N'Âu Thị Kim Lệ', N'Nghệ An', '0923658741', N'Using'),(20, N'Vương Văn Dũng', N'Hà Tĩnh', '0769852143', N'Using'),
(21, N'Khúc Thị Kiều', N'Quảng Bình', '0798541236', N'Using'),(22, N'Liễu Văn Bình', N'Quảng Trị', '0369852147', N'Using'),
(23, N'Phí Thị Kim Liên', N'Thừa Thiên Huế', '0987456321', N'Using'),(24, N'Mạch Văn Dũng', N'Quảng Nam', '0912345678', N'Using'),
(25, N'Nghiêm Thị Yến', N'Quảng Ngãi', '0876543210', N'Using'),(26, N'Chử Văn Tài', N'Bình Định', '0923658741', N'Using'),
(27, N'Phan Thị Trà', N'Phú Yên', '0769852143', N'Using'),(28, N'Quách Văn Vũ', N'Khánh Hòa', '0798541236', N'Using'),
(29, N'Tạ Thị Dung', N'Lâm Đồng', '0369852147', N'Using'),(30, N'Lục Văn Tiến', N'Đắk Lắk', '0987456321', N'Using');
GO

SELECT * FROM Account
SELECT * FROM Role	
SELECT * FROM Item
SELECT * FROM Category
SELECT * FROM Customer
SELECT * FROM Bill
SELECT * FROM BillDetail