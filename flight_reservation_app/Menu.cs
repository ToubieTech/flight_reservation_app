using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace flight_reservation_app
{
    public partial class Menu : Form
    {
        private void pageStyling()
        {
            customerMenuPanel.Visible = false;
            flightMenuPanel.Visible = false;
            bookingMenuPanel.Visible = false;
        }

        private void hideMenu()
        {
            if (customerMenuPanel.Visible == true)
            {
                customerMenuPanel.Visible = false;
            }

            if (flightMenuPanel.Visible == true)
            {
                flightMenuPanel.Visible = false;
            }
            if (bookingMenuPanel.Visible == true)
            {
                bookingMenuPanel.Visible = false;
            }
        }

        private void displayMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public Menu()
        {
            InitializeComponent();
            pageStyling();
        }


        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerMenu_Click(object sender, EventArgs e)
        {
            displayMenu(customerMenuPanel);
        }

        

        private void flightMenu_Click(object sender, EventArgs e)
        {
            displayMenu(flightMenuPanel);
        }

        private void addFlightMenu_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void viewFlightsMenu_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void viewFlightMenu_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void deleteFlightMenu_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void bookingMenu_Click(object sender, EventArgs e)
        {
            displayMenu(bookingMenuPanel);
        }

        private void makeBookingMenu_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void viewBookingsMenu_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            add_customer openAddCus = new add_customer();
            openAddCus.Show();
        }

        private void viewCustomersMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            view_customers openViewCus = new view_customers();
            openViewCus.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            delete_customer openDelCus = new delete_customer();
            openDelCus.Show();
        }

        private void flightMenu_Click_1(object sender, EventArgs e)
        {
            displayMenu(flightMenuPanel);
        }

        private void addFlightMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            add_flight openAddFlight = new add_flight();
            openAddFlight.Show();
        }

        private void viewFlightsMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            view_flights openViewFlights = new view_flights();
            openViewFlights.Show();
        }

        private void viewFlightMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            view_flight openViewFlight = new view_flight();
            openViewFlight.Show();
        }

        private void deleteFlightMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            delete_flight openDelFlight = new delete_flight();
            openDelFlight.Show();
        }

        private void bookingMenu_Click_1(object sender, EventArgs e)
        {
            displayMenu(bookingMenuPanel);
        }

        private void makeBookingMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            make_booking openAddBook = new make_booking();
            openAddBook.Show();
        }

        private void viewBookingsMenu_Click_1(object sender, EventArgs e)
        {
            hideMenu();
            this.Hide();
            view_bookings openViewBook = new view_bookings();
            openViewBook.Show();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
