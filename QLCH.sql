CREATE DATABASE QLCH
GO

USE QLCH
GO

-- Tạo bảng Role
CREATE TABLE Role (
    id INT PRIMARY KEY,
    rolename NVARCHAR(255)
);

-- Tạo bảng UserInfo
CREATE TABLE UserInfo (
    id INT PRIMARY KEY,
    fullname NVARCHAR(255),
);

-- Tạo bảng Account
CREATE TABLE Account (
    username VARCHAR(255) PRIMARY KEY,
    pwd VARCHAR(255),
    roleid INT,
    userid INT,
    FOREIGN KEY (roleid) REFERENCES Role(id),
    FOREIGN KEY (userid) REFERENCES UserInfo(id)
);

-- Tạo bảng Category
CREATE TABLE Category (
    id INT PRIMARY KEY,
    name VARCHAR(255)
);

-- Tạo bảng Item
CREATE TABLE Item (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    unit VARCHAR(50),
    price DECIMAL(10, 2),
    cateid INT,
    FOREIGN KEY (cateid) REFERENCES Category(id)
);

-- Tạo bảng Customer
CREATE TABLE Customer (
    id INT PRIMARY KEY,
    fullname NVARCHAR(255),
	address NVARCHAR(255),
	phonenumber CHAR(10)
);

-- Tạo bảng Bill
CREATE TABLE Bill (
    id INT PRIMARY KEY,
    customerid INT,
    status VARCHAR(50),
    FOREIGN KEY (customerid) REFERENCES Customer(id)
);

-- Tạo bảng BillDetail
CREATE TABLE BillDetail (
    id INT PRIMARY KEY,
    billid INT,
    itemid INT,
    quantity INT,
	total DECIMAL(10, 2),
    FOREIGN KEY (billid) REFERENCES Bill(id),
    FOREIGN KEY (itemid) REFERENCES Item(id)
);

-- Thêm dữ liệu vào bảng Role
INSERT INTO Role (id, rolename) VALUES(1, 'Admin'),(2, 'Staff')
GO

-- Thêm dữ liệu vào bảng UserInfo
INSERT INTO UserInfo(id, fullname) VALUES(1, N'Lê Văn Tuấn'),(2, N'Nguyễn Thiện Nhân'),(3, N'Lê Tấn Phát'),
(4, N'Phạm Thị D'),(5, N'Huỳnh Văn E'),(6, N'Đặng Thị F'),(7, N'Bùi Văn G'),(8, N'Ngô Thị H'),(9, N'Trương Văn I'),
(10, N'Vũ Thị K'),(11, N'Lý Văn L'),(12, N'Hoàng Thị M'),(13, N'Chu Văn N'),(14, N'Dương Thị P'),(15, N'Trịnh Văn Q'),
(16, N'Võ Thị R'),(17, N'Tôn Văn S'),(18, N'Thái Thị T'),(19, N'Âu Văn U'),(20, N'Vương Thị V'),(21, N'Khúc Văn X'),
(22, N'Liễu Thị Y'),(23, N'Phí Văn Z'),(24, N'Mạch Thị Ô'),(25, N'Nghiêm Văn Ơ'),(26, N'Chử Thị Ư')
GO

-- Thêm dữ liệu vào bảng User
INSERT INTO Account (username, pwd, roleid, userid) 
VALUES ('levantuan', '123456', 1, 1),('nguyenthiennhan', '123456', 1, 2),('letanphat', '123456', 2, 3),('user4', 'password4', 2, 4),
('user5', 'password5', 2, 5),('user6', 'password6', 2, 6),('user7', 'password7', 2, 7),('user8', 'password8', 2, 8),('user9', 'password9', 1, 9),
('user10', 'password10', 2, 10),('user11', 'password11', 1, 11),('user12', 'password12', 2, 12),('user13', 'password13', 1, 13),('user14', 'password14', 2, 14),
('user15', 'password15', 1, 15),('user16', 'password16', 2, 16),('user17', 'password17', 1, 17),('user18', 'password18', 2, 18),('user19', 'password19', 1, 19),
('user20', 'password20', 2, 20),('user21', 'password21', 1, 21),('user22', 'password22', 2, 22),('user23', 'password23', 1, 23),('user24', 'password24', 2, 24),
('user25', 'password25', 1, 25),('user26', 'password26', 2, 26)
GO

-- Thêm dữ liệu mẫu vào bảng Category
INSERT INTO Category (id, name)
VALUES(1, 'Electronics'),(2, 'Clothing'),(3, 'Home Decor'),(4, 'Appliances'),(5, 'Books'),
(6, 'Beauty'),(7, 'Toys'),(8, 'Sports'),(9, 'Jewelry'),(10, 'Food'),(11, 'Furniture'),
(12, 'Stationery'),(13, 'Automotive'),(14, 'Pets'),(15, 'Health'),(16, 'Garden'),
(17, 'Music'),(18, 'Movies'),(19, 'Baby'),(20, 'Tools'),(21, 'Crafts'),(22, 'Party'),
(23, 'Office'),(24, 'Travel'),(25, 'Fitness'),(26, 'Fashion'),(27, 'Hobbies'),(28, 'Technology'),
(29, 'Gifts'),(30, 'Outdoors');
GO

