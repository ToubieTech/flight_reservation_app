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
    public partial class view_flight : Form
    {
        public view_flight()
        {
            InitializeComponent();
        }

        // Method to clear text field after form submission:
        private void clearInput()
        {
            viewFlight.Text = "";
        }
        private void mainMenuBtn8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void viewFlightBtn_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;

            int i = 0;
            if (viewFlight.Text == "")
            {
                MessageBox.Show("This field cannot be empty", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!string.IsNullOrEmpty(viewFlight.Text) && !int.TryParse(viewFlight.Text, out i))
            {
                MessageBox.Show("Please enter a valid flight number", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FlightManager flight = new FlightManager();
                AirlineCoordinator coordinator = new AirlineCoordinator(flight);
                //coordinator.viewFlights(dataGridView2);

                if (coordinator.checkFlight(Convert.ToInt32(viewFlight.Text)))
                {
                    coordinator.viewFlights(dataGridView3);
                    clearInput();
                }
                else
                {
                    MessageBox.Show("This flight does not exist in our system", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
