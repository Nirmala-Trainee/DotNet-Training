create database assessment_2

use assessment_2

create table books
(
ID int primary key ,
Title varchar(100) not null,
Author varchar(100) not null,
Isbn varchar(15) unique,
Published_date datetime NOT NULL
);

insert into books 
values
    (1,'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
    (2,'My Second SQL book', 'John Mayer', '8573000923713', '1972-07-03 09:22:45'),
    (3,'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');

create table reviews (
    id int Primary key,
    book_id int NOT NULL,
    reviewer_name varchar(100) NOT NULL,
    content text,
    rating int check (rating BETWEEN 1 AND 5),
    published_date datetime NOT NULL,
    foreign key (book_id) REFERENCES books(id) ON DELETE CASCADE
);

insert into reviews
values(1, 1,'John Smith','My first review',4,'2017-12-10 05:50:11.1'),
	  (2, 2,'John Smith','My second review',5,'2017-10-13 15:05:12.6'),
	  (3, 3,'Alice walker','Another review',1,'2017-10-22 23:47:10');

--1 
select * from books
where author LIKE '%er';

--2
select b.title, b.author, r.reviewer_name
from books b
JOIN reviews r on b.id = r.book_id;

--3
select reviewer_name
from reviews
group by reviewer_name
having COUNT(DISTINCT book_id) > 1;

--creating table for Customers
create table CUSTOMER (
    Id int,
    Name VARCHAR(50),
    Age int,
    Address VARCHAR(100),
    Salary DECIMAL(10, 2)
);
 
-- Insert values into customer table
insert into CUSTOMER 
values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);

-- Create table for orders
create table ORDERS (
    OId int,
    Date DATETIME,
    Customer_id int,
    Amout DECIMAL(10, 2)
);
 
-- Insert values into ORDERS table
insert into ORDERS 
values
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 2500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060);

--creating table for Employee
create table EMPLOYEE (
    Id int,
    Name VARCHAR(50),
    Age int,
    Address VARCHAR(100),
    Salary DECIMAL(10, 2)
);
 
-- Insert values into Employee table
insert into  EMPLOYEE 
values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', null),
(7, 'Muffy', 24, 'Indore', null);


--creating table for student details
create table Student_details
(
Register_no int primary key,
Name varchar(30) not null,
Age int not null,
Qualification varchar(20),
Mobile_no float not null,
Mail_id varchar(30),
locationn varchar(30),
Gender varchar(1)
)

--inserting values
insert into Student_details values
(2,'Sai',22,'B.E',9952836779,'sai@gmail.com','Chennai','M'),
(3,'Kumar',20,'BSC',7252836779,'kumar@gmail.com','Madurai','M'),
(4,'Selvi',22,'B.TECH',8952836779,'selvi@gmail.com','Selam','F'),
(5,'Nisha',25,'M.E',6352836779,'nisha@gmail.com','Theni','F'),
(6,'SaiSaran',21,'B.A',9865836779,'saran@gmail.com','Madurai','F'),
(7,'Tom',23,'BCA',6552836779,'tom@gmail.com','Pune','M')

--4
SELECT Name
FROM CUSTOMER
WHERE Address LIKE '%o%';

--5
select date, COUNT(CUSTOMER_ID) AS TotalCustomers 
from Orders group by Date;

--6
select LOWER(name) AS employee_name
from EMPLOYEE 
where salary IS NULL;

--7
select Gender,count(*) as Total_count 
from Student_details 
group by Gender 