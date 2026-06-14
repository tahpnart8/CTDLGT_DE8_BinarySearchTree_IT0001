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
using System.Transactions;
using System.Windows.Forms;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class QuanLyGD : UserControl
    {
        public List<Account> accountList = HoSoTK.BST.GetPreOrder();
        public static List<Transaction> transactionslist = HoSoTK.TransactionList;
        public Transaction transaction;
        public Account account;
        public QuanLyGD()
        {
            InitializeComponent();
            AddData(transactionslist);

            HoSoTK.OnDataUpdated += DataRefresh;
        }
        public void AddData(List<Transaction> trans)
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = trans;
            TransactionID.DataPropertyName = "TransactionID";
            Account.DataPropertyName = "Account";
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionType.DataPropertyName = "TransactionType";
            Amount.DataPropertyName = "Amount";
        }

        public void DataRefresh()
        {
            transactionslist = HoSoTK.TransactionList;
            accountList = HoSoTK.BST.GetPreOrder();
            AddData(transactionslist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Regex.IsMatch(transid.Text.Trim(), "^GD[0-9]{5}$")))
            {
                label5.Visible = true;
            }
            else
            {
                if (transactionslist.Find(id => id.TransactionID.Equals(transid.Text.Trim())) != null)
                {
                    label5.Visible = false;
                    MessageBox.Show("Mã giao dịch đã tồn tại, vui lòng thử lại mã giao dịch mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label5.Visible = false;
                    label2.Visible = true;
                    label3.Visible = true;
                    label14.Visible = true;
                    label13.Visible = true;
                    maTKGD.Visible = true;
                    LoaiGD.Visible = true;
                    maTKGD.ReadOnly = false;
                    LoaiGD.Enabled = true;
                    NgayGD.Visible = true;
                    SoTien.Visible = true;
                    NgayGD.Enabled = true;
                    SoTien.Enabled = true;
                    button4.UseVisualStyleBackColor = false;
                    button4.BackColor = Color.FromArgb(192, 255, 192);
                    button4.Text = "Thêm GD";
                    button4.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (transactionslist.Find(id => id.TransactionID.Equals(transid.Text.Trim())) == null)
            {
                MessageBox.Show("Không tìm thấy mã giao dịch, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                transaction = transactionslist.Find(trans => trans.TransactionID.Equals(transid.Text.Trim()));
                label5.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                maTKGD.Visible = true;
                maTKGD.Text = transaction.Account;
                LoaiGD.Visible = true;
                LoaiGD.Text = transaction.TransactionType;
                maTKGD.ReadOnly = true;
                LoaiGD.Enabled = false;
                NgayGD.Visible = true;
                NgayGD.Value = transaction.TransactionDate;
                SoTien.Visible = true;
                SoTien.Value = transaction.Amount;
                NgayGD.Enabled = false;
                SoTien.Enabled = false;
                button4.UseVisualStyleBackColor = false;
                button4.BackColor = Color.FromArgb(255, 192, 192);
                button4.Text = "Xóa GD";
                button4.Visible = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Equals("Xóa GD"))
            {
                account = accountList.Find(acc => acc.AccountID.Equals(transaction.Account));
                DialogResult delete = MessageBox.Show("Bạn có chắc muốn xóa giao dịch này?", "Xóa giao dịch", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (delete == DialogResult.OK)
                {
                    if (transaction.TransactionDate.CompareTo(account.AccountDate) == 0)
                    {
                        MessageBox.Show("Đây là giao dịch tạo tài khoản. Không thể xóa giao dịch này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        transactionslist.Remove(transaction);
                        account.Refresh(transactionslist);
                        MessageBox.Show("Xóa giao dịch thành công", "Xóa giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AddData(transactionslist);
                    }
                }
            }
            else if (button4.Text.Equals("Thêm GD"))
            {
                if (CheckTrans(maTKGD.Text.Trim(), NgayGD.Value, LoaiGD.Text.Trim(), (int)SoTien.Value)) { return; }
                else
                {
                    account = accountList.Find(acc => acc.AccountID.Equals(maTKGD.Text.Trim()));
                    transactionslist.Add(new Transaction(transid.Text.Trim(), maTKGD.Text.Trim(), NgayGD.Value, LoaiGD.Text, (int)SoTien.Value));
                    account.Refresh(transactionslist);
                    MessageBox.Show("Thêm giao dịch thành công", "Thêm giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddData(transactionslist);
                }
            }

            // Trả về ô trống
            maTKGD.Text = string.Empty;
            NgayGD.Value = DateTime.Now;
            LoaiGD.Text = string.Empty;
            SoTien.Value = 50000;
            maTKGD.Visible = false;
            NgayGD.Visible = false;
            SoTien.Visible = false;
            LoaiGD.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            button4.Visible = false;
        }

        private bool CheckTrans(string accountID, DateTime TransactionDate, string TransactionType, int amount)
        {
            bool check = false;
            if (string.IsNullOrEmpty(accountID))
            {
                label1.Text = "Vui lòng nhập Số Tài khoản";
                label1.Visible = true;
                return true;
            }
            else
            {
                if (!(Regex.IsMatch(accountID, "^IT[0-9]{4}$")))
                {
                    label1.Text = "Số tài khoản là chuỗi bắt đầu bằng 'IT' và 4 chữ số theo sau";
                    label1.Visible = true;
                    return true;
                }
                Account accountFound = accountList.Find(id => id.AccountID.Equals(accountID));
                if (accountFound == null)
                {
                    label1.Text = "Không tìm thấy tài khoản.";
                    label1.Visible = true;
                    return true;
                }
                // Kiểm tra nếu account đã tồn tại thì ngày giao dịch phải sau ngày tạo tài khoản
                else if (TransactionDate.CompareTo(accountFound.AccountDate) < 0)
                {
                    label1.Text = "Ngày giao dịch không thể trước ngày tạo tài khoản.";
                    label1.Visible = true;
                    return true;
                }
                else if (TransactionType != "Nhận tiền" && TransactionType != "Chuyển tiền")
                {
                    label1.Text = "Không nhận dạng được loại giao dịch";
                    label1.Visible = true;
                    return true;
                }
                else
                {
                    if (TransactionType == "Chuyển tiền" && (amount > accountFound.Balance))
                    {
                        MessageBox.Show("Không đủ số dư để thực hiện giao dịch", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                }
            }
            return check;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
