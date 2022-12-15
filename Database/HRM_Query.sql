USE HRM;

-- show all table
select * from Employee;
select * from WorkTime;
select * from Company;
select * from Department;
select * from Report;
select * from WorkTime;
select * from EmWorktime;

-- create view (show Report for Admin)
go;
Create view v_report as
Select [R].reportID, [E].lastName, [E].middleName, [E].firstName, [D].depName, [R].workContent, [R].createdAt, [R].flag, [E].emID, [E].depID from Employee[E]
inner join Report[R] on [R].emID = [E].emID
inner join Department[D] on [D].depID = [E].depID;


-- create view (show Report for user)
go;
Create view v_report_user as
Select [R].reportID, [E].emID, [R].workContent, [R].createdAt, [R].flag, [D].depID, [D].depName from Employee[E]
inner join Report[R] on [R].emID = [E].emID
inner join Department[D] on [D].depID = [E].depID;
go;

select * from v_report_user where emID = 2;

select reportID, (lastName + middleName +lastName) as 'Employee Name', workContent, flag from v_report where depID = 7 and createdAt between '2000-01-01' and '2050-01-01';


go;
Select [E].firstName,[W].workingTime, [W].currentDate from EmWorktime[EW]
inner join WorkTime[W] on [W].workTimeID= [EW].workTimeID
inner join Employee[E] on [E].emID= [EW].emID
where [E].emID = 1 and [E].flag = 0 and [W].currentDate between (FORMAT(GETDATE()-7, 'yyyy-MM-dd')) and (FORMAT(GETDATE(), 'yyyy-MM-dd'));

Select SUM([W].workingTime) as 'Total time', [W].currentDate from EmWorktime[EW]
inner join WorkTime[W] on [W].workTimeID= [EW].workTimeID
inner join Employee[E] on [E].emID= [EW].emID
where [E].emID = 1 and [E].flag = 0 
group by [W].currentDate; 

Select [D].depName, COUNT([E].emID) as 'Total Department' from Employee[E]
inner join Department[D] on [D].depID = [E].depID
group by [D].depName

Select COUNT(emID), FORMAT(joinDate, 'yyyy') from Employee
group by FORMAT(joinDate, 'yyyy')

