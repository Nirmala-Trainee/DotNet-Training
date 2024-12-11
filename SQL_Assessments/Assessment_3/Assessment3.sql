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

select dbo.CalCourse_Duration('2018-02-01', '2018-02-28') as Course_Duration ;


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

create table Products_Details (
    ProductId int identity(1,1) primary key,
    ProductName varchar(30),
    Price float not null,
    DiscountedPrice float
);

create procedure Insert_Products
    @ProductName varchar(100),
    @Price float
as
begin
    declare @ProductId int;
    declare @DiscountedPrice float;

    set @DiscountedPrice = @Price - (@Price * 0.10);
 
    insert into Products_Details(ProductName, Price, DiscountedPrice)
    values (@ProductName, @Price, @DiscountedPrice);

    set @ProductId = SCOPE_IDENTITY();

    select @ProductId as ProductId, @DiscountedPrice as DiscountedPrice;
end;

exec Insert_Products @ProductName = 'Test Product', @Price = 10000;

select * from Products_Details