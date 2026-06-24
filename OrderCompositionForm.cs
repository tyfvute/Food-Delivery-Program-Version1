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
    public partial class OrderCompositionForm : Form
    {
        public OrderCompositionForm()
        {
            InitializeComponent();
        }

        private void OrderCompositionForm_Load(object sender, EventArgs e)
        {
            this.менюTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Меню);
            this.заказыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Заказы);
            this.состав_ЗаказаTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Состав_Заказа);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            состав_ЗаказаTableAdapter.Update(база_данных_доставки_еды_1_версияDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCompositionOrder af = new AddCompositionOrder();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchCompositionOrder sf = new SearchCompositionOrder();
            sf.Owner = this;
            sf.Show();
        }
    }
}
