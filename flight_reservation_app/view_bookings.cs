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
    public partial class view_bookings : Form
    {
        public view_bookings()
        {
            InitializeComponent();
        }

        private void logoPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainMenuBtn11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void view_bookings_Load(object sender, EventArgs e)
        {
            BookingManager booking = new BookingManager();
            AirlineCoordinator coordinator = new AirlineCoordinator(booking);
            coordinator.viewBookings(dataGridView4);
        }
    }
}
