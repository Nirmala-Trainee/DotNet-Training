using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrainReservationSystem
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static IDataReader dr;

        static void Main()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                AdminMenu();
            }
            else if (choice == 2)
            {
                UserMenu();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Exiting the program...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice.......");
                Environment.Exit(0);
            }

            Console.Read();
        }
        static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-APHM8AE;Initial Catalog=Mini_Project;Integrated Security=true;");
            con.Open();
            return con;
        }

        static void AdminMenu()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Add Trains");
            Console.WriteLine("2. Modify Trains");
            Console.WriteLine("3. Delete Trains");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddTrain(); break;
                case 2: ModifyTrain(); break;
                case 3: DeleteTrain(); break;
                case 4: return;
            }
        }

        static void UserMenu()
        {
            Console.WriteLine("User Menu:");
            Console.WriteLine("1. Book Tickets");
            Console.WriteLine("2. Cancel Tickets");
            Console.WriteLine("3. Show All Trains");
            Console.WriteLine("4. Show Bookings");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: BookTickets(); break;
                case 2: CancelBooking(); break;
                case 3: ShowAllTrains(); break;
                case 4: ShowBookings(); break;
                case 5: return;
            }
        }

        static void AddTrain()
        {
            con = GetConnection();

            Console.WriteLine("Enter Train Details:");
            Console.WriteLine("TrainNo: ");
            int trainNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TrainName: ");
            string trainName = Console.ReadLine();

            Console.WriteLine("Class (e.g., Sleeper, AC, First Class): ");
            string trainClass = Console.ReadLine();

            Console.WriteLine("Total Berths: ");
            int totalBerths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Available Berths: ");
            int availableBerths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Source: ");
            string source = Console.ReadLine();

            Console.WriteLine("Destination: ");
            string destination = Console.ReadLine();

            cmd = new SqlCommand("sp_AddTrain", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            cmd.Parameters.AddWithValue("@TrainName", trainName);
            cmd.Parameters.AddWithValue("@Class", trainClass);
            cmd.Parameters.AddWithValue("@TotalBerths", totalBerths);
            cmd.Parameters.AddWithValue("@AvailableBerths", availableBerths);
            cmd.Parameters.AddWithValue("@Source", source);
            cmd.Parameters.AddWithValue("@Destination", destination);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Train added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add the train. Check your details or it may already exist.");
            }

            con.Close();
        }

        static void ModifyTrain()
        {
            con = GetConnection();
            Console.WriteLine("Enter TrainNo to modify: ");
            int trainNo = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("SELECT COUNT(*) FROM Trains WHERE TrainNo = @TrainNo", con);
            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                Console.WriteLine("Train not found. Cannot modify a train.");
            }
            else
            {
                Console.WriteLine("Enter new details: TrainName, TotalBerths, AvailableBerths, Source, Destination");
                string trainName = Console.ReadLine();
                int totalBerths = Convert.ToInt32(Console.ReadLine());
                int availableBerths = Convert.ToInt32(Console.ReadLine());
                string source = Console.ReadLine();
                string destination = Console.ReadLine();


                cmd = new SqlCommand("sp_ModifyTrain", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                cmd.Parameters.AddWithValue("@TrainName", trainName);
                cmd.Parameters.AddWithValue("@TotalBerths", totalBerths);
                cmd.Parameters.AddWithValue("@AvailableBerths", availableBerths);
                cmd.Parameters.AddWithValue("@Source", source);
                cmd.Parameters.AddWithValue("@Destination", destination);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Train modified successfully.");
            }
            con.Close();
        }

        static void DeleteTrain()
        {
            con = GetConnection();
            Console.WriteLine("Enter TrainNo to delete:");
            int trainNo = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("SELECT COUNT(*) FROM Trains WHERE TrainNo = @TrainNo", con);
            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                Console.WriteLine("Train not found. You Cannot delete a train.");
            }
            else
            {
                cmd = new SqlCommand("sp_DeleteTrain", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainNo", trainNo);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Train deleted successfully.");
            }
            con.Close();
        }

        static void BookTickets()
        {
            con = GetConnection();

            Console.WriteLine("Enter Train No:");
            int trainNo = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("SELECT COUNT(*) FROM Trains WHERE TrainNo = @TrainNo", con);
            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                Console.WriteLine("Train not found. Please check the Train No entered.");
                con.Close();
                return;
            }

            cmd = new SqlCommand("select DISTINCT Class FROM Trains WHERE TrainNo = @TrainNo", con);
            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Available classes for the selected train:");
            while (dr.Read())
            {
                Console.WriteLine(dr["Class"].ToString());
            }
            dr.Close();

            Console.WriteLine("Enter Class you want to book:");
            string trainClass = Console.ReadLine();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Trains WHERE TrainNo = @TrainNo AND Class = @Class", con);
            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            cmd.Parameters.AddWithValue("@Class", trainClass);
            int classCount = Convert.ToInt32(cmd.ExecuteScalar());

            if (classCount == 0)
            {
                Console.WriteLine("The selected class is not available for the specified train.");
                con.Close();
                return;
            }


            Console.WriteLine("Enter the number of berths to book:");
            int bookedBerths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User ID:");
            int userID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Passenger Name:");
            string passengerName = Console.ReadLine();
            Console.WriteLine("Enter Passenger Age:");
            int passengerAge = Convert.ToInt32(Console.ReadLine());

            // Call the stored procedure to book the tickets
            cmd = new SqlCommand("sp_BookTickets", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrainNo", trainNo);
            cmd.Parameters.AddWithValue("@Class", trainClass);
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@BookedBerths", bookedBerths);
            cmd.Parameters.AddWithValue("@PassengerName", passengerName);
            cmd.Parameters.AddWithValue("@PassengerAge", passengerAge);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Tickets booked successfully.");
            }
            else
            {
                Console.WriteLine("Failed to book tickets. Please check the availability.");
            }

            con.Close();
        }

        static void CancelBooking()
        {
            con = GetConnection();

            Console.WriteLine("Enter Booking ID to cancel:");
            int bookingID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Passenger Name:");
            string passengerName = Console.ReadLine();

            cmd = new SqlCommand("SELECT COUNT(*) FROM Bookings WHERE BookingID = @BookingID AND PassengerName = @PassengerName", con);
            cmd.Parameters.AddWithValue("@BookingID", bookingID);
            cmd.Parameters.AddWithValue("@PassengerName", passengerName);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                Console.WriteLine("Booking not found. Please check the Booking ID and Passenger Name entered.");
            }
            else
            {
                cmd = new SqlCommand("sp_CancelBooking", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookingID", bookingID);
                cmd.Parameters.AddWithValue("@PassengerName", passengerName);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Booking canceled successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to cancel booking. Please try again.");
                }
            }

            con.Close();
        }


        static void ShowAllTrains()
        {
            con = GetConnection();
            cmd = new SqlCommand("SELECT * FROM Trains", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"Train No: {dr[0]}, Train Name: {dr[1]}, Class: {dr[2]}, Available Berths: {dr[4]}, Source: {dr[5]}, Destination: {dr[6]}");
            }
            con.Close();
        }

        static void ShowBookings()
        {
            con = GetConnection();
            Console.WriteLine("Enter User ID to view bookings:");
            int userID = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("SELECT * FROM Bookings WHERE UserID = @UserID", con);
            cmd.Parameters.AddWithValue("@UserID", userID);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"Booking ID: {dr[0]}, Train No: {dr[1]}, Booked Berths: {dr[3]}, PassengerName: {dr[5]}, Booking Date: {dr[7]}");
            }
            con.Close();
        }
    }
}
