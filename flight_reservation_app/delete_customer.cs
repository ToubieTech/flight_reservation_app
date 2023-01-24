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
    public partial class delete_customer : Form
    {
        public delete_customer()
        {
            InitializeComponent();
        }

        // Method to clear text field after form submission:
        private void clearInput()
        {
            deleteCus.Text = "";
        }

        private void mainMenuBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void delCustomerBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (deleteCus.Text == "")
            {
                MessageBox.Show("This field cannot be empty", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!string.IsNullOrEmpty(deleteCus.Text) && !int.TryParse(deleteCus.Text, out i))
            {
                MessageBox.Show("Please enter a valid customer ID", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                CustomerManager customer = new CustomerManager();
                AirlineCoordinator coordinator = new AirlineCoordinator(customer);

                if (coordinator.checkCustomerByID(Convert.ToInt32(deleteCus.Text)))
                {
                    coordinator.deleteCustomer(Convert.ToInt32(deleteCus.Text));
                    MessageBox.Show("Customer deleted successfully", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInput(); 
                } else
                {
                    MessageBox.Show("This customer does not exist in our system", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void delete_customer_Load(object sender, EventArgs e)
        {

        }
    }
}
