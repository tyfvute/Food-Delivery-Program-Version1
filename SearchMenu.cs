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
    public partial class SearchMenu : Form
    {
        public SearchMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm main = this.Owner as MenuForm;
            if (main != null)
            {
                main.dataGridView1.ClearSelection();
                int firstFoundRowIndex = -1;
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                    {
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            string cellText = "";
                            if (j == 2) // Столбец ID_Ресторана (ComboBox)
                            {
                                if (main.dataGridView1.Rows[i].Cells[j].FormattedValue != null)
                                {
                                    cellText = main.dataGridView1.Rows[i].Cells[j].FormattedValue.ToString();
                                }
                            }
                            else
                            {
                                cellText = main.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            if (cellText.Contains(textBox1.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                if (firstFoundRowIndex == -1)
                                {
                                    firstFoundRowIndex = i;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
