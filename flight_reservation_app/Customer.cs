using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight_reservation_app
{
    class Customer
    {
        // Data Mmebers:
        private int customerID;
        private string customerFname;
        private string customerLname;
        private string customerPhone;
        private int customerBookings;

        // Class Constructor:
        public Customer(string customerFname, string customerLname, string customerPhone, int customerBookings)
        {
            this.customerFname = customerFname;
            this.customerLname = customerLname;
            this.customerPhone = customerPhone;
            this.customerBookings = customerBookings;
        }

        public Customer(int customerID)
        {
            this.customerID = customerID;
        }

        // Getters:

        public int getCustomerID()
        {
            return customerID;
        }

        public string getCustomerFname()
        {
            return customerFname;
        }

        public string getCustomerLname()
        {
            return customerLname;
        }

        public string getCustomerPhone()
        {
            return customerPhone;
        }

        public int getCustomerBookings()
        {
            return customerBookings;
        }

       
        public override string ToString()
        {
            string customerInfo = "";
            customerInfo += "\nCustomer First Name: " + getCustomerFname();
            customerInfo += "\nCustomer Last Name: " + getCustomerLname();
            customerInfo += "\nCustomer Phone Number: " + getCustomerPhone();
            customerInfo += "\nCustomer Number of Bookings: " + getCustomerBookings();
            return customerInfo;
        }
    }
}
