USE HRM;

-- show all table
select * from Employee;
select * from WorkTime;
select * from Company;
select * from Department;
select * from Report;
select * from WorkTime;
select * from EmpWorktime;


select reportID, (lastName + middleName +lastName) as 'Employee Name', workContent, flag from v_report where depID = 7 and createdAt between '2000-01-01' and '2050-01-01';


go
Select [E].firstName,[W].workingTime, [W].currentDate from EmpWorktime[EW]
inner join WorkTime[W] on [W].workTimeID= [EW].workTimeID
inner join Employee[E] on [E].emID= [EW].emID
where [E].emID = 1 and [E].flag = 0 and [W].currentDate between '2022-12-14' and '2022-12-14';

Select [W].workTimeID, SUM([W].workingTime) as 'Total time', [W].currentDate from EmpWorktime[EW]
inner join WorkTime[W] on [W].workTimeID= [EW].workTimeID
inner join Employee[E] on [E].emID= [EW].emID
where [E].emID = 1 and [E].flag = 0 
group by [W].workTimeID, [W].currentDate;


Select WorkTime.workTimeID, SUM(WorkTime.workingTime) as 'Total time', WorkTime.currentDate from EmpWorktime
inner join WorkTime on WorkTime.workTimeID= EmpWorktime.workTimeID
inner join Employee on Employee.emID= EmpWorktime.emID
where Employee.emID = 1 and Employee.flag = 0 
group by WorkTime.workTimeID, WorkTime.currentDate ORDER by WorkTime.currentDate ASC;

Select Department.depName, COUNT(Employee.emID) as 'Total Department' from Employee
inner join Department on Department.depID = Employee.depID
group by Department.depName

Select COUNT(emID), FORMAT(joinDate, 'yyyy') from Employee
group by FORMAT(joinDate, 'yyyy') order by  FORMAT(joinDate, 'yyyy') ASC;

