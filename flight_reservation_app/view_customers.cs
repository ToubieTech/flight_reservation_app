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
using System.Collections;

namespace flight_reservation_app
{
    public partial class view_customers : Form
    {
        

        private void updateDatagrid()
        {
            
        }

        public view_customers()
        {
            InitializeComponent();
        }

        private void view_customers_Load(object sender, EventArgs e)
        {
            CustomerManager customer = new CustomerManager();
            AirlineCoordinator coordinator = new AirlineCoordinator(customer);
            coordinator.viewCustomers(dataGridView1);
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mainMenuBtn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu openMenu = new Menu();
            openMenu.Show();
        }
    }
}
