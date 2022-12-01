USE HRM;


INSERT INTO Company(companyName, address, taxID, phone, email)
	VALUES('WorkUp','Hai Ba Trung-Ha Noi','ACD-B1AVPA','0125478888','hkviettan2k3@gmail.com');
		  

insert into Department(depName, parentID)
	values ('CEO', 0),
		   ('Adminstration Department', 1);

insert into WorkTime(emID, workingTime)
values(2, 8000);

insert into employee(depID,username,password, role) 
values('1','Admin', 'Admin123',1),
	  ('2','User','User123',0);



