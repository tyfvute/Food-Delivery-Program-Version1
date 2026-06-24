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
    public partial class AddRestaurants : Form
    {
        public AddRestaurants()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            RestaurantsForm main = this.Owner as RestaurantsForm;
            if (main != null)
            {
                DataRow nRow = main.база_данных_доставки_еды_1_версияDataSet.Рестораны.NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow["ID_Ресторана"] = rc;
                nRow["Название_Ресторана"] = tbname.Text;
                nRow["Адрес_Ресторана"] = tbplace.Text;
                nRow["Телефон_Ресторана"] = tbphone.Text;
                main.база_данных_доставки_еды_1_версияDataSet.Рестораны.Rows.Add(nRow);
                main.рестораныTableAdapter.Update(main.база_данных_доставки_еды_1_версияDataSet.Рестораны);
                main.база_данных_доставки_еды_1_версияDataSet.Рестораны.AcceptChanges();
                main.dataGridView1.Refresh();
                tbname.Text = "";
                tbplace.Text = "";
                tbphone.Text = "";
            }
        }
    }
}
