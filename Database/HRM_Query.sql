USE HRM;


INSERT INTO Company(companyName, address, taxID, phone, email)
	VALUES('WorkUp','Hai Ba Trung-Ha Noi','ACD-B1AVPA','0125478888','hkviettan2k3@gmail.com');
		  

insert into Department(depName)
	values ('CEO'),
		   ('Adminstration Department');

insert into WorkTime(emID, workingTime)
values(2, 8000);

insert into employee(depID,username,password, role) 
values('1','Admin', 'Admin123',1),
	  ('2','User','User123',0);

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

