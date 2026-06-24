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
    public partial class AddClients : Form
    {
        public AddClients()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ClientsForm main = this.Owner as ClientsForm;
            if (main != null)
            {
                DataRow nRow = main.база_данных_доставки_еды_1_версияDataSet.Клиенты.NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow["ID_Клиента"] = rc;
                nRow["Имя_Клиента"] = tbname.Text;
                nRow["Телефон_Клиента"] = tbphone.Text;
                nRow["Адрес_Клиента"] = tbplace.Text;
                main.база_данных_доставки_еды_1_версияDataSet.Клиенты.Rows.Add(nRow);
                main.клиентыTableAdapter.Update(main.база_данных_доставки_еды_1_версияDataSet.Клиенты);
                main.база_данных_доставки_еды_1_версияDataSet.Клиенты.AcceptChanges();
                main.dataGridView1.Refresh();
                tbname.Text = "";
                tbphone.Text = "";
                tbplace.Text = "";
            }
        }
    }
}
