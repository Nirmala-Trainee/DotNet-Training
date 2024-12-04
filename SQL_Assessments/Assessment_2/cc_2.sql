use SQL

--1-------
declare @Birthday date = '2001-03-15'; 
select @Birthday as 'Birthday',
DATENAME(weekday, @Birthday) as 'Day of Week';

----2--------
declare @birthdate date = '2001-03-15'; 
select DATEDIFF(DAY, @birthdate, GETDATE()) as AgeInDays;

-----3-----
select * from EMP
 update EMP set Hiredate='2021-12-04' where Empno=7369; 
  update EMP set Hiredate='2008-12-08' where Empno=7654; 
   update EMP set Hiredate='2001-12-04' where Empno=7782; 
    update EMP set Hiredate='2010-12-18' where Empno=7844; 

	select * from EMP
where year(getdate()) - year(hiredate) > 5
AND MONTH(Hiredate) = MONTH(GETDATE());

-----4-----
create table Employees (
    empno int primary key,
    ename varchar(50),
    sal decimal(10, 2),
    doj date
);

begin transaction
insert into Employees (empno, ename, sal, doj) values (1, 'Swetha', 50000, '2022-01-15');
insert into Employees (empno, ename, sal, doj) values (2, 'Arthi', 60000, '2021-02-20');
insert into Employees (empno, ename, sal, doj) values (3, 'Ramya', 70000, '2020-03-10');


 
 update Employees
set sal = sal * 1.15
where empno = 2;
select * from Employees

delete from Employees
where empno = 1;

rollback
select * from Employees
commit


-----5------
select * from EMP

create function calculateBonus (@Deptno int, @Sal decimal(10, 2))
returns decimal(10, 2)
as
begin
    declare @bonus decimal(10, 2);
    if @Deptno = 10
        set @bonus = @sal * 0.15;
    else if @Deptno = 20
        set @bonus = @sal * 0.20;
    else
        set @bonus = @sal * 0.05;
    return @bonus;
end;

select Empno, Ename, Sal, Deptno,
    dbo.calculateBonus(Deptno, sal) as Bonus
from EMP
   
------6-------------

select * from DEPT

create procedure UpdateSalaryForSales
as
begin
  update EMP
    set Sal = Sal + 500
    where Deptno = (select Deptno from DEPT where Dname = 'Sales') AND Sal < 1500;
end;
  
  Exec UpdateSalaryForSales
  select *from EMP