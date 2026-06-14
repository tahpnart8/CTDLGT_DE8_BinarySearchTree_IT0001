using System.Security.Principal;

namespace CTDLGT_De8_BinarySearchTree
{
    partial class DangKy
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
            label3 = new Label();
            textBox1 = new TextBox();
            signinButton = new Button();
            panel1 = new Panel();
            Password = new TextBox();
            Account = new TextBox();
            PasswordNo = new Label();
            AccountName = new Label();
            SignIn = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 10F);
            label3.ForeColor = Color.FromArgb(31, 80, 115);
            label3.Location = new Point(225, 378);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 21);
            label3.TabIndex = 5;
            label3.Text = "Nhập mã xác thực cấp từ HR";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Tahoma", 10F);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(225, 402);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  Nhập \"ABCD\"";
            textBox1.Size = new Size(214, 28);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.FromArgb(239, 166, 182);
            signinButton.FlatStyle = FlatStyle.Popup;
            signinButton.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            signinButton.ForeColor = Color.FromArgb(31, 80, 115);
            signinButton.Location = new Point(513, 397);
            signinButton.Margin = new Padding(2, 3, 2, 3);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(101, 33);
            signinButton.TabIndex = 8;
            signinButton.Text = "Đăng ký";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Account);
            panel1.Controls.Add(PasswordNo);
            panel1.Controls.Add(AccountName);
            panel1.Controls.Add(SignIn);
            panel1.Location = new Point(201, 171);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 204);
            panel1.TabIndex = 9;
            // 
            // Password
            // 
            Password.BackColor = Color.Silver;
            Password.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ActiveCaptionText;
            Password.Location = new Point(26, 163);
            Password.Margin = new Padding(2, 3, 2, 3);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(387, 32);
            Password.TabIndex = 0;
            // 
            // Account
            // 
            Account.BackColor = Color.Silver;
            Account.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Account.ForeColor = SystemColors.ActiveCaptionText;
            Account.Location = new Point(26, 84);
            Account.Margin = new Padding(2, 3, 2, 3);
            Account.Name = "Account";
            Account.Size = new Size(387, 32);
            Account.TabIndex = 0;
            Account.WordWrap = false;
            // 
            // PasswordNo
            // 
            PasswordNo.AutoSize = true;
            PasswordNo.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordNo.ForeColor = Color.FromArgb(117, 84, 174);
            PasswordNo.Location = new Point(24, 131);
            PasswordNo.Margin = new Padding(2, 0, 2, 0);
            PasswordNo.Name = "PasswordNo";
            PasswordNo.Size = new Size(123, 29);
            PasswordNo.TabIndex = 2;
            PasswordNo.Text = "Mật khẩu";
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.FromArgb(117, 84, 174);
            AccountName.Location = new Point(24, 52);
            AccountName.Margin = new Padding(2, 0, 2, 0);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(175, 29);
            AccountName.TabIndex = 1;
            AccountName.Text = "Tên tài khoản";
            AccountName.Click += AccountName_Click;
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            SignIn.ForeColor = Color.FromArgb(117, 84, 174);
            SignIn.Location = new Point(156, 16);
            SignIn.Margin = new Padding(2, 0, 2, 0);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(154, 36);
            SignIn.TabIndex = 0;
            SignIn.Text = "ĐĂNG KÝ";
            SignIn.Click += SignIn_Click;
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
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(9, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 29);
            label2.TabIndex = 1;
            label2.Text = "ĐĂNG KÝ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(824, 3);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 29);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(341, 444);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 20);
            label4.TabIndex = 11;
            label4.Text = "Bạn đã có tài khoản rồi ư?";
            label4.Click += label4_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FINOVATEWallet;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 485);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(signinButton);
            Controls.Add(textBox1);
            Controls.Add(label3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKy";
            Load += DangKy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox1;
        private Button signinButton;
        private Panel panel1;
        private TextBox Password;
        private TextBox Account;
        private Label PasswordNo;
        private Label AccountName;
        private Label SignIn;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}