use SQL

create table Course_Details (
    C_id varchar(5) primary key,
    C_Name varchar(50),
    Start_date date,
    End_date date,
    Fee int
);

insert into Course_Details
values ('DN003', 'Dot Net', '2018-02-01', '2018-02-28', 15000),
	   ('DV004', 'Data Visualization', '2018-03-01', '2018-04-15', 15000),
	   ('JA002', 'AdvancedJava', '2018-01-02', '2018-01-20', 10000),
	   ('JC001', 'CoreJava', '2018-01-02', '2018-01-12', 3000);

-------------------1------------------------
create function CalCourse_Duration(@Start_date date, @End_date date)
returns int
as
begin
    return DATEDIFF(day, @Start_date, @End_date);
end;

select C_id, C_Name, Start_date, End_date, DATEDIFF(day, Start_date, End_date) as DurationInDays from Course_Details


--------------------2-------------------------------

create table T_CourseInfo (
    Course_Name varchar(30),
    StartDate date
);

create trigger trg_InsertCourseInfo on Course_Details
after insert
as
begin
    insert into T_CourseInfo (Course_Name, StartDate)
    select C_Name, Start_date
    from inserted;
end;

insert into Course_Details 
values ('PY007', 'Python Programming', '2024-01-01', '2024-01-31', 25000);
	   
select * from T_CourseInfo;

------------------------3-------------------------------

create table ProductDetails
(
Product_id int identity(1,1),
Product_Name varchar(30),
Price float,
Discount_Price as (Price * 0.10)
)
create procedure sp_productsdetails
@Product_Id int,
@Product_name varchar(30),
@Price float,
@Discount_price float
as
Begin 
insert into ProductDetails(Product_Name, Price)values(@Product_name, @Price);
set @Product_Id=SCOPE_IDENTITY();
end
 
select * from ProductDetails;
