namespace FoodDeliveryVersion1
{
    partial class RestaurantsForm
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
            this.iDРесторанаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеРесторанаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресРесторанаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонРесторанаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рестораныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_доставки_еды_1_версияDataSet = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSet();
            this.рестораныTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.РестораныTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рестораныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(434, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 36);
            this.button4.TabIndex = 14;
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
            this.iDРесторанаDataGridViewTextBoxColumn,
            this.названиеРесторанаDataGridViewTextBoxColumn,
            this.адресРесторанаDataGridViewTextBoxColumn,
            this.телефонРесторанаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.рестораныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 384);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDРесторанаDataGridViewTextBoxColumn
            // 
            this.iDРесторанаDataGridViewTextBoxColumn.DataPropertyName = "ID_Ресторана";
            this.iDРесторанаDataGridViewTextBoxColumn.HeaderText = "ID_Ресторана";
            this.iDРесторанаDataGridViewTextBoxColumn.Name = "iDРесторанаDataGridViewTextBoxColumn";
            // 
            // названиеРесторанаDataGridViewTextBoxColumn
            // 
            this.названиеРесторанаDataGridViewTextBoxColumn.DataPropertyName = "Название_Ресторана";
            this.названиеРесторанаDataGridViewTextBoxColumn.HeaderText = "Название_Ресторана";
            this.названиеРесторанаDataGridViewTextBoxColumn.Name = "названиеРесторанаDataGridViewTextBoxColumn";
            this.названиеРесторанаDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресРесторанаDataGridViewTextBoxColumn
            // 
            this.адресРесторанаDataGridViewTextBoxColumn.DataPropertyName = "Адрес_Ресторана";
            this.адресРесторанаDataGridViewTextBoxColumn.HeaderText = "Адрес_Ресторана";
            this.адресРесторанаDataGridViewTextBoxColumn.Name = "адресРесторанаDataGridViewTextBoxColumn";
            this.адресРесторанаDataGridViewTextBoxColumn.Width = 110;
            // 
            // телефонРесторанаDataGridViewTextBoxColumn
            // 
            this.телефонРесторанаDataGridViewTextBoxColumn.DataPropertyName = "Телефон_Ресторана";
            this.телефонРесторанаDataGridViewTextBoxColumn.HeaderText = "Телефон_Ресторана";
            this.телефонРесторанаDataGridViewTextBoxColumn.Name = "телефонРесторанаDataGridViewTextBoxColumn";
            this.телефонРесторанаDataGridViewTextBoxColumn.Width = 130;
            // 
            // рестораныBindingSource
            // 
            this.рестораныBindingSource.DataMember = "Рестораны";
            this.рестораныBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // база_данных_доставки_еды_1_версияDataSet
            // 
            this.база_данных_доставки_еды_1_версияDataSet.DataSetName = "База_данных_доставки_еды_1_версияDataSet";
            this.база_данных_доставки_еды_1_версияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рестораныTableAdapter
            // 
            this.рестораныTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(196, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RestaurantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RestaurantsForm";
            this.Text = "Рестораны";
            this.Load += new System.EventHandler(this.RestaurantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рестораныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public База_данных_доставки_еды_1_версияDataSet база_данных_доставки_еды_1_версияDataSet;
        public System.Windows.Forms.BindingSource рестораныBindingSource;
        public База_данных_доставки_еды_1_версияDataSetTableAdapters.РестораныTableAdapter рестораныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРесторанаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеРесторанаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресРесторанаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонРесторанаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}