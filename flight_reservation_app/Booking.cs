using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight_reservation_app
{
    class Booking
    {
        // Data members:
        private int bookingNum;
        private string bookingDate;
        private Customer bookingCustomer;
        private Flight bookingFlight;

        // Class constructor:
        public Booking(int bookingNum, string bookingDate, int cusID, int flightID)
        {
            this.bookingNum = bookingNum;
            this.bookingDate = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.bookingCustomer = new Customer(cusID);
            this.bookingFlight = new Flight(flightID);
        }


        // Getters:
        public int getBookingNum()
        {
            return bookingNum;
        }

        public string getBookingDate()
        {
            return bookingDate;
        }


        public int getBookingCustomer()
        {
            return bookingCustomer.getCustomerID();
        }

        public int getBookingFlight()
        {
            return bookingFlight.getFlightID();
        }
    }
}
