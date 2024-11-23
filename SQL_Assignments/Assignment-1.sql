

create database Buisiness_IT


--Moving to database called Buisiness_IT
use Buisiness_IT

  --CLIENTS TABLE
--Creating a table for Clients
create table Clients
(
Client_ID int primary key,
Cname varchar(40) not null,
Address varchar(30) ,
Email varchar(30) unique,
Phone varchar(20) ,
Business  varchar(20) not null
)


--inserting data into Clients table
insert into Clients 
Values(1001,'ACME Utilities','Noida','contact@acmeutil.com','9567880032','Manufacturing'),
      (1002,'Trackon Consultants','Mumbai','consult@trackon.com','8734210090','Consultant'),
	   (1003,'Money Saver Distributors','kolkata','save@moneysaver.com','7799886655','Reseller'),
	   (1004,'lawful Cort','Chennai','justice@lawful.com','9210342219','Professional')

--Displaying Clients table by using select
select * from Clients

--Describing Clients table

sp_help Clients
                                
--EMPLOYEE TABLE
--Creating Employees table

create table Employee
(
Empno int primary key,
Ename varchar(20) not null,
Job varchar(15) ,
Salary int check(Salary>0),   --Using Check Constraint 
Deptno int references Departments(Deptno) ,--Making foreign key using references keyword
)


--inserting data into employees table

 insert into Employee
 values(7001,'sandeep','Analyst',25000,10),
        (7002,'Rajesh','Designer',30000,10),
		(7003,'Madhav','Developer',40000,20),
		(7004,'Manoj','Developer',40000,20),
		(7005,'Abhay','Designer',35000,10),
		(7006,'Uma','Tester',30000,30),
		(7007,'Gita','TechWriter',30000,40),
		(7008,'priya','Tester',35000,30),
		(7009,'Nutan','developer',45000,20),
		(7010,'smitha','Analyst',20000,10),
		(7011,'Anand','projectMgr',65000,10)

--Displaying Employees table

select * from  Employee

--Describing Employee Table

sp_help Employee


 --DEPARTMENTS TABLE
--creating a table called Departments
create table Departments
(
Deptno int primary key,
Dname varchar(15) not null,
Loc varchar(20)
)

--inserting data into departments table

insert into Departments
values(10,'Design','Pune'),
      (20,'Developmenmt','Pune'),
      (30,'Testing','Mumbai'),
      (40,'Document','Mumabi')


--Displaying Departments table

 select *from Departments

--Displaying Complete data of Departments Table

sp_help departments
 
 --PROJECTS TABLE
 
 --creating table Projects

 create table Projects
 (
 Project_ID int primary key,
 Descr  varchar(30)  not null,
 Start_Date date ,
 Planned_End_Date Date ,
 Actual_End_Date date CHECK(Actual_End_date > Planned_End_date ),
 Budget int check(Budget>0),
 Client_ID  int references Clients(Client_ID)
)

--inserting values into Projects table

insert into Projects
values(401,'Inventory','01-Apr-11','01-oct-11','31-oct-11',150000,1001),
      (402,'Accounting','01-Aug-11','01-Jan-11',null,500000,1002),
	  (403,'Payrole','01-Oct-11','01-Dec-11',null,75000,1003),
	  (404,'Contact Mgmt','01-Nov-11','01-Dec-11',null,50000,1004)

-- Displaying projects table

select*from Projects

--Displaying complete information of projects table

sp_help Projects

 --EMPPROJECTSTASKS TABLE

create table EmpProjectTasks
(
Project_ID int primary key  references Projects(Project_ID),
Empno int  references Employee(Empno),
Start_date Date ,
End_date Date,
Task varchar(25) not null,
Status varchar(15) not null

)


--inserting values into EmpProjectTasks

insert into EmpProjectTasks
values(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
       (401,7002,'21-Jun-11','30-May-11','System Design','Completed'),
	   (401,7003,'01-Jul-11','15-Jul-11','Coding','Completed'),
	   (401,7004,'18-Sep-11','01-Sep-11','Coding','Completed'),
	   (401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
	   (401,7009,'18-Oct-11','05-Oct-11','Code Change','Completed'),
	   (401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
	   (401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
	   (401,7011,'22-Aug-11','31-Oct-11','Sign off','Completed'),
	   (402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
	   (402,7007,'22-Apr-11','30-Sep-11',' System Design','Completed'),
	   (402,7002,'01-oct-11',null,'Coding','In Progress')

--Displaying the Emp_Project_tasks

  select * from EmpProjectTasks

--Describing the table

sp_help EmpProjectTasks