namespace FoodDeliveryVersion1
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_доставки_еды_1_версияDataSet = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSet();
            this.курьерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.ЗаказыTableAdapter();
            this.клиентыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.КлиентыTableAdapter();
            this.курьерыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.КурьерыTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.iDЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDКурьераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курьерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(669, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 36);
            this.button4.TabIndex = 13;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(104, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаказаDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.iDКурьераDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.датаДоставкиDataGridViewTextBoxColumn,
            this.статусЗаказаDataGridViewTextBoxColumn,
            this.способОплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 384);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // база_данных_доставки_еды_1_версияDataSet
            // 
            this.база_данных_доставки_еды_1_версияDataSet.DataSetName = "База_данных_доставки_еды_1_версияDataSet";
            this.база_данных_доставки_еды_1_версияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // курьерыBindingSource
            // 
            this.курьерыBindingSource.DataMember = "Курьеры";
            this.курьерыBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // курьерыTableAdapter
            // 
            this.курьерыTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(196, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iDЗаказаDataGridViewTextBoxColumn
            // 
            this.iDЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.HeaderText = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.Name = "iDЗаказаDataGridViewTextBoxColumn";
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.DataSource = this.клиентыBindingSource;
            this.iDКлиентаDataGridViewTextBoxColumn.DisplayMember = "Имя_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDКлиентаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDКлиентаDataGridViewTextBoxColumn.ValueMember = "ID_Клиента";
            // 
            // iDКурьераDataGridViewTextBoxColumn
            // 
            this.iDКурьераDataGridViewTextBoxColumn.DataPropertyName = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.DataSource = this.курьерыBindingSource;
            this.iDКурьераDataGridViewTextBoxColumn.DisplayMember = "Имя_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDКурьераDataGridViewTextBoxColumn.HeaderText = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.Name = "iDКурьераDataGridViewTextBoxColumn";
            this.iDКурьераDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDКурьераDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDКурьераDataGridViewTextBoxColumn.ValueMember = "ID_Курьера";
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата_Заказа";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.датаЗаказаDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата_Заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            // 
            // датаДоставкиDataGridViewTextBoxColumn
            // 
            this.датаДоставкиDataGridViewTextBoxColumn.DataPropertyName = "Дата_Доставки";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.датаДоставкиDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.датаДоставкиDataGridViewTextBoxColumn.HeaderText = "Дата_Доставки";
            this.датаДоставкиDataGridViewTextBoxColumn.Name = "датаДоставкиDataGridViewTextBoxColumn";
            // 
            // статусЗаказаDataGridViewTextBoxColumn
            // 
            this.статусЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Статус_Заказа";
            this.статусЗаказаDataGridViewTextBoxColumn.HeaderText = "Статус_Заказа";
            this.статусЗаказаDataGridViewTextBoxColumn.Name = "статусЗаказаDataGridViewTextBoxColumn";
            // 
            // способОплатыDataGridViewTextBoxColumn
            // 
            this.способОплатыDataGridViewTextBoxColumn.DataPropertyName = "Способ_Оплаты";
            this.способОплатыDataGridViewTextBoxColumn.HeaderText = "Способ_Оплаты";
            this.способОплатыDataGridViewTextBoxColumn.Name = "способОплатыDataGridViewTextBoxColumn";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курьерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public База_данных_доставки_еды_1_версияDataSet база_данных_доставки_еды_1_версияDataSet;
        public System.Windows.Forms.BindingSource заказыBindingSource;
        public База_данных_доставки_еды_1_версияDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource курьерыBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.КурьерыTableAdapter курьерыTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способОплатыDataGridViewTextBoxColumn;
    }
}