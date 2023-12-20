CREATE DATABASE QLTC

USE QLTC
-- CREATE TABLE PART
CREATE TABLE Customer(
	cus_id varchar(20) NOT NULL,
	fullname nvarchar(225) NOT NULL,
	birth date NOT NULL,
	gender nvarchar(10) NOT NULL,
	address nvarchar(225) NOT NULL,
	phonenum char(20) NOT NULL,
	status nvarchar(50),
	injected int,
);


CREATE TABLE Vaccine(
	vac_id int NOT NULL IDENTITY(1,1),
	vacname nvarchar(225) NOT NULL,
	disease nvarchar(255) NOT NULL,
	producer nvarchar(225) NOT NULL,
	production_batch char(50) NOT NULL,
	mfg date NOT NULL,
	expiry date NOT NULL,
	price decimal(10,2) NOT NULL,
	num_injection int NOT NULL,
	distance_injection int NOT NULL
);


CREATE TABLE Schedule(
	schedule_id int NOT NULL IDENTITY(1,1),
    cus_id varchar(20) NOT NULL,
    vac_id int NOT NULL,
    injection_date date NOT NULL,
    center_id int NOT NULL,
	total decimal(10,0)
);

CREATE TABLE Account(
	account_id int NOT NULL IDENTITY(1,1),
	cus_id varchar(20) NOT NULL,
	email varchar(255) UNIQUE NOT NULL,
	password varchar(255) NOT NULL,
);

CREATE TABLE Admin(
	admin_id int IDENTITY(1,1),
    username varchar(50) UNIQUE NOT NULL,
    password varchar(100) NOT NULL,
    first_name varchar(50) NOT NULL,
    last_name varchar(50) NOT NULL,
    email varchar(100) UNIQUE NOT NULL,
    phone_number varchar(10)
);

CREATE TABLE VaccineWarehouse(
    vac_id int NOT NULL,
    quanity int NOT NULL,
	input_day date NOT NULL,
    status nvarchar(20),
);

CREATE TABLE IntermediacteCalendar(
	schedule_id int NOT NULL,
	vac_id int NOT NULL,
	injection_date1 date NOT NULL,
	injection_date2 date,
	injection_date3 date,
	injection_date_repeat date
);

CREATE TABLE Centers (
	center_id int IDENTITY(1,1),
	center_name nvarchar(255) NOT NULL,
	province nvarchar(255) NOT NULL
);


----------------------------------------------------
-- UPDATE PART --
--UPDATE data type for injection_site
/*ALTER TABLE Schedule
ALTER COLUMN injection_site nvarchar(255);

-- Mark format "," for price field
ALTER TABLE Vaccine
ALTER COLUMN price decimal(10,0);

-- UPDATE data type for gender field
ALTER TABLE Customer
ALTER COLUMN gender nvarchar(10) NOT NULL;

ALTER TABLE Schedule
ALTER COLUMN center_id int NOT NULL;

-- Change column name
EXEC sp_rename 'Schedule.province', 'center_id', 'COLUMN';
EXEC sp_rename 'VaccineWarehouse.vac_id', 'center_id', 'COLUMN';

--Change column username of admin table to admin name
EXEC sp_rename 'Admin.username', 'admin_name', 'COLUMN';

ALTER TABLE Schedule
DROP COLUMN injection_center

ALTER TABLE VaccineWarehouse
DROP COLUMN input_day

ALTER TABLE VaccineWarehouse
DROP COLUMN expiry */

----------------------------------------------------

----------------------------------------------------
-- ADD PART --
-- ADD Location to the VaccineWarehouse table
/*ALTER TABLE VaccineWarehouse
ADD location nvarchar(255) NOT NULL

ALTER TABLE Schedule
ADD injection_center nvarchar(255) NOT NULL

ALTER TABLE Vaccine
ADD num_injection int; 

ALTER TABLE Vaccine
ADD distance_injection int; */

ALTER TABLE Account
ADD CONSTRAINT chk_EmailFormat
CHECK (email LIKE '%@gmail.com');

/*ALTER TABLE Schedule
ADD total decimal(10,0);

ALTER TABLE VaccineWarehouse
ADD status nvarchar(20); */

