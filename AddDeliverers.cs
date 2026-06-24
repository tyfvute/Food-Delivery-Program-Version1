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
    public partial class AddDeliverers : Form
    {
        public AddDeliverers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DeliverersForm main = this.Owner as DeliverersForm;
            if (main != null)
            {
                DataRow nRow = main.база_данных_доставки_еды_1_версияDataSet.Курьеры.NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow["ID_Курьера"] = rc;
                nRow["Имя_Курьера"] = tbname.Text;
                nRow["Телефон_Курьера"] = tbphone.Text;
                main.база_данных_доставки_еды_1_версияDataSet.Курьеры.Rows.Add(nRow);
                main.курьерыTableAdapter.Update(main.база_данных_доставки_еды_1_версияDataSet.Курьеры);
                main.база_данных_доставки_еды_1_версияDataSet.Курьеры.AcceptChanges();
                main.dataGridView1.Refresh();
                tbname.Text = "";
                tbphone.Text = "";
            }
        }
    }
}
