using System.Xml.Linq;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            EnableDoubleBuffering();
            Account.Text = "";
            Password.Text = "";
        }


        public bool CheckSignIn(string username, string password)
        {
            return SignInAccount.Accounts.Any(account => account.Username.Equals(username) && account.Password.Equals(password));
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            if (CheckSignIn(Account.Text.Trim(), Password.Text.Trim()))
            {
                QuanLyHoSo f = new QuanLyHoSo(Account.Text.Trim());
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (Account.Text.Trim().Equals("") || Password.Text.Trim().Equals(""))
            {
                Label missingValue = new Label();
                missingValue.AutoSize = true;
                missingValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                missingValue.BackColor = Color.Transparent;
                missingValue.ForeColor = Color.Yellow;
                missingValue.Location = new Point(250, 450);
                missingValue.Name = "missingValue";
                missingValue.Size = new Size(305, 25);
                missingValue.TabIndex = 2;
                missingValue.Text = "Vui lòng nhập đủ tên và mật khẩu";
                this.Controls.Add(missingValue);
                missingValue.BringToFront();
                missingValue.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EnableDoubleBuffering()
        {
            this.DoubleBuffered = true; // Kích hoạt Double Buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        private async void CreateNewAccount_Click(object sender, EventArgs e)
        {
            Label loading = new Label();
            loading.Text = "Loading...";
            loading.Font = new Font("Tahoma", 14);
            loading.ForeColor = Color.Black;
            loading.AutoSize = true;
            loading.Location = new Point(2 * (this.Width) / 5, this.Height / 2);
            DangKy f = new DangKy();
            this.Controls.Add(loading);
            loading.BringToFront();
            loading.Show();

            await Task.Delay(1500); // Giả lập thời gian xử lý nặng
            this.Hide();
            f.ShowDialog();
            this.Controls.Remove(loading); // Gỡ thông báo sau khi hoàn tất
            this.Show();
            // Hiển thị form sau khi tác vụ hoàn thành
        }

        private void Account_Click(object sender, EventArgs e)
        {
            Account.Text = "";
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }

        private void PasswordNo_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
