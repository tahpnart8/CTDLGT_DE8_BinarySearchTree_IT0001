using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class DangKy : Form
    {
        Label missingValue = new Label();
        public DangKy()
        {
            InitializeComponent();
            EnableDoubleBuffering();
            missingValue.AutoSize = true;
            missingValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            missingValue.BackColor = Color.Transparent;
            missingValue.ForeColor = Color.Yellow;
            missingValue.Location = new Point(273, 500);
            missingValue.Name = "missingValue";
            missingValue.Size = new Size(305, 25);
            missingValue.TabIndex = 2;
            this.Controls.Add(missingValue);
            missingValue.Hide();
        }

        private void Register(string username, string password)
        {
            // Thêm tài khoản mới vào SharedData
            SignInAccount.Accounts.Add((username, password));
        }
        public void EnableDoubleBuffering()
        {
            this.DoubleBuffered = true; // Kích hoạt Double Buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {


            if (Account.Text.Trim().Equals("") || Password.Text.Trim().Equals(""))
            {
                missingValue.Text = "Vui lòng nhập đủ tên và mật khẩu";
                missingValue.BringToFront();
                missingValue.Show();
            }
            else
            {
                if (textBox1.Text.Trim().Equals("ABCD"))
                {
                    Register(Account.Text.Trim(), Password.Text.Trim());
                    DialogResult done = MessageBox.Show("Đăng ký thành công. Hãy thử quay về đăng nhập", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (done == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    missingValue.Hide();
                    missingValue.Text = "Mã xác thực không chính xác!";
                    missingValue.BringToFront();
                    missingValue.Show();
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void AccountName_Click(object sender, EventArgs e)
        {

        }
    }
    public static class SignInAccount
    {
        // Danh sách lưu trữ tài khoản
        public static List<(string Username, string Password)> Accounts = new List<(string, string)>
        {
            ("NV01", "abc123") // Tài khoản mặc định
        };
    }
}
