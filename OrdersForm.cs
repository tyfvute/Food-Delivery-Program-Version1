using FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters;
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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            this.курьерыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Курьеры);
            this.клиентыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Клиенты);
            this.заказыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Заказы);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказыTableAdapter.Update(база_данных_доставки_еды_1_версияDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddOrders af = new AddOrders();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchOrders sf = new SearchOrders();
            sf.Owner = this;
            sf.Show();
        }
    }
}
