namespace CTDLGT_De8_BinarySearchTree
{
    partial class QuanLyGD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label13 = new Label();
            label14 = new Label();
            NgayGD = new DateTimePicker();
            maTKGD = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label1 = new Label();
            transid = new TextBox();
            LoaiGD = new ComboBox();
            button4 = new Button();
            SoTien = new NumericUpDown();
            dataGridView2 = new DataGridView();
            TransactionID = new DataGridViewTextBoxColumn();
            Account = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SoTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(457, 61);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 21);
            label13.TabIndex = 12;
            label13.Text = "Số tiền";
            label13.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(457, 11);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(104, 21);
            label14.TabIndex = 11;
            label14.Text = "Loại giao dịch";
            label14.Visible = false;
            // 
            // NgayGD
            // 
            NgayGD.CalendarFont = new Font("Calibri", 9F, FontStyle.Bold);
            NgayGD.CalendarMonthBackground = Color.FromArgb(201, 212, 250);
            NgayGD.CalendarTitleBackColor = Color.FromArgb(201, 212, 250);
            NgayGD.CalendarTrailingForeColor = Color.FromArgb(201, 212, 250);
            NgayGD.Font = new Font("Calibri", 9F, FontStyle.Bold);
            NgayGD.Format = DateTimePickerFormat.Short;
            NgayGD.Location = new Point(238, 83);
            NgayGD.Margin = new Padding(2, 3, 2, 3);
            NgayGD.Name = "NgayGD";
            NgayGD.Size = new Size(163, 26);
            NgayGD.TabIndex = 4;
            NgayGD.Visible = false;
            // 
            // maTKGD
            // 
            maTKGD.BackColor = Color.White;
            maTKGD.Font = new Font("Calibri", 9F, FontStyle.Bold);
            maTKGD.Location = new Point(238, 36);
            maTKGD.Margin = new Padding(2, 3, 2, 3);
            maTKGD.Name = "maTKGD";
            maTKGD.Size = new Size(163, 26);
            maTKGD.TabIndex = 9;
            maTKGD.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(235, 61);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 8;
            label3.Text = "Ngày giao dịch";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(235, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 21);
            label2.TabIndex = 7;
            label2.Text = "Mã Tài khoản giao dịch";
            label2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Calibri", 9F, FontStyle.Bold);
            button2.Location = new Point(79, 73);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(57, 25);
            button2.TabIndex = 5;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold);
            button1.Location = new Point(15, 73);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(58, 25);
            button1.TabIndex = 4;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 23);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 2;
            label4.Text = "Nhập mã giao dịch";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(141, 144, 226);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(transid);
            panel2.Controls.Add(LoaiGD);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(SoTien);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(NgayGD);
            panel2.Controls.Add(maTKGD);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 143);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(15, 100);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(204, 38);
            label5.TabIndex = 25;
            label5.Text = "Mã giao dịch phải bắt đầu bằng\r\n'GD' và 5 chữ số ở cuối";
            label5.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(235, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 19);
            label1.TabIndex = 24;
            label1.Text = "Lỗi";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // transid
            // 
            transid.BackColor = Color.White;
            transid.Font = new Font("Calibri", 9F, FontStyle.Bold);
            transid.Location = new Point(15, 45);
            transid.Margin = new Padding(2, 3, 2, 3);
            transid.Name = "transid";
            transid.Size = new Size(181, 26);
            transid.TabIndex = 23;
            // 
            // LoaiGD
            // 
            LoaiGD.BackColor = Color.White;
            LoaiGD.FlatStyle = FlatStyle.Flat;
            LoaiGD.FormattingEnabled = true;
            LoaiGD.Items.AddRange(new object[] { " Nhận tiền", " Chuyển tiền" });
            LoaiGD.Location = new Point(457, 33);
            LoaiGD.Margin = new Padding(2, 3, 2, 3);
            LoaiGD.Name = "LoaiGD";
            LoaiGD.Size = new Size(163, 28);
            LoaiGD.TabIndex = 22;
            LoaiGD.Visible = false;
            LoaiGD.SelectedIndexChanged += LoaiGD_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Font = new Font("Calibri", 9F, FontStyle.Bold);
            button4.Location = new Point(634, 31);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(54, 80);
            button4.TabIndex = 14;
            button4.Text = "Info";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // SoTien
            // 
            SoTien.BackColor = Color.White;
            SoTien.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SoTien.ImeMode = ImeMode.Alpha;
            SoTien.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            SoTien.Location = new Point(457, 83);
            SoTien.Margin = new Padding(2, 3, 2, 3);
            SoTien.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            SoTien.Minimum = new decimal(new int[] { 50000, 0, 0, 0 });
            SoTien.Name = "SoTien";
            SoTien.Size = new Size(162, 28);
            SoTien.TabIndex = 5;
            SoTien.TextAlign = HorizontalAlignment.Center;
            SoTien.ThousandsSeparator = true;
            SoTien.Value = new decimal(new int[] { 50000, 0, 0, 0 });
            SoTien.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(239, 166, 182);
            dataGridViewCellStyle1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(117, 84, 174);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { TransactionID, Account, TransactionDate, TransactionType, Amount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 198, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(0, 140);
            dataGridView2.Margin = new Padding(2, 3, 2, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(117, 84, 174);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersWidth = 30;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(701, 307);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // TransactionID
            // 
            TransactionID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TransactionID.HeaderText = "Mã giao dịch";
            TransactionID.MinimumWidth = 8;
            TransactionID.Name = "TransactionID";
            TransactionID.ReadOnly = true;
            TransactionID.Width = 114;
            // 
            // Account
            // 
            Account.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Account.HeaderText = "Số Tài khoản";
            Account.MinimumWidth = 8;
            Account.Name = "Account";
            Account.ReadOnly = true;
            Account.Width = 112;
            // 
            // TransactionDate
            // 
            TransactionDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TransactionDate.HeaderText = "Ngày giao dịch";
            TransactionDate.MinimumWidth = 8;
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            TransactionDate.Width = 125;
            // 
            // TransactionType
            // 
            TransactionType.HeaderText = "Loại giao dịch";
            TransactionType.MinimumWidth = 8;
            TransactionType.Name = "TransactionType";
            TransactionType.ReadOnly = true;
            TransactionType.Width = 150;
            // 
            // Amount
            // 
            Amount.HeaderText = "Số tiền";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 190;
            // 
            // QuanLyGD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView2);
            Controls.Add(panel2);
            Margin = new Padding(2, 3, 2, 3);
            Name = "QuanLyGD";
            Size = new Size(701, 449);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SoTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label13;
        private Label label14;
        private DateTimePicker NgayGD;
        private TextBox maTKGD;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label4;
        private Panel panel2;
        private NumericUpDown SoTien;
        private DataGridView dataGridView2;
        private Button button4;
        private ComboBox LoaiGD;
        private DataGridViewTextBoxColumn TransactionID;
        private DataGridViewTextBoxColumn Account;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn Amount;
        private TextBox transid;
        private Label label1;
        private Label label5;
    }
}
