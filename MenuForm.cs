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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.рестораныTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Рестораны);
            this.менюTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Меню);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMenu af = new AddMenu();
            af.Owner = this;
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            менюTableAdapter.Update(база_данных_доставки_еды_1_версияDataSet);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchMenu sf = new SearchMenu();
            sf.Owner = this;
            sf.Show();
        }
    }
}
