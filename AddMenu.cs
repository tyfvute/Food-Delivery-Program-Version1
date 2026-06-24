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
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void AddMenu_Load(object sender, EventArgs e)
        {
            this.рестораныTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Рестораны);

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MenuForm main = this.Owner as MenuForm;
            if (main != null)
            {

                DataRow nRow = main.база_данных_доставки_еды_1_версияDataSet.Меню.NewRow();

                nRow["Названия_Блюда"] = tbname.Text;
                nRow["Цена"] = Convert.ToDecimal(tbmoney.Text);
                nRow["Категория"] = tbcategory.Text;

                if (cbrestaurants.SelectedValue is DataRowView drv)
                {
                    nRow["ID_Ресторана"] = Convert.ToInt32(drv["ID_Ресторана"]);
                }
                else if (cbrestaurants.SelectedValue != null)
                {
                    nRow["ID_Ресторана"] = Convert.ToInt32(cbrestaurants.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите ресторан из списка!");
                    return;
                }

                main.база_данных_доставки_еды_1_версияDataSet.Меню.Rows.Add(nRow);

                main.менюTableAdapter.Update(main.база_данных_доставки_еды_1_версияDataSet.Меню);

                main.база_данных_доставки_еды_1_версияDataSet.Меню.AcceptChanges();

                tbname.Text = "";
                tbmoney.Text = "";
                tbcategory.Text = "";
                cbrestaurants.SelectedIndex = -1;
                main.менюTableAdapter.Fill(main.база_данных_доставки_еды_1_версияDataSet.Меню);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
