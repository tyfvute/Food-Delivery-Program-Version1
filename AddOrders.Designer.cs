namespace FoodDeliveryVersion1
{
    partial class AddOrders
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
            this.button2 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.база_данных_доставки_еды_1_версияDataSet = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSet();
            this.cbDeliverer = new System.Windows.Forms.ComboBox();
            this.курьерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.клиентыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.КлиентыTableAdapter();
            this.клиентыЗаказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.ЗаказыTableAdapter();
            this.курьерыTableAdapter = new FoodDeliveryVersion1.База_данных_доставки_еды_1_версияDataSetTableAdapters.КурьерыTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курьерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыЗаказыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.CausesValidation = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(203, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(12, 203);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 34);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dtpDeliveryDate);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.tbPayment);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Controls.Add(this.cbDeliverer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 185);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(106, 99);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(174, 20);
            this.dtpDeliveryDate.TabIndex = 28;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(106, 73);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(174, 20);
            this.dtpOrderDate.TabIndex = 27;
            // 
            // tbPayment
            // 
            this.tbPayment.Location = new System.Drawing.Point(106, 151);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(174, 20);
            this.tbPayment.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Способ Оплаты";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(106, 125);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(174, 20);
            this.tbStatus.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Статус Заказа";
            // 
            // cbClient
            // 
            this.cbClient.CausesValidation = false;
            this.cbClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.клиентыBindingSource, "ID_Клиента", true));
            this.cbClient.DataSource = this.клиентыBindingSource;
            this.cbClient.DisplayMember = "Имя_Клиента";
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(106, 19);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(174, 21);
            this.cbClient.TabIndex = 22;
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
            // cbDeliverer
            // 
            this.cbDeliverer.CausesValidation = false;
            this.cbDeliverer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.курьерыBindingSource, "ID_Курьера", true));
            this.cbDeliverer.DataSource = this.курьерыBindingSource;
            this.cbDeliverer.DisplayMember = "Имя_Курьера";
            this.cbDeliverer.FormattingEnabled = true;
            this.cbDeliverer.Location = new System.Drawing.Point(106, 46);
            this.cbDeliverer.Name = "cbDeliverer";
            this.cbDeliverer.Size = new System.Drawing.Size(174, 21);
            this.cbDeliverer.TabIndex = 21;
            // 
            // курьерыBindingSource
            // 
            this.курьерыBindingSource.DataMember = "Курьеры";
            this.курьерыBindingSource.DataSource = this.база_данных_доставки_еды_1_версияDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата Доставки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата Заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Курьер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Клиент";
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыЗаказыBindingSource
            // 
            this.клиентыЗаказыBindingSource.DataMember = "КлиентыЗаказы";
            this.клиентыЗаказыBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // курьерыTableAdapter
            // 
            this.курьерыTableAdapter.ClearBeforeFill = true;
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrders";
            this.Text = "Добавление заказов";
            this.Load += new System.EventHandler(this.AddOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных_доставки_еды_1_версияDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курьерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыЗаказыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbDeliverer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private База_данных_доставки_еды_1_версияDataSet база_данных_доставки_еды_1_версияDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыЗаказыBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource курьерыBindingSource;
        private База_данных_доставки_еды_1_версияDataSetTableAdapters.КурьерыTableAdapter курьерыTableAdapter;
    }
}