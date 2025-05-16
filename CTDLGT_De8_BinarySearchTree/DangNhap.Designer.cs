namespace CTDLGT_De8_BinarySearchTree
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            panel1 = new Panel();
            Password = new TextBox();
            Account = new TextBox();
            PasswordNo = new Label();
            AccountName = new Label();
            SignIn = new Label();
            CreateNewAccount = new Label();
            signinButton = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Password);
            panel1.Controls.Add(Account);
            panel1.Controls.Add(PasswordNo);
            panel1.Controls.Add(AccountName);
            panel1.Controls.Add(SignIn);
            panel1.Location = new Point(189, 179);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 216);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Password
            // 
            Password.BackColor = Color.Silver;
            Password.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.ForeColor = SystemColors.ActiveCaptionText;
            Password.Location = new Point(45, 165);
            Password.Margin = new Padding(2, 3, 2, 3);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "  Mật khẩu có sẵn: abc123";
            Password.Size = new Size(387, 32);
            Password.TabIndex = 0;
            Password.Click += Password_Click;
            Password.TextChanged += Password_TextChanged;
            // 
            // Account
            // 
            Account.BackColor = Color.Silver;
            Account.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Account.ForeColor = SystemColors.ActiveCaptionText;
            Account.Location = new Point(45, 88);
            Account.Margin = new Padding(2, 3, 2, 3);
            Account.Name = "Account";
            Account.PlaceholderText = "Tài khoản có sẵn: NV01";
            Account.Size = new Size(387, 32);
            Account.TabIndex = 0;
            Account.WordWrap = false;
            Account.Click += Account_Click;
            // 
            // PasswordNo
            // 
            PasswordNo.AutoSize = true;
            PasswordNo.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordNo.ForeColor = Color.FromArgb(117, 84, 174);
            PasswordNo.Location = new Point(45, 133);
            PasswordNo.Margin = new Padding(2, 0, 2, 0);
            PasswordNo.Name = "PasswordNo";
            PasswordNo.Size = new Size(123, 29);
            PasswordNo.TabIndex = 2;
            PasswordNo.Text = "Mật khẩu";
            PasswordNo.Click += PasswordNo_Click;
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.FromArgb(117, 84, 174);
            AccountName.Location = new Point(45, 56);
            AccountName.Margin = new Padding(2, 0, 2, 0);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(189, 29);
            AccountName.TabIndex = 1;
            AccountName.Text = "Tên đăng nhập";
            // 
            // SignIn
            // 
            SignIn.AutoSize = true;
            SignIn.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            SignIn.ForeColor = Color.FromArgb(117, 84, 174);
            SignIn.Location = new Point(154, 11);
            SignIn.Margin = new Padding(2, 0, 2, 0);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(200, 36);
            SignIn.TabIndex = 0;
            SignIn.Text = "ĐĂNG NHẬP";
            SignIn.Click += SignIn_Click;
            // 
            // CreateNewAccount
            // 
            CreateNewAccount.AutoSize = true;
            CreateNewAccount.BackColor = Color.Transparent;
            CreateNewAccount.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            CreateNewAccount.ForeColor = Color.FromArgb(31, 80, 115);
            CreateNewAccount.Location = new Point(317, 444);
            CreateNewAccount.Margin = new Padding(2, 0, 2, 0);
            CreateNewAccount.Name = "CreateNewAccount";
            CreateNewAccount.Size = new Size(255, 20);
            CreateNewAccount.TabIndex = 6;
            CreateNewAccount.Text = "Nhân viên mới? Tạo tài khoản tại đây";
            CreateNewAccount.Click += CreateNewAccount_Click;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.FromArgb(239, 166, 182);
            signinButton.FlatStyle = FlatStyle.Popup;
            signinButton.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            signinButton.ForeColor = Color.FromArgb(31, 80, 115);
            signinButton.Location = new Point(381, 401);
            signinButton.Margin = new Padding(2, 3, 2, 3);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(123, 40);
            signinButton.TabIndex = 5;
            signinButton.Text = "Đăng nhập";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
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
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(9, 4);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 29);
            label2.TabIndex = 1;
            label2.Text = "ĐĂNG NHẬP";
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
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(869, 485);
            Controls.Add(panel2);
            Controls.Add(CreateNewAccount);
            Controls.Add(panel1);
            Controls.Add(signinButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "DangNhap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label PasswordNo;
        private Label AccountName;
        private Label SignIn;
        private TextBox Account;
        private TextBox Password;
        private Button signinButton;
        private Label CreateNewAccount;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}
