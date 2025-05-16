using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static CTDLGT_De8_BinarySearchTree.Node;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class HoSoTK : UserControl
    {
        public static BinarySearchTree BST = new BinarySearchTree();
        public static List<Transaction> TransactionList = Transaction.GetTransaction();
        public static List<Customer> CustomerList = Customer.GetCustomers();
        public static List<Account> AccountList = Account.GetAccounts(); // AccountList dùng để Insert vào BST lúc khởi tạo
        public static event Action OnDataUpdated;
        public HoSoTK()
        {
            InitializeComponent();
            if (BST.root == null)
            {
                foreach (Account account in AccountList)
                {
                    BST.Insert(account);
                }
            }
            List<Account> accounts = BST.GetPreOrder();
            this.AddData(accounts);
        }

        public void AddData(List<Account> accounts)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = accounts;
            AccountID.DataPropertyName = "AccountID";
            AccountName.DataPropertyName = "AccountName";
            Balance.DataPropertyName = "Balance";
            TransactionNumber.DataPropertyName = "TransactionNum";
            AccountDate.DataPropertyName = "AccountDate";
        }

        public void AddData2(Account account)
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = null;
            List<Account> accounts = [account];
            dataGridView2.DataSource = accounts;
            dataGridViewTextBoxColumn1.DataPropertyName = "AccountID";
            dataGridViewTextBoxColumn2.DataPropertyName = "AccountName";
            dataGridViewTextBoxColumn3.DataPropertyName = "Balance";
            dataGridViewTextBoxColumn4.DataPropertyName = "TransactionNum";
            dataGridViewTextBoxColumn5.DataPropertyName = "AccountDate";
        }
        private void ComboBox_SelectedChanged(object sender, EventArgs e)
        {
            EnterTN.Text = "";
            if (comboBox1.SelectedItem.Equals(" Số Tài khoản"))
            {
                TextName.Text = "Nhập Số Tài khoản";
                TextName.Visible = true;
                EnterTN.Visible = true;
                TimeName.Visible = false;
                ChonNgay1.Visible = false;
                ChonNgay2.Visible = false;
                Find.Location = new Point(290, 69);
                Find.Visible = true;
                label15.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
            else if (comboBox1.SelectedItem.Equals(" Tên Tài khoản"))
            {
                TextName.Text = "Nhập Tên Tài khoản";
                TextName.Visible = true;
                EnterTN.Visible = true;
                TimeName.Visible = false;
                ChonNgay1.Visible = false;
                ChonNgay2.Visible = false;
                Find.Location = new Point(290, 69);
                Find.Visible = true;
                label15.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
            else if (comboBox1.SelectedItem.Equals(" Thời gian"))
            {
                TextName.Text = "Từ khoảng: ";
                TextName.Visible = true;
                ChonNgay1.Visible = true;
                EnterTN.Visible = false;
                TimeName.Text = "Đến khoảng: ";
                TimeName.Visible = true;
                ChonNgay2.Visible = true;
                Find.Location = new Point(470, 69);
                Find.Visible = true;
                label15.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Account> accounts = dataGridView1.DataSource as List<Account>;
            if (e.RowIndex == -1)
            {
                return;
            }
            ChitietTK chitietTK = new ChitietTK(accounts[e.RowIndex], CustomerList, TransactionList);
            chitietTK.ShowDialog();
        }

        // Xếp mới nhất 
        private void button5_Click(object sender, EventArgs e)
        {
            button6.UseVisualStyleBackColor = true;
            button5.UseVisualStyleBackColor = false;
            button5.BackColor = Color.FromArgb(242, 255, 230);
            button5.ForeColor = Color.FromArgb(0, 102, 0);
            BinarySearchTree BST_date = new BinarySearchTree();
            foreach (Account account in this.dataGridView1.DataSource as List<Account>)
            {
                BST_date.Insert(account);
            }
            List<Account> accounts = BST_date.InOrderDescending(BST_date.root);
            this.AddData(accounts);
        }

        //Xếp cũ nhất   
        private void button6_Click(object sender, EventArgs e)
        {
            button5.UseVisualStyleBackColor = true;
            button6.UseVisualStyleBackColor = false;
            button6.BackColor = Color.FromArgb(242, 255, 230);
            button6.ForeColor = Color.FromArgb(0, 102, 0);
            BinarySearchTree BST_date = new BinarySearchTree();
            foreach (Account account in this.dataGridView1.DataSource as List<Account>)
            {
                BST_date.Insert(account);
            }
            List<Account> accounts = BST_date.InOrderAscending(BST_date.root);
            this.AddData(accounts);
        }

        // Tìm theo STK
        private void FindAccountID(string accountID)
        {
            if (string.IsNullOrEmpty(accountID))
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập Số tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Account accountFound = BST.FindByAccountID(accountID);
                if (accountFound != null)
                {
                    List<Account> accountsFound = [accountFound];
                    this.AddData(accountsFound);
                }
                else
                {
                    DialogResult loi = MessageBox.Show("Không tìm thấy tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Tìm theo tên
        private void FindAccountName(string accountName)
        {
            if (string.IsNullOrEmpty(accountName))
            {
                DialogResult loi = MessageBox.Show("Vui lòng nhập Số tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<Account> accountsFound = BST.FindByName(accountName);
                if (accountsFound.Count < 1)
                {
                    DialogResult loi = MessageBox.Show("Không tìm thấy tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.AddData(accountsFound);
                }
            }
        }

        // Tìm theo khoảng thời gian
        private void FindDateRange(DateTime startdate, DateTime enddate)
        {
            List<Account> accountsFound = BST.FindByDateRange(startdate, enddate);
            this.AddData(accountsFound);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals(" Số Tài khoản"))
            {
                label15.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                FindAccountID(EnterTN.Text.Trim());
            }
            else if (comboBox1.SelectedItem.Equals(" Tên Tài khoản"))
            {
                label15.Location = new Point(476, 46);
                button5.Location = new Point(560, 21);
                button6.Location = new Point(560, 69);
                label15.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                FindAccountName(EnterTN.Text.Trim());
            }
            else
            {
                label15.Location = new Point(540, 46);
                button5.Location = new Point(600, 21);
                button6.Location = new Point(600, 69);
                label15.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                FindDateRange(ChonNgay1.Value, ChonNgay2.Value);
            }
        }

        // Nút xóa tài khoản
        private void button2_Click(object sender, EventArgs e)
        {
            TenTKxoa.Enabled = false;
            soduTKxoa.Enabled = false;
            solanGDxoa.Enabled = false;
            CCCD.Enabled = false;
            TenTK.Enabled = false;
            email.Enabled = false;
            sdt.Enabled = false;
            diachi.Enabled = false;
            maGD.ReadOnly = true;
            loaiGD.Enabled = false;
            sotien.Enabled = false;
            Birth.Enabled = false;
            TenTKxoa.Cursor = Cursors.Arrow;
            soduTKxoa.Cursor = Cursors.Arrow;
            solanGDxoa.Cursor = Cursors.Arrow;
            CCCD.Cursor = Cursors.Arrow;
            maGD.Cursor = Cursors.Arrow;
            loaiGD.Cursor = Cursors.Arrow;
            sotien.Cursor = Cursors.Arrow;
            NgaylapTKxoa.Enabled = false;
            ngayGD.Enabled = false;
            ThemTK.UseVisualStyleBackColor = false;
            ThemTK.BackColor = Color.DimGray;
            ThemTK.Enabled = false;
            Account accountFound = BST.FindByAccountID(ID.Text.Trim());
            if (accountFound is null)
            {
                missingValue.Visible = false;
                AccountError("Không tìm thấy tài khoản!");

            }
            else
            {
                missingValue.Visible = false;
                TenTKxoa.Text = accountFound.AccountName;
                NgaylapTKxoa.Value = accountFound.AccountDate;
                soduTKxoa.Text = accountFound.Balance.ToString();
                solanGDxoa.Text = accountFound.TransactionNum.ToString();
                DialogResult delete = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản và các giao dịch liên quan?", "Cảnh báo xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (delete == DialogResult.OK)
                {

                    // Thực hiện xóa
                    TransactionList.RemoveAll(transaction => transaction.Account.Equals(accountFound.AccountID));
                    CustomerList.RemoveAll(customer => customer.AccountID.Equals(accountFound.AccountID));
                    BST.DeleteByAccountID(accountFound.AccountID);
                    OnDataUpdated?.Invoke();
                    MessageBox.Show("Xóa thành công", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Gỡ đi các thông tin đã hiện
                    TenTKxoa.Text = string.Empty;
                    NgaylapTKxoa.Value = DateTime.Now;
                    soduTKxoa.Text = string.Empty;
                    solanGDxoa.Text = string.Empty;
                }
                AddData(BST.GetPreOrder());
                AddData2(BST.FindByAccountID(ID.Text.Trim()));
            }
        }

        // Hàm hiện thông báo lỗi
        private void AccountError(string text)
        {
            DialogResult loi = MessageBox.Show(text, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TenTKxoa.Enabled = false;
            soduTKxoa.Enabled = false;
            solanGDxoa.Enabled = false;
            CCCD.Enabled = false;
            TenTK.Enabled = false;
            email.Enabled = false;
            sdt.Enabled = false;
            diachi.Enabled = false;
            maGD.ReadOnly = true;
            loaiGD.Enabled = false;
            sotien.Enabled = false;
            Birth.Enabled = false;
            TenTKxoa.Cursor = Cursors.Arrow;
            soduTKxoa.Cursor = Cursors.Arrow;
            solanGDxoa.Cursor = Cursors.Arrow;
            CCCD.Cursor = Cursors.Arrow;
            maGD.Cursor = Cursors.Arrow;
            loaiGD.Cursor = Cursors.Arrow;
            sotien.Cursor = Cursors.Arrow;
            NgaylapTKxoa.Enabled = false;
            ngayGD.Enabled = false;
            ThemTK.UseVisualStyleBackColor = false;
            ThemTK.BackColor = Color.DimGray;
            ThemTK.Enabled = false;
        }

        // Nút thêm tài khoản
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID.Text.Trim())) { missingValue.Visible = false; }
            else if (BST.FindByAccountID(ID.Text.Trim()) != null)
            {
                missingValue.Visible = false;
                AccountError("Tài khoản đã tồn tại. Bạn không thể thêm mới");

            }
            else
            {
                if (!(Regex.IsMatch(ID.Text.Trim(), "^IT[0-9]{4}$")))
                {
                    missingValue.Visible = true;
                }
                else
                {
                    missingValue.Visible = false;
                    TenTKxoa.Enabled = false;
                    soduTKxoa.Enabled = false;
                    solanGDxoa.Enabled = false;
                    TenTKxoa.Cursor = Cursors.Arrow;
                    soduTKxoa.Cursor = Cursors.Arrow;
                    solanGDxoa.Cursor = Cursors.Arrow;
                    NgaylapTKxoa.Enabled = false;
                    TenTK.Enabled = true;
                    email.Enabled = true;
                    sdt.Enabled = true;
                    diachi.Enabled = true;
                    Birth.Enabled = true;
                    CCCD.Enabled = true;
                    maGD.Enabled = true;
                    maGD.ReadOnly = false;
                    loaiGD.Enabled = false;
                    loaiGD.SelectedItem = loaiGD.Items[0];
                    sotien.Enabled = true;
                    ngayGD.Enabled = true;
                    ThemTK.UseVisualStyleBackColor = false;
                    ThemTK.BackColor = Color.FromArgb(0, 102, 0);
                    ThemTK.Enabled = true;
                }
            }
        }

        // Thêm Tài khoản
        private void AddAccount(string accountID)
        {
            Account newacc = new Account(accountID, CustomerList, TransactionList);
            BST.Insert(newacc);
            AddData(BST.GetPreOrder());
        }

        private bool CheckInput(string transactionID, string customerName, string iD, string phoneNumber, DateTime birthdate, string Email)
        {
            bool check = false;
            if (!(Regex.IsMatch(transactionID.Trim(), "^GD[0-9]{5}$")))
            {
                label21.Text = "Mã giao dịch phải bắt đầu bằng\n'GD' và 5 chữ số ở cuối";
                label21.Visible = true;
                return true;
            }
            else
            {
                if (TransactionList.Find(x => x.TransactionID.Equals(transactionID)) != null)
                {
                    label21.Text = "Mã giao dịch đã tồn tại,\nnhập lại mã giao dịch mới";
                    return true;
                }
            }

            //\p{L} khớp với tất cả các ký tự chữ (letter) trong bất kỳ bảng mã ngôn ngữ nào
            if (!(Regex.IsMatch(customerName.Trim(), @"^[\p{L}\s]+$")))
            {
                label21.Text = "Tên tài khoản không hợp lệ";
                label21.Visible = true;
                return true;
            }

            //CCCD là chuỗi gồm 4 chữ số
            if (!(Regex.IsMatch(iD.Trim(), @"^[0-9]{4}$")))
            {
                label21.Text = "CCCD phải là chuỗi 4 chữ số";
                label21.Visible = true;
                return true;
            }

            //SDT là chuỗi 10 chữ số 
            if (!(Regex.IsMatch(phoneNumber.Trim(), @"^[0-9]{10}$")))
            {
                label21.Text = "Số điện thoại phải là\nchuỗi 10 chữ số!";
                label21.Visible = true;
                return true;
            }

            //tuổi phải đủ 16
            if (DateTime.Now.CompareTo(birthdate.AddYears(16)) < 0)
            {
                label21.Text = "Khách hàng chưa đủ 16 tuổi\nđể mở tài khoản!";
                label21.Visible = true;
                return true;
            }

            //Email phải có dạng @gmail.com
            if (!(Regex.IsMatch(Email, @"^[a-zA-z0-9]{3,30}@gmail.com$")))
            {
                label21.Text = "Email không hợp lệ";
                label21.Visible = true;
                return true;
            }
            return check;
        }

        // Thao tác thêm Tài khoản
        private void ThemTK_Click(object sender, EventArgs e)
        {
            if (BST.FindByAccountID(ID.Text.Trim()) != null)
            {
                missingValue.Visible = false;
                AccountError("Tài khoản đã tồn tại. Bạn không thể thêm nữa");

            }
            else if (CheckInput(maGD.Text.Trim(), TenTK.Text.Trim(), CCCD.Text.Trim(), sdt.Text.Trim(), Birth.Value, email.Text.Trim()))
            {
                return;
            }
            else
            {
                label21.Visible = false;
                TransactionList.Add(new Transaction(maGD.Text.Trim(), ID.Text.Trim(), ngayGD.Value, loaiGD.Text, (int)sotien.Value));
                CustomerList.Add(new Customer(CCCD.Text.Trim(), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TenTK.Text.Trim().ToLower()), sdt.Text.Trim(), Birth.Value, diachi.Text.Trim(), email.Text.Trim(), ID.Text.Trim()));
                AddAccount(ID.Text.Trim());
                AddData2(BST.FindByAccountID(ID.Text.Trim()));
                OnDataUpdated?.Invoke();
                MessageBox.Show("Thêm tài khoản thành công", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trả về trạng thái ban đầu
                CCCD.Text = string.Empty;
                TenTK.Text = string.Empty;
                sdt.Text = string.Empty;
                Birth.Value = DateTime.Now;
                diachi.Text = string.Empty;
                email.Text = string.Empty;
                maGD.Text = string.Empty;
                ID.Text = string.Empty;
                ngayGD.Text = string.Empty;
                loaiGD.Text = string.Empty;
                ngayGD.Value = DateTime.Now;
                sotien.Value = 50000;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Account> accounts = dataGridView2.DataSource as List<Account>;
            if (e.RowIndex == -1)
            {
                return;
            }
            ChitietTK chitietTK = new ChitietTK(accounts[e.RowIndex], CustomerList, TransactionList);
            chitietTK.ShowDialog();
        }

        private void missingValue_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
