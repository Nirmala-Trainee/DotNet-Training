create database Mini_Project

use Mini_Project

create table Trains (
    TrainNo int,
    TrainName varchar(100) ,
    Class varchar(50),
    TotalBerths int,
    AvailableBerths int,
    Source varchar(50),
    Destination varchar(50),
    constraint PK_Trains primary key (TrainNo, Class)
);


insert into Trains 
values
(12756, 'Delhi Express', 'First Class', 400, 400, 'Delhi', 'Chennai'),
(12757, 'Bangalore Express', 'Second Class', 300, 300, 'Bangalore', 'Hyderabad');


create table Bookings (
    BookingID int primary key identity,  
    TrainNo int,           
    Class varchar(50) not null ,       
    UserID int ,               
    BookedBerths int ,          
    PassengerName varchar(100),
    PassengerAge int,         
    BookingDate datetime,  
    foreign key (TrainNo, Class) references Trains(TrainNo, Class) 
);


---------- creating procedure for adding train -----------------------

create or alter procedure sp_AddTrain
    @TrainNo int,
    @TrainName varchar(100),
    @Class varchar(50),
    @TotalBerths int,
    @AvailableBerths int,
    @Source varchar(50),
    @Destination varchar(50)
as
begin
    insert into Trains(TrainNo, TrainName, Class, TotalBerths, AvailableBerths, Source, Destination)
    values (@TrainNo, @TrainName, @Class, @TotalBerths, @AvailableBerths, @Source, @Destination);
end

------------------creating procedure for Modifying train Train----------------------------

create or alter procedure sp_ModifyTrain
    @TrainNo int,
    @TrainName varchar(100),
    @TotalBerths int,
    @AvailableBerths int,
    @Source varchar(50),
    @Destination varchar(50)
as
begin
    update Trains
    set TrainName = @TrainName,
        TotalBerths = @TotalBerths,
        AvailableBerths = @AvailableBerths,
        Source = @Source,
        Destination = @Destination
    where TrainNo = @TrainNo;
end

-----------creating procedure for Soft Delete Train----------------------

create or alter procedure sp_DeleteTrain @TrainNo int
as
begin
 update Trains
   set AvailableBerths = 0
   where TrainNo = @TrainNo; 
end
 
------------creating procedure for Booking Tickets-----------------------

create OR alter procedure sp_BookTickets
    @TrainNo int,
    @Class varchar(50),
    @UserID int,
    @BookedBerths int,
    @PassengerName varchar(100),
    @PassengerAge int
as
begin
    declare @AvailableBerths int;
 
    -- Get available berths for the specific train and class
    select @AvailableBerths = AvailableBerths
    from Trains
    where TrainNo = @TrainNo and Class = @Class;
 
    if @AvailableBerths is null
    begin
        print 'Train or class not found.';
    end
 
    if @AvailableBerths >= @BookedBerths
    begin

        insert into Bookings (TrainNo, Class, UserID, BookedBerths, PassengerName, PassengerAge, BookingDate)
        values (@TrainNo, @Class, @UserID, @BookedBerths, @PassengerName, @PassengerAge, getdate());
 
        -- Update available berths
        update Trains
        set AvailableBerths = AvailableBerths - @BookedBerths
        where TrainNo = @TrainNo AND Class = @Class;
    end
    else
    begin
        print 'Not enough berths available.';
    end
end

--------------------Creating procedure for Cancel Booking-----------------

create or alter procedure sp_CancelBooking
    @BookingID int,
    @PassengerName varchar(100)
as
begin
    if EXISTS (
        select 1  from Bookings
        where BookingID = @BookingID AND PassengerName = @PassengerName
    )
   begin
        delete from Bookings
        where BookingID = @BookingID;

        update Trains
        set AvailableBerths = AvailableBerths +
            (select BookedBerths from Bookings
             where BookingID = @BookingID)
        where TrainNo = (select TrainNo from Bookings
                         where BookingID = @BookingID);

        print 'Booking canceled successfully.';
    end
end;
 
--------------------------------------------------------------

 select * from Trains


 select * from Bookings