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
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            OrdersForm main = this.Owner as OrdersForm;

            if (main != null)
            {
                var dataset = main.база_данных_доставки_еды_1_версияDataSet;
                DataRow nRow = dataset.Заказы.NewRow();

                nRow["Дата_Заказа"] = dtpOrderDate.Value;
                nRow["Дата_Доставки"] = dtpDeliveryDate.Value;
                nRow["Статус_Заказа"] = tbStatus.Text;
                nRow["Способ_Оплаты"] = tbPayment.Text;

                if (cbClient.SelectedValue is DataRowView drvClient)
                {
                    nRow["ID_Клиента"] = Convert.ToInt32(drvClient["ID_Клиента"]);
                }
                else if (cbClient.SelectedValue != null)
                {
                    nRow["ID_Клиента"] = Convert.ToInt32(cbClient.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите клиента из списка!");
                    return;
                }

                if (cbDeliverer.SelectedValue is DataRowView drvDeliverer)
                {
                    nRow["ID_Курьера"] = Convert.ToInt32(drvDeliverer["ID_Курьера"]);
                }
                else if (cbDeliverer.SelectedValue != null)
                {
                    nRow["ID_Курьера"] = Convert.ToInt32(cbDeliverer.SelectedValue);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите курьера из списка!");
                    return;
                }

                dataset.Заказы.Rows.Add(nRow);
                main.заказыTableAdapter.Update(dataset.Заказы);
                dataset.Заказы.AcceptChanges();

                tbStatus.Text = "";
                tbPayment.Text = "";
                cbClient.SelectedIndex = -1;
                cbDeliverer.SelectedIndex = -1;
                dtpOrderDate.Value = DateTime.Now;
                dtpDeliveryDate.Value = DateTime.Now;

                main.заказыTableAdapter.Fill(dataset.Заказы);
            }
        }

        private void AddOrders_Load(object sender, EventArgs e)
        {
            this.курьерыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Курьеры);
            this.заказыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Заказы);
            this.клиентыTableAdapter.Fill(this.база_данных_доставки_еды_1_версияDataSet.Клиенты);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
