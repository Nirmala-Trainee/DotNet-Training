---multistatement table valued

create or alter function fn_GetEmpByGender (@gen varchar(8))
returns
@EmpByGender table(
EmpId int, EmployeeName varchar(40),Gender varchar(8))
as
begin
----bulk insertion
insert into @EmpByGender
select empid,empname,gender from tblEmployee where gender = @gen
----handle exception
  if @@ROWCOUNT = 0
    begin
    insert into @EmpByGender values(0,'No emp found with the given gender',null)
  end
 return
 end

 --to execute the above function
 select * from dbo.fn_Getempbygender('female')

 select * from @empbygender


 use SQL

----views
create view vwEmpData
as select Empno, Sal from EMP

select * from EMP
select * from DEPT

--triggers

create trigger tgrEmpIns
on EMP
for insert
as
begin
select * from inserted
select * from EMP
end

insert into EMP values(3000,'HARSHA','Clerk',4352,'1980-11-23',600,2000,10)

create or alter trigger trgEmpDel
on EMP
for delete
as
begin
select *from deleted
end

delete from EMP where Empno 

drop trigger trgEmpDel

--------
create or alter trigger trgAuditInsert
on DEPT
for insert
as
begin
declare @id int
select @id =Deptno from inserted

insert into auditlogs
values('New Department with Depno' + ' ' + cast(@id as varchar(5))+ 'is added at'
+ cast(getdate() as varchar(20)))
end

insert into DEPT values(50,'Development','Vizag')

/*add a column AuditDate date to that auditlogs table
write a trigger for updation of tblemployee*/
