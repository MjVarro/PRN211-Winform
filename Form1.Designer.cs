namespace DemoListOrders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            dtpTo = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            cbCustomers = new ComboBox();
            cbEmployees = new ComboBox();
            btAddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 198);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1018, 321);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btAddOrder);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpTo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpFrom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbCustomers);
            groupBox1.Controls.Add(cbEmployees);
            groupBox1.Location = new Point(43, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(948, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 82);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 8;
            label5.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(599, 77);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(153, 27);
            dtpTo.TabIndex = 7;
            dtpTo.ValueChanged += dtpTo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 82);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 29);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 5;
            label3.Text = "OrderDate";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(360, 77);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(153, 27);
            dtpFrom.TabIndex = 4;
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Employee";
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(110, 79);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(151, 28);
            cbCustomers.TabIndex = 1;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(110, 26);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(151, 28);
            cbEmployees.TabIndex = 0;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // btAddOrder
            // 
            btAddOrder.Location = new Point(784, 37);
            btAddOrder.Name = "btAddOrder";
            btAddOrder.Size = new Size(140, 65);
            btAddOrder.TabIndex = 9;
            btAddOrder.Text = "Add An Order";
            btAddOrder.UseVisualStyleBackColor = true;
            btAddOrder.Click += btAddOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 564);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label5;
        private DateTimePicker dtpTo;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFrom;
        private Label label2;
        private Label label1;
        private ComboBox cbCustomers;
        private ComboBox cbEmployees;
        private Button btAddOrder;
    }
}