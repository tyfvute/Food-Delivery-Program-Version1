using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryVersion1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuForm clientsForm = new MenuForm();
            clientsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestaurantsForm clientsForm = new RestaurantsForm();
            clientsForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeliverersForm clientsForm = new DeliverersForm();
            clientsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrdersForm clientsForm = new OrdersForm();
            clientsForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OrderCompositionForm clientsForm = new OrderCompositionForm();
            clientsForm.Show();
        }
    }
}
