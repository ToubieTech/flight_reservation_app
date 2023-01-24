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
    public partial class make_booking : Form
    {
        public make_booking()
        {
            InitializeComponent();
        }

        // Method to clear text field after form submission:
        private void clearInput()
        {
            flightNum.Text = "";
            bookingNum.Text = "";
            cusID.Text = "";
        }

        private void mainMenuBtn10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void addBookingBtn_Click(object sender, EventArgs e)
        {
            if (flightNum.Text == "" || bookingNum.Text == "" || cusID.Text == "")
            {
                MessageBox.Show("One or more fields empty", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BookingManager booking = new BookingManager();
                AirlineCoordinator coordinator = new AirlineCoordinator(booking);

                if (coordinator.checkBooking(Convert.ToInt32(bookingNum.Text)))
                {
                    MessageBox.Show("Booking already exists", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!coordinator.checkBookingByCus(Convert.ToInt32(cusID.Text)))
                    {
                        MessageBox.Show("Customer does not exists", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else if (!coordinator.checkBookingByFlight(Convert.ToInt32(flightNum.Text)))
                    {
                        MessageBox.Show("Flight does not exists or Maximum plane seats reached. Booking Full", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        coordinator.addBooking(Convert.ToInt32(cusID.Text), Convert.ToInt32(flightNum.Text), Convert.ToInt32(bookingNum.Text));
                        MessageBox.Show("Booking " + bookingNum.Text + " added successfully", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInput();
                    }
                   
                }

            }
        }

        private void make_booking_Load(object sender, EventArgs e)
        {

        }
    }
}
