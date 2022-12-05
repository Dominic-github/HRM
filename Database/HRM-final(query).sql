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
    avatar varchar(100),
    firstName varchar(20),
	middleName varchar(20),
	lastName varchar(20),
	email varchar(50),
    phone varchar(20),
    dateOfBirth date,
    address varchar(50),
	joinDate date NOT NULL default current_timestamp,
	
    -- male:0 ; female: 1

	gender int default 0,
    
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
	currentDate date NOT NULL default current_timestamp

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
	createdAt date NOT NULL DEFAULT current_timestamp,
     
    -- IsActive:0 ; Deleted: 1

    flag int default 0, 
    
	CONSTRAINT PK_Organization PRIMARY KEY (comID)
);

-- Department
CREATE TABLE Department(
	depID int IDENTITY(1,1) NOT NULL,
    depName varchar(max),  

    -- IsActive:0 ; Deleted: 1

    flag int default 0, 
    
	CONSTRAINT PK_Department PRIMARY KEY (DepID)
);

-- Report
CREATE TABLE Report(
	reportID int IDENTITY(1,1) NOT NULL,
	emID int NOT NULL,
	createdAt date default current_timestamp,
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
insert into Company(companyName, address, taxID, phone, email, createdAt)
VALUES('WorkUp','Hai Ba Trung-Ha Noi','ACD-B1AVPA','0125478888','hkviettan2k3@gmail.com', '2010-10-10');
		  
-- insert department
insert into Department(depName)
VALUES 
	   ('CEO'),
 	   ('Adminstration Department'),
	   ('Technology Department'),
	   ('Accounting Department'),
	   ('Customer Service Department'),
	   ('Finance Department'),
	   ('Personnel Department'),
	   ('Marketing Department');
	   
-- insert workTime
insert into WorkTime(emID, workingTime)
values(2, 8000);

-- insert employee
insert into Employee(depID ,username, password, firstName, middleName, lastName, avatar ,email, phone , dateOfBirth, address, joinDate, gender,role)
VALUES
	  ('1','admin', 'Admin123', 'Tan', 'Kim Viet', 'Hoang', '..\..\..\..\Database\ImageEmployee\admin.jpg','tanhoang@workup.com','0123456789','2003-02-26','Dong Anh-Ha Noi','2015-05-11', 0,1),
	  ('1','nghiadeptrai', 'Nghia12345', 'Nghia', 'Chinh', 'Nguyen','..\..\..\..\Database\ImageEmployee\nghiadeptrai.jpg','nghiadeptrai@workup.com','0333333333','2003-11-28','Ban Ninh','2015-07-03', 0 ,1),
	  ('3','user', 'User12345', 'Dung', 'Viet', 'Pham', '..\..\..\..\Database\ImageEmployee\user.jpg','dungpham@workup.com','09342411589','2003-11-11','Nghe An','2010-01-11',0,0),
	  ('3','tanhoang', 'Tanhoang03', 'Tan', 'Kim Viet', 'Hoang','..\..\..\..\Database\ImageEmployee\tanhoang.jpg','tanhoang@workup.com','0334879873','2004-11-11','Ban Ninh','2014-11-28', 1,0),
	  ('4','phuongcuong', 'PhuongCuong123', 'Cuong', 'Phuong', 'Phan','..\..\..\..\Database\ImageEmployee\phuongcuong.jpg','phuongcuong@workup.com','0922345553','2001-12-03','Ho Chi Minh','2016-08-18', 1,0),
	  ('5','anhtuan', 'AnhTuan123', 'Tuan', 'Anh', 'Nguyen','..\..\..\..\Database\ImageEmployee\anhtuan.jpg','anhtuan@workup.com','09831248867','2002-05-18','Hai Duong','2013-11-12', 1,0),
 	  ('6','vanhung', 'VanHung987', 'Hung', 'Van', 'Pham','..\..\..\..\Database\ImageEmployee\vanhung.jpg','vanhung@workup.com','0733450789','2003-11-11','Thai Nguyen','2015-05-11', 1,0),
	  ('7','tuanphong', 'TuanPhong123', 'Phong', 'Tuan', 'Do','..\..\..\..\Database\ImageEmployee\tuanphong.jpg','tuanphong@workup.com','0677422212','2002-01-27','Lam Dong','2014-07-11', 1,0),
	  ('8','minhchau', 'MinhChau1122', 'Chau', 'Minh', 'Nguyen','..\..\..\..\Database\ImageEmployee\minhchau.jpg','minhchau@workup.com','0767894323','2003-11-30','Kon Tum','2015-11-28', 0,0),
	  ('3','dungnguyen', 'PhamDung567', 'Dung', 'Tri', 'Nguyen', '..\..\..\..\Database\ImageEmployee\dungnguyen.jpg','dungnguyen@workup.com','0866738743','2002-02-11','Bac Giang','2011-04-12',0,0);