-- Thêm dữ liệu mẫu vào bảng Item
INSERT INTO Item (id, name, unit, price, cateid)
VALUES (1, 'Laptop', N'Cái', 15000000, 1),(2, 'T-Shirt', N'Cái', 250000, 2),(3, 'Cushion', N'Cái', 100000, 3),
(4, 'Refrigerator', N'Cái', 8000000, 4),(5, 'Novel', N'Cái', 129900, 5),(6, 'Lipstick', N'Cái', 85000, 6),
(7, 'Action Figure', N'Cái', 150000, 7),(8, 'Basketball', N'Cái', 200000, 8),(9, 'Necklace', N'Cái', 500000, 9),
(10, 'Chocolate', N'Cái', 59900, 10),(11, 'Sofa', N'Cái', 6000000, 11),(12, 'Notebook', N'Cái', 39900, 12),
(13, 'Car Battery', N'Cái', 1000000, 13),(14, 'Dog Toy', N'Cái', 79900, 14),(15, 'Vitamin C', N'Cái', 99900, 15),
(16, 'Garden Hose', N'Cái', 159900, 16),(17, 'CD Album', N'Cái', 99900, 17),(18, 'DVD Movie', N'Cái', 79900, 18),
(19, 'Baby Bib', N'Cái', 35000, 19),(20, 'Hammer', N'Cái', 129900, 20),(21, 'Scrapbook', N'Cái', 89900, 21),
(22, 'Party Hat', N'Cái', 19900, 22),(23, 'Stapler', N'Cái', 59900, 23),(24, 'Luggage', N'Cái', 800000, 24),
(25, 'Yoga Mat', N'Cái', 250000, 25),(26, 'Dress', N'Cái', 450000, 26),(27, 'Guitar', N'Cái', 2000000, 27),
(28, 'Smartphone', N'Cái', 8000000, 28),(29, 'Gift Card', N'Cái', 500000, 29),(30, 'Camping Tent', N'Cái', 1000000, 30);
GO

INSERT INTO Customer (id, fullname, address, phonenumber)
VALUES(1, N'Nguyễn Thị X', N'Hà Nội', '0123456789'),(2, N'Trần Văn Y', N'Hồ Chí Minh', '0987654321'),
(3, N'Lê Thị Z', N'Đà Nẵng', '0369852147'),(4, N'Phạm Văn T', N'Hải Phòng', '0798541236'),
(5, N'Huỳnh Thị U', N'Cần Thơ', '0923658741'),(6, N'Đặng Văn S', N'Bình Dương', '0852147963'),
(7, N'Bùi Thị R', N'Hải Dương', '0769852143'),(8, N'Ngô Văn P', N'Nam Định', '0369852147'),
(9, N'Trương Thị O', N'Hưng Yên', '0987456321'),(10, N'Vũ Văn N', N'Hải Dương', '0912345678'),
(11, N'Lý Thị M', N'Bắc Giang', '0876543210'),(12, N'Hoàng Văn L', N'Quảng Ninh', '0923658741'),
(13, N'Chu Thị K', N'Thái Bình', '0769852143'),(14, N'Dương Văn J', N'Ninh Bình', '0798541236'),
(15, N'Trịnh Thị I', N'Yên Bái', '0369852147'),(16, N'Võ Văn H', N'Hòa Bình', '0987456321'),
(17, N'Tôn Thị G', N'Thanh Hóa', '0912345678'),(18, N'Thái Văn F', N'Hà Nam', '0876543210'),
(19, N'Âu Thị E', N'Nghệ An', '0923658741'),(20, N'Vương Văn D', N'Hà Tĩnh', '0769852143'),
(21, N'Khúc Thị C', N'Quảng Bình', '0798541236'),(22, N'Liễu Văn B', N'Quảng Trị', '0369852147'),
(23, N'Phí Thị A', N'Thừa Thiên Huế', '0987456321'),(24, N'Mạch Văn Z', N'Quảng Nam', '0912345678'),
(25, N'Nghiêm Thị Y', N'Quảng Ngãi', '0876543210'),(26, N'Chử Văn X', N'Bình Định', '0923658741'),
(27, N'Phan Thị W', N'Phú Yên', '0769852143'),(28, N'Quách Văn V', N'Khánh Hòa', '0798541236'),
(29, N'Tạ Thị U', N'Lâm Đồng', '0369852147'),(30, N'Lục Văn T', N'Đắk Lắk', '0987456321');
GO

SELECT * FROM Account
SELECT * FROM Role	
SELECT * FROM UserInfo
SELECT * FROM Item
SELECT * FROM Category
SELECT * FROM Customer
SELECT * FROM Bill
SELECT * FROM BillDetail