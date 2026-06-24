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
    public partial class AddCompositionOrder : Form
    {
        public AddCompositionOrder()
        {
            InitializeComponent();
        }

        private void AddCompositionOrder_Load(object sender, EventArgs e)
        {
            this.менюTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Меню);
            this.заказыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Заказы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OrderCompositionForm main = this.Owner as OrderCompositionForm;

            if (main != null)
            {
                var dataset = main.база_данных_доставки_еды_1_версияDataSet;
                DataRow nRow = dataset.Состав_Заказа.NewRow();

                nRow["Количество"] = Convert.ToInt32(nudQuantity.Value);

                if (cbOrder.SelectedValue is DataRowView drvOrder)
                {
                    nRow["ID_Заказа"] = Convert.ToInt32(drvOrder["ID_Заказа"]);
                }
                else if (cbOrder.SelectedValue != null)
                {
                    nRow["ID_Заказа"] = Convert.ToInt32(cbOrder.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите номер заказа!");
                    return;
                }

                if (cbDish.SelectedValue is DataRowView drvDish)
                {
                    nRow["ID_Блюда"] = Convert.ToInt32(drvDish["ID_Блюда"]);
                }
                else if (cbDish.SelectedValue != null)
                {
                    nRow["ID_Блюда"] = Convert.ToInt32(cbDish.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите блюдо из списка!");
                    return;
                }

                dataset.Состав_Заказа.Rows.Add(nRow);
                main.состав_ЗаказаTableAdapter.Update(dataset.Состав_Заказа);
                dataset.Состав_Заказа.AcceptChanges();
                nudQuantity.Value = 1;
                cbDish.SelectedIndex = -1;
                main.состав_ЗаказаTableAdapter.Fill(dataset.Состав_Заказа);
            }
        }
    }
}
