USE HRM;


INSERT INTO Company(companyName, address, taxID, phone, email)
	VALUES('WorkUp','Hai Ba Trung-Ha Noi','ACD-B1AVPA','0125478888','hkviettan2k3@gmail.com');
		  

<<<<<<< Updated upstream
insert into Department(depName)
	values ('CEO'),
		   ('Adminstration Department');
=======
insert into Department(depName, parentID)
	values ('CEO', 0),
		   ('Adminstration Department', 1),
		   ('HR Department', 2),
		   ('Technical Department', 3),
		   ('Finace Department', 4),
		   ('Support Department', 5);
>>>>>>> Stashed changes

insert into WorkTime(emID, workingTime)
values(2, 8000);

insert into Employee(depID ,username, password, firstName, middleName, lastName , role)
VALUES
('3','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('4','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('5','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('6','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('7','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('8','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('9','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('10','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('11','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('12','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('13','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0),
('14','User1', 'Useruser', 'Nghia', 'Chinh', 'Nguyen', 0);

update Employee set password = 'User1234' where emID = 4;

insert into Department(depName)
values ('Technology Department'),
	   ('Accounting Department'),
	   ('Customer Service Department'),
	   ('Finance Department'),
	   ('Personnel Department'),
	   ('Marketing Department');


insert into WorkTime(emID, workingTime)
values(2, 8000);

select * from Employee;

insert into Employee(depID ,username, password, firstName, middleName, lastName , role)
VALUES('1','nghia', 'nghia12345', 'Nghia', 'Chinh', 'Nguyen', 1),
	  ('3','TanHoang', 'TanHoang56789', 'Tan', 'Kim Viet', 'Hoang', 1),
	  ('4','PhuongCuong', 'PhuongCuong123', 'Cuong', 'Phuong', 'Phan', 0),
	  ('5','AnhTuan', 'AnhTuan5678', 'Tuan', 'Anh', 'Nguyen', 0),
 	  ('6','VanHung', 'VanHung987', 'Hung', 'Van', 'Pham', 0),
	  ('7','TuanPhong', 'TuanPhong321', 'Phong', 'Tuan', 'Do', 0),
	  ('8','MinhChau', 'MinhChau1122', 'Chau', 'Minh', 'Nguyen', 0),
	  ('3','PhamDung', 'PhamDung567', 'Dung', 'Tri', 'Pham', 0);

