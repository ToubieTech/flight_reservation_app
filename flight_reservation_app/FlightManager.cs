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
    class FlightManager : DBConnection

    {
        // Check whether flight number exists:
        public bool checkFlight(int flightNumber)
        {
            // Check whether the customer exists:
            string getFlight = "SELECT COUNT(*) FROM flights WHERE flightNum = @getFlightNum";
            try
            {
                MySqlConnection conn = DBConnect();

                MySqlCommand selectCmd = new MySqlCommand(getFlight, conn);

                selectCmd.Parameters.AddWithValue("@getFlightNum", flightNumber);

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

        public bool checkFlightByBooking(int flightNumber)
        {
            // Check whether the customer exists:
            
            string getFlight = "SELECT COUNT(*) FROM flights WHERE flightNum = @getFlightNum AND customerNum = @getCusNum";
            int cusNum = 0;
            try
            {
                MySqlConnection conn = DBConnect();

                MySqlCommand selectCmd = new MySqlCommand(getFlight, conn);

                selectCmd.Parameters.AddWithValue("@getFlightNum", flightNumber);
                selectCmd.Parameters.AddWithValue("@getCusNum", cusNum);

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





        // Method to add a flight:
        public bool addFlight(int flightNumber, string flightOrigin, string flightDestination, string departureDate, string arrivalDate, int maxSeat)
        {
                // Check whether the flight exists:
                int initialCus = 0;
           
                MySqlConnection conn = DBConnect();

                if (!checkFlight(flightNumber))
                {
                    string insertFlight = "INSERT INTO flights VALUES (NULL, @flightNumber, @flightOrigin, @flightDestination, @departureDate, @arrivalDate,  @customerNum, @maxSeat)";

                    MySqlCommand insertCmd2 = new MySqlCommand(insertFlight, conn);
                    insertCmd2.CommandType = System.Data.CommandType.Text;
                    insertCmd2.Parameters.Add("@flightNumber", MySqlDbType.Int32).Value = flightNumber;
                    insertCmd2.Parameters.Add("@flightOrigin", MySqlDbType.VarChar).Value = flightOrigin;
                    insertCmd2.Parameters.Add("@flightDestination", MySqlDbType.VarChar).Value = flightDestination;
                    insertCmd2.Parameters.Add("@departureDate", MySqlDbType.VarChar).Value = departureDate;
                    insertCmd2.Parameters.Add("@arrivalDate", MySqlDbType.VarChar).Value = arrivalDate;
                    insertCmd2.Parameters.Add("@customerNum", MySqlDbType.Int32).Value = initialCus;
                    insertCmd2.Parameters.Add("@maxSeat", MySqlDbType.Int32).Value = maxSeat;

                    insertCmd2.ExecuteNonQuery();
                return true;

            }
                else
                {
                return false;
            }
                

            
        }

        // Method to view all flights:

        public void viewAllFlights(DataGridView dataGridView)
        {
            string selectFlight = "SELECT * FROM flights";

            MySqlConnection connection = DBConnect();
            MySqlCommand cmd = new MySqlCommand(selectFlight, connection);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }


        // Method to view a flights:

        public void viewFlight(DataGridView dataGridView, int flightNum)
        {
            if (checkFlight(flightNum))
            {
                string getFlight = "SELECT flights.flightOrigin, flights.departureDate, flights.arrivalDate, CONCAT(customer.customerFname, ' ', customers.customerLname) AS customerName FROM flights JOIN bookings ON bookings.flightNumber = flights.flightNumber JOIN customers ON customers.customerID = bookings.customerID WHERE flights.flightNumber = @getFlightNumber";

                MySqlConnection connection = DBConnect();
                MySqlCommand cmd = new MySqlCommand(getFlight, connection);

                cmd.Parameters.AddWithValue("@getFlightNumber", flightNum);

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            
        }

        

        // Method to delete a flight:

        public bool deleteFlight(int fNum)
        {
            // Check whether the flight exists:
            
                if (checkFlightByBooking(fNum))
                {
                string delFlight = "DELETE FROM flights WHERE flightNum = @getFlightNumber";
                MySqlConnection conn = DBConnect();
                try
                {
                    MySqlCommand deleteCmd = new MySqlCommand(delFlight, conn);
                    deleteCmd.CommandType = System.Data.CommandType.Text;
                    deleteCmd.Parameters.Add("@getFlightNumber", MySqlDbType.Text).Value = fNum;

                    deleteCmd.ExecuteNonQuery();
                    Console.WriteLine("Flight deleted successfully");
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

            
        }
    }
}
