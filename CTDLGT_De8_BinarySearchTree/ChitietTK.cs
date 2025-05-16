using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class ChitietTK : Form
    {
        public static List<Customer> Customers;
        public static Account accountFound;
        public ChitietTK()
        {
            InitializeComponent();
        }
        public ChitietTK(Account account, List<Customer> customers, List<Transaction> transactions)
        {
            accountFound = account;
            Customers = customers;
            InitializeComponent();
            soTK.Text = account.AccountID;
            TenTK.Text = account.AccountName;
            soduTK.Text = account.Balance.ToString();
            solanGD.Text = account.TransactionNum.ToString();
            NgaytaoTK.Text = account.AccountDate.ToString();
            Birth.Text = Customer.FindInfo(account.AccountID, customers).Birthday.ToString();
            SDT.Text = Customer.FindInfo(account.AccountID, customers).PhoneNumber.ToString();
            Email.Text = Customer.FindInfo(account.AccountID, customers).Email.ToString();
            DiaChi.Text = Customer.FindInfo(account.AccountID, customers).Address.ToString();
            this.AddTransaction(Transaction.GetTransactionsInfo(account.AccountID, transactions));
        }
        public void AddTransaction(List<Transaction> transactions)
        {
            dataGridView2.DataSource = transactions;
            TransactionID.DataPropertyName = "TransactionID";
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionType.DataPropertyName = "TransactionType";
            Account.DataPropertyName = "Account";
            Amount.DataPropertyName = "Amount";
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TenTK.Enabled = true;
            Birth.Enabled = true;
            SDT.Enabled = true;
            DiaChi.Enabled = true;
            Email.Enabled = true;
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.LightYellow;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckUpdate(TenTK.Text.Trim(), Birth.Value, SDT.Text.Trim(), Email.Text.Trim()))
            {
                return;
            }
            else
            {
                Customer.Update(soTK.Text.Trim(), TenTK.Text.Trim(), Birth.Value, SDT.Text.Trim(), DiaChi.Text.Trim(), Email.Text.Trim(), Customers);
                accountFound.Refresh(soTK.Text, Customers);
                MessageBox.Show("Cập nhật thành công", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckUpdate(string customerName, DateTime birthdate, string phoneNumber, string Email)
        {
            bool check = false;
            if (!(Regex.IsMatch(customerName.Trim(), @"^[\p{L}\s]+$")))
            {
                label13.Text = "Tên tài khoản không hợp lệ";
                label13.Visible = true;
                return true;
            }
            //tuổi phải đủ 16
            if (DateTime.Now.CompareTo(birthdate.AddYears(16)) < 0)
            {
                label13.Text = "Khách hàng chưa đủ 16 tuổi\nđể mở tài khoản!";
                label13.Visible = true;
                return true;
            }
            //SDT là chuỗi 10 chữ số không được trùng
            if (!(Regex.IsMatch(phoneNumber.Trim(), @"^[0-9]{10}$")))
            {
                label13.Text = "Số điện thoại phải là\nchuỗi 10 chữ số!";
                label13.Visible = true;
                return true;
            }
            if (!(Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]{3,64}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")))
            {
                label13.Text = "Email không hợp lệ";
                label13.Visible = true;
                return true;
            }
            return check;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
