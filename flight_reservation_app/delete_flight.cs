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
    public partial class delete_flight : Form
    {
        public delete_flight()
        {
            InitializeComponent();
        }

        // Method to clear text field after form submission:
        private void clearInput()
        {
            deleteFlight.Text = "";
        }

        private void mainMenuBtn9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void delFlightBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (deleteFlight.Text == "")
            {
                MessageBox.Show("This field cannot be empty", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!string.IsNullOrEmpty(deleteFlight.Text) && !int.TryParse(deleteFlight.Text, out i))
            {
                MessageBox.Show("Please enter a valid customer ID", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FlightManager flight  = new FlightManager();
                AirlineCoordinator coordinator = new AirlineCoordinator(flight);

                if (coordinator.checkFlight(Convert.ToInt32(deleteFlight.Text)))
                {
                    if (coordinator.checkFlightByBooking(Convert.ToInt32(deleteFlight.Text)))
                    {
                        coordinator.deleteFlight(Convert.ToInt32(deleteFlight.Text));
                        MessageBox.Show("Flight deleted successfully", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInput();
                    }
                    else
                    {
                        MessageBox.Show("Flight cannot be deleted as it contains bookings", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                } else
                {
                    MessageBox.Show("Flight not found", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
        }
    }
}
