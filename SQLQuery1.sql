create database QuanLyQuanTraSua
go

use QuanLyQuanTraSua
go

create table TableFood
(
	id int identity primary key,
	name nvarchar(100) not null default N'Ban chua co ten',
	status nvarchar(100)  not null default N'Trống'--trong|| co nguoi
)
go

create table Account
(
		UserName nvarchar(100) primary key ,
	DisplayName nvarchar(100) not null default N'TuanCuong',
	PassWord nvarchar(1000) not null default 0	
)

go

create table  FoodCategory
(
	id int identity primary key,
	name nvarchar(100) not null default N'Chua dat ten'
)

go
create table Food(
	id int identity primary key,
	name nvarchar(100) not null default N'Chua dat ten',
	idCategory int not null,
	price float not null default 0,
	Foreign key (idCategory) references dbo.FoodCategory(id)
)

go
create table Bill(
	id int identity primary key,
	DateCheckIn date not null default getdate(),
	idTable int not null,	
	status int not null default 0,  --1: da thanh toan || 0: chua thanh toan,
	foreign key (idTable) references dbo.TableFood(id)
	)
go

create table BillInfo(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int  not null  default  0,
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id),
	isDelete bit default 0  --0 la chua xoa|| 1 la da xoa
)
go 

insert into dbo.Account(UserName,DisplayName,PassWord) 
values (N'c',N'Cuong',N'1'),(N'm',N'Minh',N'1'),(N't',N'Tu',N'1');



-- Thêm dữ liệu vào bảng TableFood
insert into dbo.TableFood(name, status) 
values 
 (N'Bàn 1', N'Trống'),
(N'Bàn 2', N'Trống'),
(N'Bàn 3', N'Có người'),
(N'Bàn 4', N'Trống'),
(N'Bàn 5', N'Có người'),
(N'Bàn 6', N'Trống'),
(N'Bàn 7', N'Trống'),
(N'Bàn 8', N'Có người'),
(N'Bàn 9', N'Trống'),
(N'Bàn 10', N'Có người'),
(N'Bàn 11', N'Trống'),
(N'Bàn 12', N'Có người');
GO

-- Thêm dữ liệu vào bảng FoodCategory
insert into dbo.FoodCategory(name)
values 
(N'Nuoc Tra'), 
(N'Nuoc Hoa Qua'), 
(N'Nuoc Sua');

-- Thêm dữ liệu vào bảng Food
insert into dbo.Food(name, idCategory, price) 
values 
(N'Tra Dao', 1, 25000), 
(N'Tra Chanh', 1, 20000), 
(N'Nuoc Cam', 2, 30000),
(N'Nuoc Dua', 2, 28000), 
(N'Sua Tuoi Tran Chau', 3, 35000),
(N'Nuoc Oi', 2, 25000), 
(N'Tra Dao Cam Xa', 1, 18000), 
(N'Sua Chua Nep Cam', 3, 20000), 
(N'Sua Chua Danh Da', 3, 28000);

-- Thêm dữ liệu vào bảng Bill
insert into dbo.Bill( idTable, status) 
values 
(3, 0),
(5, 0),
(8, 0),
(10, 0),
(12, 0);

-- Thêm dữ liệu vào bảng BillInfo
insert into dbo.BillInfo(idBill, idFood, count) 
values 
-- Bàn 3
(1, 1, 2),  -- 2 món Tra Dao
(1, 3, 3),  -- 3 món Nuoc Cam
-- Bàn 5
(2, 1, 1),  -- 1 món Tra Dao
(2, 4, 2),  -- 2 món Nuoc Dua
-- Bàn 8
(3, 5, 3),  -- 3 món Sua Tuoi Tran Chau
(3, 3, 1),  -- 1 món Nuoc Cam
-- Bàn 10
(4, 6, 4),  -- 4 món Nuoc Oi
-- Bàn 12
(5, 7, 2),  -- 2 món Tra Dao Cam Xa
(5, 8, 3);  -- 3 món Sua Chua Nep Cam
go


select * from dbo.Bill
go
select * from dbo.Account
go
select * from dbo.FoodCategory
go
select * from dbo.TableFood
go 
select * from dbo.Food

SELECT 
    tf.name AS TableName, -- Tên bàn
    f.name AS FoodName,   -- Tên món
    bi.count AS Quantity, -- Số lượng món
    f.price AS Price,     -- Giá món
    (bi.count * f.price) AS TotalPrice -- Thành tiền (số lượng * giá)
FROM 
    dbo.Bill b
JOIN 
    dbo.BillInfo bi ON b.id = bi.idBill
JOIN 
    dbo.Food f ON bi.idFood = f.id
JOIN 
    dbo.TableFood tf ON b.idTable = tf.id

ORDER BY 
    tf.name; -- Sắp xếp theo tên bàn