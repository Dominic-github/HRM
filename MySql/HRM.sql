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
	emID int NOT NULL,
    depID int NOT NULL,
    comID int NOT NULL,
	workTimeID int NOT NULL,
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


ALTER TABLE Employee
ADD 
    CONSTRAINT FK_Employ_Organi FOREIGN KEY (comID) REFERENCES Organization(comID),
	CONSTRAINT FK_Employ_Depart FOREIGN KEY (depID) REFERENCES Structure(depID),
	CONSTRAINT FK_Employ_WorkTime FOREIGN KEY (workTimeID) REFERENCES WorkTime(workTimeID);


	
-- Working time
CREATE TABLE WorkTime(
	workTimeID int NOT NULL,
	emID int NOT NULL,
	workingTime int NOT NULL,
	currentDate datetime NOT NULL default current_timestamp

	CONSTRAINT PK_WorkTime PRIMARY KEY (workTimeID, emID)
);


ALTER TABLE WorkTime
ADD CONSTRAINT FK_WorkTime FOREIGN KEY (emID) REFERENCES Employee(emID);


-- Organization
CREATE TABLE Organization(
	comID int NOT NULL,
    companyName varchar(50),
    address varchar(50),
    taxID varchar(50),
    phone varchar(20),
    email varchar(50),
     
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Organization PRIMARY KEY (comID)
);



ALTER TABLE Organization
ADD createdAt TIMESTAMP NOT NULL DEFAULT current_timestamp;




-- Structure
CREATE TABLE Structure(
	depID int NOT NULL,
    depName varchar(max),
    parentID int,
    
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Structure PRIMARY KEY (DepID)
);



-- Report
CREATE TABLE Report(
	reportID int NOT NULL,
	emID int NOT NULL,
	createdAt datetime default current_timestamp,
    wordContent text,
    jobDetail text,
    note text,    
    -- IsActive:0 ; Deleted: 1
    
    flag int default 0, 
    
	CONSTRAINT PK_Report PRIMARY KEY (reportID)
);


ALTER TABLE Report
ADD	CONSTRAINT FK_Report_Emplot FOREIGN KEY (emID) REFERENCES Employee(emID);


