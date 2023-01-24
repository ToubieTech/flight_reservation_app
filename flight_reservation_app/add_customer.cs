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
    public partial class add_customer : Form
    {
        
        public add_customer()
        {
            InitializeComponent();
        }

        // Method to clear text field after form submission:
        private void clearInput()
        {
            cusFname.Text = "";
            cusLname.Text = "";
            cusPhone.Text = "";
        }

        // Event listener for clicking on add customer button:
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            // Validation for form input:
            if (cusFname.Text == "" || cusLname.Text == "" || cusPhone.Text == "")
            {
                MessageBox.Show("One or more fields empty", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                // Interaction of GUI with the coordinator class (AirlineCoordinator):
                CustomerManager customer = new CustomerManager();
                AirlineCoordinator coordinator = new AirlineCoordinator(customer);

                
                if (coordinator.checkCustomer(cusFname.Text, cusLname.Text, cusPhone.Text) == true)
                {
                    MessageBox.Show("Customer already exists", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    coordinator.addCustomer(cusFname.Text, cusLname.Text, cusPhone.Text);
                    MessageBox.Show("Customer " + cusFname.Text + " " + cusLname.Text + " added successfully", "Travella", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInput();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void add_customer_Load(object sender, EventArgs e)
        {

        }

        private void cusFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusLnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void cusLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusPhoneLbl_Click(object sender, EventArgs e)
        {

        }

        private void cusFnameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
