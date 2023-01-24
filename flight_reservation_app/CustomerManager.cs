using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace flight_reservation_app
{
    class CustomerManager : DBConnection
    {


        // Method to check whether a customer exists:
        public bool checkCustomer(string cusFname, string cusLname, string cusPhone)
        {
            // Check whether the customer exists:
            string getCustomer = "SELECT COUNT(*) FROM customers WHERE customerFname = @getFname AND customerLname = @getLname AND customerPhone = @getPhone";
            try
            {
                MySqlConnection conn = DBConnect();

                MySqlCommand selectCmd = new MySqlCommand(getCustomer, conn);

                selectCmd.Parameters.AddWithValue("@getFname", cusFname);
                selectCmd.Parameters.AddWithValue("@getLname", cusLname);
                selectCmd.Parameters.AddWithValue("@getPhone", cusPhone);

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

        // Method to check whether a customer exists by ID:
        public bool checkCustomer(int cusID)
        {
            // Check whether the customer exists:
            string getCustomer = "SELECT COUNT(*) FROM customers WHERE customerID = @getID";
            try
            {
                MySqlConnection conn = DBConnect();

                MySqlCommand selectCmd = new MySqlCommand(getCustomer, conn);

                selectCmd.Parameters.AddWithValue("@getID", cusID);

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

        // Method to check whether a customer exists by customer booking:
        public bool checkCustomerByBooking(int cusBooking)
        {
            // Check whether the customer exists:
            string getCustomer = "SELECT COUNT(*) FROM customers WHERE customerBookings = @getCusBooking";
            int checkBooking = 0;
            try
            {
                MySqlConnection conn = DBConnect();

                MySqlCommand selectCmd = new MySqlCommand(getCustomer, conn);

                selectCmd.Parameters.AddWithValue("@getCusBooking", checkBooking);

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

        // Method to add a customer:
        public bool addCustomer(string cusFname, string cusLname, string cusPhone)
        {
            string insertCustomer = "INSERT INTO customers VALUES (NULL, @customerFname, @customerLname, @customerPhone, @customerBookings)";
            try
            {
                MySqlConnection conn = DBConnect();
                if (!checkCustomer(cusFname, cusLname, cusPhone))
                {
                    MySqlCommand insertCmd = new MySqlCommand(insertCustomer, conn);
                    insertCmd.CommandType = System.Data.CommandType.Text;
                    insertCmd.Parameters.Add("@customerFname", MySqlDbType.Text).Value = cusFname;
                    insertCmd.Parameters.Add("@customerLname", MySqlDbType.Text).Value = cusLname;
                    insertCmd.Parameters.Add("@customerPhone", MySqlDbType.VarChar).Value = cusPhone;
                    insertCmd.Parameters.Add("@customerBookings", MySqlDbType.Int32).Value = 0;

                    insertCmd.ExecuteNonQuery();
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

        // Method to view all customers:

        public void viewAllCustomers(DataGridView dataGridView)
        {
            string selectCustomer = "SELECT * FROM customers";

            MySqlConnection connection = DBConnect();
            MySqlCommand cmd = new MySqlCommand(selectCustomer, connection);

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
          
        }

        // Method to delete a customer:

        public bool deleteCustomer(int cusID)
        {
            // Check whether the customer exists:

            
                if (!checkCustomer(cusID))
                {
                   
                }
                else
                {
                    if (!checkCustomerByBooking(cusID))
                    {
                        
                    }
                    else
                    {
                        string delCustomer = "DELETE FROM customers WHERE customerID = @cusID AND customerBookings = @zeroBooking";
                        MySqlConnection conn = DBConnect();
                    try
                        {
                            MySqlCommand deleteCmd = new MySqlCommand(delCustomer, conn);
                            deleteCmd.CommandType = System.Data.CommandType.Text;
                            deleteCmd.Parameters.Add("@cusID", MySqlDbType.Int32).Value = cusID;
                            deleteCmd.Parameters.Add("@zeroBooking", MySqlDbType.Int32).Value = 0;

                            deleteCmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return false;
                        }
                    }
                }

                return true;

            
        }
    }
}