ALTER TABLE Schedule
ADD state varchar(50); 

----------------------------------------------------

-- SET UP PRIMARY KEY AND FOREIGN KEY
ALTER TABLE Customer
ADD PRIMARY KEY (cus_id);

ALTER TABLE Vaccine
ADD PRIMARY KEY (vac_id);

ALTER TABLE Account
ADD PRIMARY KEY (account_id);

ALTER TABLE Admin
ADD PRIMARY KEY (admin_id);

ALTER TABLE Schedule
ADD PRIMARY KEY (schedule_id);

ALTER TABLE Centers
ADD PRIMARY KEY (center_id);

ALTER TABLE Schedule
ADD CONSTRAINT fk_cus_id FOREIGN KEY (cus_id) REFERENCES Customer (cus_id) ON DELETE CASCADE;

ALTER TABLE Schedule
ADD CONSTRAINT fk_schedule_vacid FOREIGN KEY (vac_id) REFERENCES Vaccine (vac_id) ON DELETE NO ACTION;

ALTER TABLE VaccineWarehouse
ADD CONSTRAINT fk_vac_warehouse FOREIGN KEY (center_id) REFERENCES Centers (center_id) ON DELETE CASCADE;

ALTER TABLE Account
ADD CONSTRAINT fk_cus_account FOREIGN KEY (cus_id) REFERENCES Customer (cus_id) ON DELETE CASCADE;

ALTER TABLE IntermediacteCalendar
ADD CONSTRAINT fk_inter_calendar_vacid FOREIGN KEY (vac_id) REFERENCES Vaccine (vac_id) ON DELETE CASCADE;

ALTER TABLE IntermediacteCalendar
ADD CONSTRAINT fk_inter_calendar_schduleid FOREIGN KEY (schedule_id) REFERENCES Schedule (schedule_id) ON DELETE CASCADE;

ALTER TABLE Schedule
ADD CONSTRAINT fk_center_id FOREIGN KEY (center_id) REFERENCES Centers (center_id) ON DELETE CASCADE;

----------------------------------------------------------------------------------
-- INSERT PART --
INSERT INTO Customer(cus_id, fullname, birth, gender, address, phonenum, status, injected) VALUES
('052203002764', N'Nguyễn Văn Thành', '1990-01-01', N'Nam', N'Hà Nội', '0912345678', N'Khỏe mạnh', 2),
('052203600152', N'Đào Cẩm Tú', '1995-02-02', N'Nữ', N'Thành phố Hồ Chí Minh', '0912345679', N'Khỏe mạnh', 1),
('084202115125', N'Trần Minh Hoàng', '2000-03-03', N'Nam', N'Đà Nẵng', '0912345680', N'Sức khỏe bình thường', 0);

INSERT INTO Vaccine(vacname, disease , producer, production_batch, mfg, expiry, price) VALUES
(N'Vắc xin COVID-19 Mỹ', N'COVID-19', 'Pfizer-BioNTech', '124401', '2023-06-21', '2024-06-05', 475120),
(N'Vắc xin COVID-19 Trung Quốc', N'COVID-19', 'Sinopharm', '123052', '2023-11-16', '2024-05-16', 331365),
(N'Vắc xin COVID-19 Anh-Thuỵ Điển', N'COVID-19', 'AstraZeneca', '177980', '2023-09-20', '2025-04-13', 58476),
(N'Vắc xin Havax', N'Virus viêm gan A', 'GlaxoSmithKline', '124407', '2023-06-23', '2024-06-07', 120000),
(N'Vắc xin Menectra', N'Viêm màng não mô cầu', 'Sanofi Pasteur', '124408', '2023-06-24', '2024-06-08', 1045000),
(N'Vắc xin Synflorix', N'Nhiễm trùng do phế cầu khuẩn', N'Bỉ', '124409', '2023-06-25', '2024-06-09', 10450),
(N'Vắc xin MMR', N'Sởi-Quai bị-Rebulla', N'Ấn Độ', '124410', '2023-06-26', '2024-06-10', 296000),
(N'Vắc xin Varicella', N'Thuỷ đậu', N'Hàn Quốc', '124411', '2023-06-27', '2024-06-11', 700000),
(N'Vắc xin Gardasil 0.5ml', N'HPV', 'GlaxoSmithKline', '124412', '2023-06-28', '2024-06-12', 1790000),
(N'Vắc xin Verorab 0,5 ml(TTD) 0.5ml', N'Bệnh dại', N'Pháp', '124624', '2023-07-02', '2024-04-10', 300000);

