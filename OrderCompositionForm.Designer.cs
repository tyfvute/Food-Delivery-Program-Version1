namespace FoodDeliveryVersion1
{
    partial class OrderCompositionForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_доставки_еды_1_версияDataSet = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSet();
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.составЗаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состав_ЗаказаTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.Состав_ЗаказаTableAdapter();
            this.заказыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.ЗаказыTableAdapter();
            this.менюTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.МенюTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.iDСоставаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составЗаказаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(369, 402);
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
            this.iDСоставаDataGridViewTextBoxColumn,
            this.iDЗаказаDataGridViewTextBoxColumn,
            this.iDБлюдаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.составЗаказаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 384);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // база_данных_доставки_еды_1_версияDataSet
            // 
            this.база_данных_доставки_еды_1_версияDataSet.DataSetName = "База_данных_доставки_еды_1_версияDataSet";
            this.база_данных_доставки_еды_1_версияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "Меню";
            this.менюBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // составЗаказаBindingSource
            // 
            this.составЗаказаBindingSource.DataMember = "Состав_Заказа";
            this.составЗаказаBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // состав_ЗаказаTableAdapter
            // 
            this.состав_ЗаказаTableAdapter.ClearBeforeFill = true;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(196, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iDСоставаDataGridViewTextBoxColumn
            // 
            this.iDСоставаDataGridViewTextBoxColumn.DataPropertyName = "ID_Состава";
            this.iDСоставаDataGridViewTextBoxColumn.HeaderText = "ID_Состава";
            this.iDСоставаDataGridViewTextBoxColumn.Name = "iDСоставаDataGridViewTextBoxColumn";
            // 
            // iDЗаказаDataGridViewTextBoxColumn
            // 
            this.iDЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.DataSource = this.заказыBindingSource;
            this.iDЗаказаDataGridViewTextBoxColumn.DisplayMember = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDЗаказаDataGridViewTextBoxColumn.HeaderText = "ID_Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.Name = "iDЗаказаDataGridViewTextBoxColumn";
            this.iDЗаказаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDЗаказаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDЗаказаDataGridViewTextBoxColumn.ValueMember = "ID_Заказа";
            // 
            // iDБлюдаDataGridViewTextBoxColumn
            // 
            this.iDБлюдаDataGridViewTextBoxColumn.DataPropertyName = "ID_Блюда";
            this.iDБлюдаDataGridViewTextBoxColumn.DataSource = this.менюBindingSource;
            this.iDБлюдаDataGridViewTextBoxColumn.DisplayMember = "Названия_Блюда";
            this.iDБлюдаDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDБлюдаDataGridViewTextBoxColumn.HeaderText = "ID_Блюда";
            this.iDБлюдаDataGridViewTextBoxColumn.Name = "iDБлюдаDataGridViewTextBoxColumn";
            this.iDБлюдаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDБлюдаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDБлюдаDataGridViewTextBoxColumn.ValueMember = "ID_Блюда";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // OrderCompositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderCompositionForm";
            this.Text = "Состав Заказа";
            this.Load += new System.EventHandler(this.OrderCompositionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составЗаказаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public База_данных_доставки_еды_1_версияDataSet база_данных_доставки_еды_1_версияDataSet;
        public System.Windows.Forms.BindingSource составЗаказаBindingSource;
        public База_данных_доставки_еды_1_версияDataSetTableAdapters.Состав_ЗаказаTableAdapter состав_ЗаказаTableAdapter;
        public System.Windows.Forms.BindingSource заказыBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.МенюTableAdapter менюTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСоставаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}