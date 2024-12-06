use SQL
select * from EMP
----------------1--------------------------
create or alter proc PaySlip(@EmpId int)
as
begin
declare @Ename varchar(20),@Sal int
declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @Deduction float
declare @Gross_Salary float
declare @Net_Salary float
 
select @Ename=Ename,@Sal=Sal from EMP where Empno=@EmpId
 
set @HRA=@sal*0.10
set @DA=@sal*0.20
set @PF=@sal*0.08
set @IT=@sal*0.05
set @Deduction=@PF+@IT
set @Gross_Salary=@sal+@HRA+@DA
set @Net_Salary=@Gross_Salary-@Deduction
 
print 'Payslip for Employee : ' +@Ename
print 'Basic Salary : '+cast(@Sal as varchar(10))
print 'HRA : ' +cast(@HRA as varchar(10))
print 'DA : ' +cast(@DA as varchar(10))
print 'PF : ' +cast(@PF as varchar(10))
print 'IT : ' +cast(@IT as varchar(10))
print 'Deduction : ' +cast(@Deduction as varchar(10))
print 'Gross salary : ' +cast(@Gross_Salary as varchar(10))
print 'Net salary : ' +cast(@Net_Salary as varchar(10))
end
 
exec PaySlip 7521

-----------------------2---------------------------------------

create table Holidays (
    holiday_date date primary key,
    holiday_name varchar(20) NOT NULL
);

insert into Holidays (holiday_date, holiday_name) values
('2024-01-26', 'Republic Day'),
('2024-03-29', 'Holi'),
('2024-08-15', 'Independence Day'),
('2024-11-12', 'Diwali');
insert into holidays values('2024-12-06','Holiday');

create or alter trigger RestrictManipulationOnHolidays
ON EMP
for insert,update,delete
as
begin
    declare @holiday_name varchar(20);
	declare @current_date date = cast(getdate() as date)
    select @holiday_name =holiday_name
    from Holidays
    where holiday_date = @current_date;
    if @holiday_name IS NOT NULL
	begin
        raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
		rollback transaction
    end
end

update EMP set Sal=1000 where EmpNo=7521
select * from EMP