INSERT INTO Vaccine(vacname, disease , producer, production_batch, mfg, expiry, price) VALUES
(N'Vắc xin viêm gan B', N'Virus viêm gan B', 'Sanofi Pasteur', '124413', '2023-06-29', '2024-06-13', 150000),
(N'Vắc xin bại liệt', N'Bại liệt', 'Ấn Độ', '124414', '2023-07-01', '2024-06-14', 50000),
(N'Vắc xin ho gà', N'Ho gà', 'Hàn Quốc', '124415', '2023-07-02', '2024-06-15', 100000),
(N'Vắc xin uốn ván', N'Uốn ván', 'Pháp', '124625', '2023-07-03', '2024-04-11', 120000),
(N'Vắc xin bạch hầu', N'Bạch hầu', 'Bỉ', '124416', '2023-07-04', '2024-06-16', 100000),
(N'Vắc xin viêm não Nhật Bản', N'Viêm não Nhật Bản', 'GlaxoSmithKline', '124417', '2023-07-05', '2024-06-17', 100000),
(N'Vắc xin cúm', N'Cúm', 'Ấn Độ', '124418', '2023-07-06', '2024-06-18', 200000),
(N'Vắc xin Haemophilus influenzae type b', N'Haemophilus influenzae type b', 'Hàn Quốc', '124419', '2023-07-07', '2024-06-19', 150000),
(N'Vắc xin Rotavirus', N'Rotavirus', 'Pháp', '124626', '2023-07-08', '2024-04-12', 150000);

INSERT INTO Schedule(cus_id, vac_id, injection_date, province, injection_center) VALUES
('052203002761', 4, '2023-07-20', N'Bình Định', N'VFA Quy Nhơn')

INSERT INTO VaccineWarehouse(center_id, quanity, input_day, expiry, status)
VALUES
(1, 321, '2023-07-23','2024-06-05', 'Stocking'),
(2 , 267, '2023-08-16','2024-05-16', 'Stocking'),
(3 , 182, '2023-08-21','2025-04-13', 'Stocking'),
(4, 245, '2023-06-23','2024-06-07', 'Stocking'),
(5, 311, '2023-06-24','2024-06-08', 'Stocking'),
(6, 198, '2023-06-25','2024-06-09', 'Stocking'),
(7, 276, '2023-06-26','2024-06-10', 'Stocking'),
(8, 223, '2023-06-27','2024-06-11', 'Stocking'),
(9, 289, '2023-06-28','2024-06-12', 'Stocking'),
(10, 254, '2023-07-02','2024-04-10', 'Stocking'),
(11, 317, '2023-06-29','2024-06-13', 'Stocking');

INSERT INTO Admin(admin_name, password, first_name, last_name, email, phone_number) VALUES
(N'VNgyn54', 'abc444',N'Đoàn Võ', N'Nguyên', 'vn54@gmail.com', '0911683148')

INSERT INTO Schedule(cus_id, vac_id, injection_date, province, injection_center) VALUES
('052203009876', 37, '2023-10-21', N'Hà Nội', N'VFA Hoàn Kiếm')

SET IDENTITY_INSERT Centers ON
INSERT INTO Centers(center_id, center_name, province) VALUES
(1, N'VFA An Nhơn', N'Bình Định'),
(2, N'VFA Quy Nhơn', N'Bình Định'),
(3, N'VFA Tân Bình', N'Hồ Chí Minh'),
(4, N'VFA Quận 10', N'Hồ Chí Minh'),
(5, N'VFA Quận Gò Vấp', N'Hồ Chí Minh')

