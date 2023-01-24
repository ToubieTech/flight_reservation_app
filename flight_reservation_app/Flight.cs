using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flight_reservation_app
{
    class Flight
    {
        // Data members:
        private int flightID;
        private int flightNumber;
        private string flightOrigin;
        private string flightDestination;
        private string departureDate;
        private string arrivalDate;
        private int maxSeat;

        // Class constructor:
        public Flight(int flightNumber, string flightOrigin, string flightDestination, string departureDate, string arrivalDate, int maxSeat) 
        {
            this.flightNumber = flightNumber;
            this.flightOrigin = flightOrigin;
            this.flightDestination = flightDestination;
            this.departureDate = departureDate;
            this.arrivalDate = arrivalDate;
            this.maxSeat = maxSeat;
        }

        public Flight(int flightID)
        {
            this.flightID = flightID;
        }

        // Getters:
        public int getFlightID()
        {
            return flightID;
        }

        public int getFlightNumber()
        {
            return flightNumber;
        }

        public string getFlightOrigin()
        {
            return flightOrigin;
        }
        public string getFlightDestination()
        {
            return flightDestination;
        }

        public string getDepartureDate()
        {
            return departureDate;
        }
        public string getArrivalDate()
        {
            return arrivalDate;
        }

        public int getMaxSeat()
        {
            return maxSeat;
        }


        public override string ToString()
        {
            string flightInfo = ""; 
            flightInfo += "\nFlight Number: #" + getFlightNumber();
            flightInfo += "\nFlight Origin: " + getFlightOrigin();
            flightInfo += "\nFlight Destination: " + getFlightDestination();
            flightInfo += "\nFlight Departure Date: " + getDepartureDate();
            flightInfo += "\nFlight Arrival Date: " + getDepartureDate();
            flightInfo += "\nFlight Maximum Seat: " + getMaxSeat();
            return flightInfo;
        }
    }
}
