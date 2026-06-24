namespace FoodDeliveryVersion1
{
    partial class DeliverersForm
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
            this.iDКурьераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяКурьераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонКурьераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курьерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_доставки_еды_1_версияDataSet = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSet();
            this.курьерыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.КурьерыTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курьерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(284, 402);
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
            this.iDКурьераDataGridViewTextBoxColumn,
            this.имяКурьераDataGridViewTextBoxColumn,
            this.телефонКурьераDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.курьерыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 384);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDКурьераDataGridViewTextBoxColumn
            // 
            this.iDКурьераDataGridViewTextBoxColumn.DataPropertyName = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.HeaderText = "ID_Курьера";
            this.iDКурьераDataGridViewTextBoxColumn.Name = "iDКурьераDataGridViewTextBoxColumn";
            // 
            // имяКурьераDataGridViewTextBoxColumn
            // 
            this.имяКурьераDataGridViewTextBoxColumn.DataPropertyName = "Имя_Курьера";
            this.имяКурьераDataGridViewTextBoxColumn.HeaderText = "Имя_Курьера";
            this.имяКурьераDataGridViewTextBoxColumn.Name = "имяКурьераDataGridViewTextBoxColumn";
            // 
            // телефонКурьераDataGridViewTextBoxColumn
            // 
            this.телефонКурьераDataGridViewTextBoxColumn.DataPropertyName = "Телефон_Курьера";
            this.телефонКурьераDataGridViewTextBoxColumn.HeaderText = "Телефон_Курьера";
            this.телефонКурьераDataGridViewTextBoxColumn.Name = "телефонКурьераDataGridViewTextBoxColumn";
            this.телефонКурьераDataGridViewTextBoxColumn.Width = 115;
            // 
            // курьерыBindingSource
            // 
            this.курьерыBindingSource.DataMember = "Курьеры";
            this.курьерыBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // база_данных_доставки_еды_1_версияDataSet
            // 
            this.база_данных_доставки_еды_1_версияDataSet.DataSetName = "База_данных_доставки_еды_1_версияDataSet";
            this.база_данных_доставки_еды_1_версияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // курьерыTableAdapter
            // 
            this.курьерыTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(192, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeliverersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeliverersForm";
            this.Text = "Курьеры";
            this.Load += new System.EventHandler(this.DeliverersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курьерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public База_данных_доставки_еды_1_версияDataSet база_данных_доставки_еды_1_версияDataSet;
        public System.Windows.Forms.BindingSource курьерыBindingSource;
        public База_данных_доставки_еды_1_версияDataSetTableAdapters.КурьерыTableAdapter курьерыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонКурьераDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}