INSERT INTO Centers(center_id, center_name, province) VALUES
(6, N'VFA Bắc Giang', N'Bắc Giang'),
(7, N'VFA Quận 5', N'Hồ Chí Minh'),
(8, N'VFA Hoàng Sa', N'Đà Nẵng'),
(9, N'VFA Hải Dương', N'Hải Dương'),
(10, N'VFA Quận Bình Thạnh', N'Hồ Chí Minh'),
(11, N'VFA Cẩm Lệ', N'Đà Nẵng');
SET IDENTITY_INSERT Centers OFF
---------------------------------------------------------------------------------
--SELECT PART --
/*
select * from Customer
select * from Vaccine
select * from Schedule
select * from VaccineWarehouse
select * from Account
select * from Admin
select * from IntermediacteCalendar
select * from Centers
SELECT count(sche.schedule_id) as tong FROM Customer as cus JOIN Schedule as sche ON cus.cus_id = sche.cus_id JOIN Centers as cen ON sche.center_id = cen.center_id WHERE cen.center_name = N'VFA Quy Nhơn'
select count(cus_id) as number_inject FROM Schedule WHERE cus_id = '052203009876'
select vacname from Vaccine WHERE disease LIKE '%COVID-19%'
select price from Vaccine WHERE vacname  like N'%Vắc xin COVID-19 Trung Quốc'

select vac_id from Vaccine WHERE vacname like N'Vắc xin COVID-19 Trung Quốc'

select vac_id from Vaccine WHERE vacname like N'Vắc xin COVID-19 Trung Quốc'

SELECT * FROM Schedule
WHERE vac_id NOT IN (SELECT vac_id FROM Vaccine);

select * from Schedule
WHERE MONTH(injection_date) = 7

select distance_injection
from Vaccine WHERE vac_id = 33

SELECT SCOPE_IDENTITY();

SELECT sche.schedule_id, sche.cus_id, sche.vac_id, vac.vacname,disease, vac.producer, sche.injection_date, sche.province, sche.injection_center, vac.price, vac.num_injection FROM Schedule as sche INNER JOIN Vaccine as vac ON Sche.vac_id = vac.vac_id INNER JOIN Customer as cus ON sche.cus_id = cus.cus_id WHERE sche.cus_id = 052203002761

SELECT COUNT(*) FROM Schedule WHERE injection_date = '2023-11-13' AND cus_id = '052203009876'
SELECT COUNT(*) as count FROM Schedule WHERE injection_date = '2023-12-2'

select * FROM Schedule WHERE cus_id = '052203009876'

select schedule_id from Schedule where cus_id = '052203009876' AND vac_id = 32 AND injection_date = '2023-12-02'

SELECT schedule_id FROM Schedule as sche JOIN Vaccine as vac ON sche.vac_id = sche.vac_id WHERE vacname like N'%Vắc xin COVID-19 Trung Quốc' AND cus_id = '052203009876' AND injection_date = '2023-12-02'
SELECT sche.schedule_id, sche.cus_id, vac.vacname,disease, vac.producer, sche.injection_date, cen.province, cen.center_name, vac.price, vac.num_injection, sche.total FROM Schedule as sche INNER JOIN Vaccine as vac ON Sche.vac_id = vac.vac_id INNER JOIN Customer as cus ON sche.cus_id = cus.cus_id JOIN Centers as cen ON sche.center_id = cen.center_id WHERE sche.cus_id =  052203009876

SELECT schedule_id 
    FROM Schedule 
    WHERE vac_id = 47 AND cus_id = 052203009876 AND center_id = 7;

SELECT COUNT(sche.schedule_id) as count FROM Schedule as sche JOIN Centers as cen ON sche.center_id = cen.center_id WHERE cen.center_name = N'VFA Quy Nhơn'

SELECT SUM(sche.total) as sum FROM Schedule as sche JOIN Centers as cen ON sche.center_id = cen.center_id WHERE cen.center_name = N'VFA Quy Nhơn'

SELECT SUM(total) AS totalRevenue FROM Schedule WHERE MONTH(injection_date) BETWEEN 4 AND 6

SELECT SUM(total) AS TotalRevenue FROM Schedule WHERE injection_date BETWEEN '2023-11-01' AND '2023-12-01'

SELECT * FROM Vaccine WHERE 1=1 AND producer LIKE N'%Bỉ%'

SELECT count(DISTINCT sche.cus_id) FROM Schedule as sche JOIN Customer as cus 
                    ON sche.cus_id = cus.cus_id JOIN Centers as cen 
                   ON sche.center_id = cen.center_id WHERE cen.center_name = N'VFA Quy Nhơn'  OR sche.schedule_id =  2 */

