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
    public partial class DeliverersForm : Form
    {
        public DeliverersForm()
        {
            InitializeComponent();
        }

        private void DeliverersForm_Load(object sender, EventArgs e)
        {
            this.курьерыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Курьеры);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            курьерыTableAdapter.Update(база_данных_доставки_еды_1_версияDataSet);
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
            AddDeliverers af = new AddDeliverers();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchDeliverers sf = new SearchDeliverers();
            sf.Owner = this;
            sf.Show();
        }
    }
}
