USE HRM;

-- show all table
select * from Employee;
select * from WorkTime;
select * from Company;
select * from Department;
select * from Report;

-- create view (show Report for Admin)
go;
Create view v_report as
Select [R].reportID, [E].lastName, [E].middleName, [E].firstName, [D].depName, [R].wordContent, [R].createdAt, [R].flag, [E].emID, [E].depID from Employee[E]
inner join Report[R] on [R].emID = [E].emID
inner join Department[D] on [D].depID = [E].depID;


-- create view (show Report for user)
go;
Create view v_report_user as
Select [R].reportID, [E].emID, [R].wordContent, [R].createdAt, [R].flag, [D].depID, [D].depName from Employee[E]
inner join Report[R] on [R].emID = [E].emID
inner join Department[D] on [D].depID = [E].depID;
go;

select * from v_report_user where emID = 2;

select reportID, (lastName + middleName +lastName) as 'Employee Name', wordContent, flag from v_report where depID = 7 and createdAt between '2000-01-01' and '2050-01-01';