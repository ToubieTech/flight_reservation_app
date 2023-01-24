using System;
/*
    Name: Oluwatobi Hajarat Giwa
    Student ID: 101331074

    Name: Akindun Daniel
    Student ID: 101384910

    Name: Divine Falola
    Student ID: 101394076

    Name: Adedolapo Balogun
    Student ID: 101377774
 */
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_reservation_app
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }

    class AirlineCoordinator
    {
        private CustomerManager customers;
        private FlightManager flights;
        private BookingManager bookings;

        public AirlineCoordinator(CustomerManager customers)
        {
            this.customers = customers;
        }

        public AirlineCoordinator(FlightManager flights)
        {
            this.flights = flights;
        }

        public AirlineCoordinator(BookingManager bookings)
        {
            this.bookings = bookings;
        }

        public bool checkCustomer(string cusFname, string cusLname, string cusPhone)
        {
            return customers.checkCustomer(cusFname, cusLname, cusPhone);
        }

        public bool checkCustomerByID(int cusID)
        {
            return customers.checkCustomer(cusID);
        }

        public bool checkCustomerByBooking(int cusID)
        {
            return customers.checkCustomerByBooking(cusID);
        }

        public bool addCustomer(string cusFname, string cusLname, string cusPhone)
        {
            return customers.addCustomer(cusFname, cusLname, cusPhone);
        }

        public void viewCustomers(DataGridView dgv)
        {
            customers.viewAllCustomers(dgv);
        }

        public bool deleteCustomer(int cusID)
        {
            return customers.deleteCustomer(cusID);
        }

        public bool checkFlight(int flightNum)
        {
            return flights.checkFlight(flightNum);
        }

        public bool checkFlightByBooking(int flightNum)
        {
            return flights.checkFlightByBooking(flightNum);
        }

        public bool addFlight(int flightNumber, string flightOrigin, string flightDestination, string departureDate, string arrivalDate, int maxSeat)
        {
            return flights.addFlight(flightNumber, flightOrigin, flightDestination, departureDate, arrivalDate, maxSeat);
        }

        public void viewFlights(DataGridView dgv)
        {
            flights.viewAllFlights(dgv);
        }

        public void viewFlight(DataGridView dgv, int flightNumber)
        {
            flights.viewFlight(dgv, flightNumber);
        }

        public bool deleteFlight(int flightNumber)
        {
            return flights.deleteFlight(flightNumber);
        }

        public bool checkBooking(int bookingNum)
        {
            return bookings.checkBooking(bookingNum);
        }

        public bool checkBookingByCus(int cusID)
        {
            return bookings.checkBookingByCustomer(cusID);
        }

        public bool checkBookingByFlight(int flightNum)
        {
            return bookings.checkBookingByFlight(flightNum);
        }

        public bool addBooking(int cusID, int flightNumber, int bookingNum)
        {
            return bookings.addBooking(cusID, flightNumber, bookingNum);
        }

        public void viewBookings(DataGridView dgv)
        {
            bookings.viewBookings(dgv);
        }
    }
}
