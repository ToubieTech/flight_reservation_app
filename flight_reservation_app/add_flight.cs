using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_reservation_app
{
    public partial class add_flight : Form
    {
        public add_flight()
        {
            InitializeComponent();
        }

        private void mainMenuBtn5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        // Method to clear text field after form submission:
        private void clearInput()
        {
            flightNum.Text = "";
            flightOrigin.Text = "";
            flightDestination.Text = "";
            maxSeat.Text = "";
        }

        private void addFlightBtn_Click(object sender, EventArgs e)
        {
            if (flightNum.Text == "" || flightOrigin.Text == "" || flightDestination.Text == "" ||  maxSeat.Text == "")
            {
                MessageBox.Show("One or more fields empty", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FlightManager flight = new FlightManager();
                AirlineCoordinator coordinator = new AirlineCoordinator(flight);

                if (coordinator.checkFlight(Convert.ToInt32(flightNum.Text)) == true)
                {
                    MessageBox.Show("Flight already exists", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    coordinator.addFlight(Convert.ToInt32(flightNum.Text), flightOrigin.Text, flightDestination.Text, departureDate.Value.ToString(), arrivalDate.Value.ToString(), Convert.ToInt32(maxSeat.Text));
                    MessageBox.Show("Flight " + flightNum.Text + " added successfully", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInput();
                }

            }
        }

        private void add_flight_Load(object sender, EventArgs e)
        {

        }
    }
}
