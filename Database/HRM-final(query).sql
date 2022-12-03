use master
GO

if exists (select * from sys.databases where name = 'HRM')
    drop database HRM
GO


CREATE DATABASE HRM;	
Go
USE HRM;
GO

-- Employee
CREATE TABLE Employee(
	emID int IDENTITY(1,1) NOT NULL,
    depID int NOT NULL,
    comID int NOT NULL,
    username varchar(30) NOT NULL,
    password varchar(30) NOT NULL,
    avatar varchar(30),
    firstName varchar(20),
	middleName varchar(20),
	lastName varchar(20),
	email varchar(50),
    phone varchar(20),
    dateOfBirth date,
    address varchar(50),
	joinDate datetime NOT NULL default current_timestamp,
	
    
    -- user:0 ; admin: 1
    
	role int default 0, 
    
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Employee PRIMARY KEY (emID)
    
);	
	
--Employee working time
CREATE TABLE EmWorktime(
	EmWorktimeID int IDENTITY(1,1) NOT NULL,
	emID int NOT NULL,
	workTimeID int NOT NULL

	CONSTRAINT PK_EmWorktime PRIMARY KEY (EmWorktimeID, emID, workTimeID)
);


-- Working time
CREATE TABLE WorkTime(
	workTimeID int IDENTITY(1,1) NOT NULL,
	emID int NOT NULL,
	workingTime int NOT NULL,
	currentDate datetime NOT NULL default current_timestamp

	CONSTRAINT PK_WorkTime PRIMARY KEY (workTimeID)
);

-- Company
CREATE TABLE Company(
	comID int IDENTITY(1,1) NOT NULL,
    companyName varchar(50),
    address varchar(50),
    taxID varchar(50),
    phone varchar(20),
    email varchar(50),
	createdAt datetime NOT NULL DEFAULT current_timestamp,
     
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Organization PRIMARY KEY (comID)
);

-- Department
CREATE TABLE Department(
	depID int IDENTITY(1,1) NOT NULL,
    depName varchar(max),
    parentID int,
    
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Department PRIMARY KEY (DepID)
);

-- Report
CREATE TABLE Report(
	reportID int IDENTITY(1,1) NOT NULL,
	emID int NOT NULL,
	createdAt datetime default current_timestamp,
    wordContent text,
    jobDetail text,
    note text,    
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Report PRIMARY KEY (reportID)
);


ALTER TABLE Employee
ADD CONSTRAINT FK_Employ_Company FOREIGN KEY (comID) REFERENCES Company(comID),
	CONSTRAINT FK_Employ_Depart FOREIGN KEY (depID) REFERENCES Department(depID);

ALTER TABLE EmWorktime
ADD CONSTRAINT FK_EmWorktime_Em FOREIGN KEY (emID) REFERENCES Employee(emID),
	CONSTRAINT FK_EmWorktime_Wt FOREIGN KEY (workTimeID) REFERENCES WorkTime(workTimeID);

ALTER TABLE Report
ADD	CONSTRAINT FK_Report_Employee FOREIGN KEY (emID) REFERENCES Employee(emID);

ALTER TABLE Employee
ADD CONSTRAINT DF_ComID DEFAULT 1 for comID;

-- insert company
insert into Company(companyName, address, taxID, phone, email)
	values('WorkUp','Hai Ba Trung-Ha Noi','ACD-B1AVPA','0125478888','hkviettan2k3@gmail.com');
		  
-- insert department
insert into Department(depName)
	values ('CEO'),
		   ('Adminstration Department');

-- insert workTime
insert into WorkTime(emID, workingTime)
values(2, 8000);

-- insert employee
insert into Employee(depID ,username, password, firstName, middleName, lastName , role)
VALUES('1','nghia', 'nghia12345', 'Nghia', 'Chinh', 'Nguyen', 1),
	  ('3','TanHoang', 'TanHoang56789', 'Tan', 'Kim Viet', 'Hoang', 1),
	  ('4','PhuongCuong', 'PhuongCuong123', 'Cuong', 'Phuong', 'Phan', 0),
	  ('5','AnhTuan', 'AnhTuan5678', 'Tuan', 'Anh', 'Nguyen', 0),
 	  ('6','VanHung', 'VanHung987', 'Hung', 'Van', 'Pham', 0),
	  ('7','TuanPhong', 'TuanPhong321', 'Phong', 'Tuan', 'Do', 0),
	  ('8','MinhChau', 'MinhChau1122', 'Chau', 'Minh', 'Nguyen', 0),
	  ('3','PhamDung', 'PhamDung567', 'Dung', 'Tri', 'Pham', 0);