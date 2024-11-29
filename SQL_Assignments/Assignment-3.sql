use SQL

select * from EMP
select * from DEPT

-------1. Retrieve a list of MANAGERS.---------
select * from EMP
where job='manager'

-----2. Names and salaries of all employees earning more than 1000 per month-------
select Ename,Sal from EMP
where Sal>1000

-----3.Names and salaries of all employees except JAMES---------
select Ename,Sal from EMP
where Ename!='james'

------4. Details of employees whose names begin with ‘S’-----
select Empno,Ename,job,Mgr_id,Hiredate,Sal,Comm,Deptno from EMP 
where Ename like 's%'

-----5. Names of all employees that have ‘A’ anywhere in their name---------
select Ename from EMP 
where Ename like '%a%'

----6. Names of all employees that have ‘L’ as their third character in their name-----
select Ename from EMP
where Ename like '__l%'

-----7. salary of JONES-------
select Ename, round(sal /30,2) as 'Day Salary' 
from EMP  
where Ename='james'

-----8. Total monthly salary of all employees------
select sum (distinct Sal) as "Total Salary"
from EMP

-----9. Average annual salary--------
select avg(Sal*12) as "Annual_Salary" 
from EMP

-----10------
select Ename,job,Sal,Deptno from EMP 
where not( Deptno=30 and job='salesman')

-----11.Unique departments of the EMP table------
select distinct Deptno from EMP

------12--------
select Ename as' Employee',
Sal as 'Monthlysalary' from EMP 
where Sal>1500 and (Deptno=10 or Deptno=30)

-----13.Name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.-------

select Ename,job,Sal from EMP 
where (job='manager' or job='analyst') and Sal not in (1000,3000,5000)

----14.Name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%------

select Ename,Sal,Comm from EMP 
where Comm>Sal*1.1

-----15--------------------------
select Ename from EMP
where (Ename like '%l%l%' and (Deptno=30 or Mgr_id=7782))

----------16---------------------
select Ename from EMP
where datediff(year,Hiredate,getdate())between 30 and 40
select count(Empno) from EMP 
where datediff(year,Hiredate,getdate())between 30 and 40

------------17--------------------
select DEPT.Dname,EMP.Ename from EMP
join DEPT on EMP.Deptno = DEPT.Deptno
order by DEPT.Dname asc, EMP.Ename desc

--------18. experience of MILLER---------------------------
select Ename,datediff(year,Hiredate,getdate()) as 'Experience'
from EMP
where Ename='miller'


