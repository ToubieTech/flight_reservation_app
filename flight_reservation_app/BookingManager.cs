using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace flight_reservation_app
{
    class BookingManager : DBConnection
    {
        // Check booking: 

        public bool checkBooking(int bookingNumber)
        {
            string getBooking = "SELECT COUNT(*) FROM bookings WHERE bookingNum = @getBookingNum";
            try
            {
                MySqlConnection conn = DBConnect();
                MySqlCommand selectCmd = new MySqlCommand(getBooking, conn);

                selectCmd.Parameters.AddWithValue("@getBookingNum", bookingNumber);

                object obj = selectCmd.ExecuteScalar();

                if (Convert.ToInt32(obj) != 0)
                {
                    return true;
                }
                return false;
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool checkBookingByCustomer(int cusID)
        {
            string getCus = "SELECT COUNT(*) FROM customers WHERE customerID = @getCustomerID";
            try
            {
                MySqlConnection conn = DBConnect();
                MySqlCommand selectCmd = new MySqlCommand(getCus, conn);

                selectCmd.Parameters.AddWithValue("@getCustomerID", cusID);

                object obj = selectCmd.ExecuteScalar();

                if (Convert.ToInt32(obj) != 0)
                {
                    return true;
                }
                return false;
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool checkBookingByFlight(int flightNumber)
        {
            string getFlight = "SELECT COUNT(*) FROM flights WHERE flightNum = @getFlightID";
            string getFlightSeat = "SELECT COUNT(*) FROM flights WHERE customerNum = maximumSeat";
            try
            {
                MySqlConnection conn = DBConnect();
                MySqlCommand selectCmd = new MySqlCommand(getFlight, conn);
                MySqlCommand selectCmd2 = new MySqlCommand(getFlightSeat, conn);

                selectCmd.Parameters.AddWithValue("@getFlightID", flightNumber);

                object obj = selectCmd.ExecuteScalar();
                object obj2 = selectCmd.ExecuteScalar();

                if (Convert.ToInt32(obj) != 0 && Convert.ToInt32(obj2) != 0)
                {
                    return true;
                }
                return false;
            }

            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        // Add Booking:
        public bool addBooking(int cusID, int flightNum, int bookingNumber)
        {
            string bookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            try
            {
                MySqlConnection conn = DBConnect();

                if (checkBooking(bookingNumber) || !checkBookingByCustomer(cusID) || !checkBookingByFlight(flightNum))
                {
                    return false;
                }
                else
                {
                    string insertBooking = "INSERT INTO bookings VALUES (NULL, @bookingDate, @bookingNum, @customerID, @flightNum)";

                    MySqlCommand insertCmd = new MySqlCommand(insertBooking, conn);
                    insertCmd.CommandType = System.Data.CommandType.Text;
                    insertCmd.Parameters.Add("@bookingDate", MySqlDbType.VarChar).Value = bookingDate;
                    insertCmd.Parameters.Add("@bookingNum", MySqlDbType.Int32).Value = bookingNumber;
                    insertCmd.Parameters.Add("@customerID", MySqlDbType.Int32).Value = cusID;
                    insertCmd.Parameters.Add("@flightNum", MySqlDbType.Int32).Value = flightNum;

                    insertCmd.ExecuteNonQuery();

                    // Update number of customers in the flight:
                    string updateCus = "UPDATE flights SET customerNum = customerNum + @cusNum WHERE flightNum = @flightNum";

                    try
                    {
                        MySqlCommand updateCmd = new MySqlCommand(updateCus, conn);
                        updateCmd.CommandType = System.Data.CommandType.Text;
                        updateCmd.Parameters.Add("@flightNum", MySqlDbType.Int32).Value = flightNum;
                        updateCmd.Parameters.Add("@cusNum", MySqlDbType.Int32).Value = 1;

                        updateCmd.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    // Update number of customers in the flight:
                    string updateBook = "UPDATE customers SET customerBookings = customerBookings + @cusNum WHERE customerID = @cusID";

                    try
                    {
                        MySqlCommand updateCmd2 = new MySqlCommand(updateBook, conn);
                        updateCmd2.CommandType = System.Data.CommandType.Text;
                        updateCmd2.Parameters.Add("@cusNum", MySqlDbType.Int32).Value = 1;
                        updateCmd2.Parameters.Add("@cusID", MySqlDbType.Int32).Value = cusID;

                        updateCmd2.ExecuteNonQuery();

                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    return true;
                }
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        // View Bookings:
        public void  viewBookings(DataGridView dataGridView)
        {
            string selectBooking = "SELECT bookings.bookingDate, bookings.bookingNum, CONCAT(customers.customerFname, ' ', customers.customerLname) AS customerName, bookings.flightNum from bookings INNER JOIN customers ON bookings.customerID = customers.customerID";

            MySqlConnection connection = DBConnect();
            MySqlCommand cmd = new MySqlCommand(selectBooking, connection);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
