using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CTDLGT_De8_BinarySearchTree
{
    partial class QuanLyHoSo
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LogOut = new Button();
            QLGD = new Button();
            QLTK = new Button();
            Username = new Label();
            XinChao = new Label();
            hoSotk1 = new HoSoTK();
            quanLygd1 = new QuanLyGD();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(117, 84, 174);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(869, 35);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(9, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(827, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 29);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(189, 152, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LogOut);
            panel1.Controls.Add(QLGD);
            panel1.Controls.Add(QLTK);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(XinChao);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 450);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(59, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.FromArgb(239, 166, 182);
            LogOut.FlatStyle = FlatStyle.Popup;
            LogOut.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Navy;
            LogOut.Location = new Point(59, 407);
            LogOut.Margin = new Padding(2, 3, 2, 3);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(92, 31);
            LogOut.TabIndex = 14;
            LogOut.Text = "Đăng xuất";
            LogOut.TextAlign = ContentAlignment.TopCenter;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click;
            // 
            // QLGD
            // 
            QLGD.BackColor = Color.FromArgb(201, 212, 250);
            QLGD.Cursor = Cursors.Hand;
            QLGD.FlatStyle = FlatStyle.Popup;
            QLGD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QLGD.Location = new Point(9, 276);
            QLGD.Margin = new Padding(2, 3, 2, 3);
            QLGD.Name = "QLGD";
            QLGD.Size = new Size(142, 35);
            QLGD.TabIndex = 13;
            QLGD.Text = "Quản lý Giao dịch";
            QLGD.UseVisualStyleBackColor = false;
            QLGD.Click += QLGD_Click;
            // 
            // QLTK
            // 
            QLTK.BackColor = Color.FromArgb(201, 212, 250);
            QLTK.Cursor = Cursors.Hand;
            QLTK.FlatStyle = FlatStyle.Popup;
            QLTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QLTK.Location = new Point(9, 227);
            QLTK.Margin = new Padding(2, 3, 2, 3);
            QLTK.Name = "QLTK";
            QLTK.Size = new Size(142, 35);
            QLTK.TabIndex = 12;
            QLTK.Text = "Quản lý Tài khoản";
            QLTK.UseVisualStyleBackColor = false;
            QLTK.Click += QLTK_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Username.ForeColor = SystemColors.ControlLightLight;
            Username.Location = new Point(46, 82);
            Username.Margin = new Padding(2, 0, 2, 0);
            Username.Name = "Username";
            Username.Size = new Size(72, 28);
            Username.TabIndex = 11;
            Username.Text = "Name";
            Username.TextAlign = ContentAlignment.MiddleCenter;
            Username.Click += Username_Click;
            // 
            // XinChao
            // 
            XinChao.AutoSize = true;
            XinChao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XinChao.ForeColor = SystemColors.ControlLightLight;
            XinChao.Location = new Point(37, 59);
            XinChao.Margin = new Padding(2, 0, 2, 0);
            XinChao.Name = "XinChao";
            XinChao.Size = new Size(90, 23);
            XinChao.TabIndex = 10;
            XinChao.Text = "Xin chào!!";
            XinChao.Click += XinChao_Click;
            // 
            // hoSotk1
            // 
            hoSotk1.Location = new Point(167, 36);
            hoSotk1.Margin = new Padding(1);
            hoSotk1.Name = "hoSotk1";
            hoSotk1.Size = new Size(702, 449);
            hoSotk1.TabIndex = 10;
            hoSotk1.Visible = false;
            hoSotk1.Load += hoSotk1_Load;
            // 
            // quanLygd1
            // 
            quanLygd1.BackColor = SystemColors.ControlLightLight;
            quanLygd1.ForeColor = SystemColors.ControlText;
            quanLygd1.Location = new Point(167, 35);
            quanLygd1.Margin = new Padding(1);
            quanLygd1.Name = "quanLygd1";
            quanLygd1.Size = new Size(702, 449);
            quanLygd1.TabIndex = 11;
            quanLygd1.Visible = false;
            quanLygd1.Load += quanLygd1_Load;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.quanly;
            pictureBox2.Location = new Point(167, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(706, 450);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // QuanLyHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(869, 485);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(hoSotk1);
            Controls.Add(quanLygd1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "QuanLyHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý hồ sơ";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label XinChao;
        private Label Username;
        private HoSoTK hoSotk1;
        private Button QLTK;
        private Button QLGD;
        private Button LogOut;
        private QuanLyGD quanLygd1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}