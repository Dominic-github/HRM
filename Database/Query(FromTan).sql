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
    avatar varchar(50),
    firstName varchar(20),
	middleName varchar(20),
	lastName varchar(20),
	email varchar(50),
    phone varchar(20),
    dateOfBirth date,
    address varchar(50),
	joinDate date NOT NULL default current_timestamp,
	
    
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


-- Insert Value
INSERT INTO Company(companyName, address, taxID, phone, email)
	VALUES('WorkUp','Hai Ba Trung-Ha Noi','ACD-B1AVPA','0125478888','hkviettan2k3@gmail.com');
		  

insert into Department(depName)
values 		('CEO'),
		   ('Adminstration Department'),
		   ('HR Department'),
		   ('Technical Department'),
		   ('Finace Department'),
		   ('Support Department');

insert into WorkTime(emID, workingTime)
values(2, 8000);

insert into Employee(depID ,username, password, firstName, middleName, lastName , role)
VALUES
('1','admin', 'Admin123', 'Nghia', 'Chinh', 'Nguyen', 1),
('2','admin1', 'Admin123', 'Viet', 'Kim', 'Hoang', 1),
('3','User1', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('2','User2', 'User12345', 'Tan', 'Kim Viet', 'Hoang', 0),
('2','User3', 'User12345', 'Phong', 'Tuan', 'Nguyen', 0),
('2','User4', 'User12345', 'Cuong', 'Phuong', 'Phan', 0),
('3','User5', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('3','User6', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('3','User7', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('4','User8', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('4','User9', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('3','User10', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('4','User11', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0),
('4','User12', 'User12345', 'Nghia', 'Chinh', 'Nguyen', 0);

