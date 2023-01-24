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
    public partial class view_flights : Form
    {
        public view_flights()
        {
            InitializeComponent();
        }

        private void mainMenuBtn6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void view_flights_Load(object sender, EventArgs e)
        {
            FlightManager flight = new FlightManager();
            AirlineCoordinator coordinator = new AirlineCoordinator(flight);
            coordinator.viewFlights(dataGridView2);
        }
    }
}