--SELECT * FROM Schedule WHERE cus_id = '052203002761'
--SELECT * FROM IntermediacteCalendar

SELECT count(sche.schedule_id) FROM Schedule as sche JOIN Centers as cen 
                    ON sche.center_id = cen.center_id WHERE cen.center_name = N'VFA Quy Nhơn' OR sche.schedule_id = 3 AND sche.state = 'X'
---------------------------------------------------------------------------------
--DELETE PART

--DELETE FROM Customer WHERE cus_id = 052203005678
--DELETE FROM IntermediacteCalendar WHERE vac_id = 33 And schedule_id = 13 AND injection_date2 = '2024-03-15'

---------------------------------------------------------------------------------
-- DROP PART

/*ALTER TABLE Schedule
DROP CONSTRAINT fk_vaccine;

ALTER TABLE VaccineWarehouse
DROP CONSTRAINT fk_vac_warehouse;

ALTER TABLE Schedule
DROP CONSTRAINT fk_cus_id

ALTER TABLE Schedule
DROP CONSTRAINT fk_vaccine 

ALTER TABLE VaccineWarehouse
DROP CONSTRAINT fk_vac_warehouse

ALTER TABLE Account
DROP CONSTRAINT fk_cus_account 

ALTER TABLE IntermediacteCalendar
DROP CONSTRAINT fk_inter_calendar_vacid

ALTER TABLE IntermediacteCalendar
DROP CONSTRAINT fk_inter_calendar_schduleid 

DROP PROCEDURE InsertVaccinationSchedule

DROP PROC InsertVaccinationSchedule

DROP TABLE IntermediacteCalendar

DROP DATABASE QLTC */

---------------------------------------------------------------------------------
-- CREATE PROCEDURE, FUNCTION
CREATE PROCEDURE InsertVaccinationSchedule
    @cus_id varchar(20),
    @vac_id int,
	@center_id int,
    @injection_date date
AS
BEGIN
    DECLARE @num_injection int;
    DECLARE @distance_injection int;

    -- Get the num_injection and distance_injection values for the specified vaccine
    SELECT @num_injection = num_injection, @distance_injection = distance_injection
    FROM Vaccine
    WHERE vac_id = @vac_id;

    -- Get the schedule_id of the inserted record
    DECLARE @scheduleId int;
    SELECT @scheduleId = schedule_id 
    FROM Schedule 
    WHERE vac_id = @vac_id AND cus_id = @cus_id AND center_id = @center_id;

    -- Calculate and insert injection dates into IntermediacteCalendar table
    DECLARE @i int = 1;
    WHILE @i <= @num_injection
    BEGIN
        DECLARE @dynamicDate date;
        SET @dynamicDate = DATEADD(DAY, (@i - 1) * @distance_injection, @injection_date);

        -- Insert or update into IntermediacteCalendar table using MERGE
        MERGE INTO IntermediacteCalendar AS Target
        USING (VALUES (@scheduleId, @vac_id)) AS Source(schedule_id, vac_id)
        ON Target.schedule_id = Source.schedule_id AND Target.vac_id = Source.vac_id
        WHEN MATCHED THEN
            UPDATE SET
                injection_date1 = CASE WHEN @i = 1 THEN @dynamicDate ELSE injection_date1 END,
                injection_date2 = CASE WHEN @i = 2 THEN @dynamicDate ELSE injection_date2 END,
                injection_date3 = CASE WHEN @i = 3 THEN @dynamicDate ELSE injection_date3 END
        WHEN NOT MATCHED THEN
            INSERT (schedule_id, vac_id, injection_date1, injection_date2, injection_date3)
            VALUES (@scheduleId, @vac_id,
                CASE WHEN @i = 1 THEN @dynamicDate ELSE NULL END,
                CASE WHEN @i = 2 THEN @dynamicDate ELSE NULL END,
                CASE WHEN @i = 3 THEN @dynamicDate ELSE NULL END);

        SET @i = @i + 1;
    END
END

