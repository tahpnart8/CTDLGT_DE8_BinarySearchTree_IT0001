using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CTDLGT_De8_BinarySearchTree.Node;

namespace CTDLGT_De8_BinarySearchTree
{
    public partial class QuanLyHoSo : Form
    {
        public BinarySearchTree BST = new BinarySearchTree();
        public QuanLyHoSo()
        {
            InitializeComponent();
        }

        public QuanLyHoSo(string name)
        {
            InitializeComponent();
            Username.Text = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (logout == DialogResult.OK)
            {
                DangNhap dn = new DangNhap();
                this.Close();
                dn.ShowDialog();
            }
        }

        private void QLTK_Click(object sender, EventArgs e)
        {
            hoSotk1.Visible = true;
            hoSotk1.BringToFront();
        }

        private void QLGD_Click(object sender, EventArgs e)
        {
            hoSotk1.Visible = false;
            quanLygd1.Visible = true;
            quanLygd1.BringToFront();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void quanLygd1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void hoSotk1_Load(object sender, EventArgs e)
        {

        }

        private void XinChao_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
