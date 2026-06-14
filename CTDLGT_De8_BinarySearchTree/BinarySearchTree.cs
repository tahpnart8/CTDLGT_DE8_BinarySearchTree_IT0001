using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_De8_BinarySearchTree
{
    public class Node
    {
        public Account AccountData { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(Account account)
        {
            AccountData = account;
            Left = Right = null;
        }
    }
    public class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        // Phương thức chèn tài khoản vào cây
        public void Insert(Account account)
        {
            Node newNode = new Node(account);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                // Tìm vị trí chèn
                while (true)
                {
                    parent = current;

                    //Tài khoản mới có ngày tạo nhỏ hơn ngày tạo của nút hiện tại
                    if (account.AccountDate.CompareTo(current.AccountData.AccountDate) <= 0)
                    {
                        current = current.Left;

                        // Chèn nếu không có nút con bên trái
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else if (account.AccountDate.CompareTo(current.AccountData.AccountDate) > 0)
                    {
                        current = current.Right;

                        // Chèn nếu không có nút con bên phải
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        // Xóa nút theo AccountID
        public void DeleteByAccountID(string accountID)
        {
            this.root = Remove(this.root, accountID);
        }

        private Node Remove(Node parent, string accountID)
        {
            if (FindByAccountID(accountID) is null) { return null; }
            else
            {
                DateTime accountDate = FindByAccountID(accountID).AccountDate;
                if (parent == null) return parent;
                if (accountDate.CompareTo(parent.AccountData.AccountDate) < 0) parent.Left = Remove(parent.Left, accountID);
                else if (accountDate.CompareTo(parent.AccountData.AccountDate) > 0) parent.Right = Remove(parent.Right, accountID);
                else //Xóa nút hiện tại
                {
                    // Nếu nút hiện tại có 1 nút con hoặc là lá
                    if (parent.Left == null) return parent.Right;
                    else if (parent.Right == null) return parent.Left;

                    //Nếu nút hiện tại có hai nút con: Lấy nút nhỏ hơn (bên trái)
                    parent.AccountData = MinValueOfNode(parent.Right);
                    parent.Right = Remove(parent.Right, parent.Right.AccountData.AccountID);
                }
                return parent;
            }
        }

        //Tìm GTNN
        public Account FindMin()
        {
            return MinValueOfNode(this.root);
        }

        private Account MinValueOfNode(Node node)
        {
            Account min = node.AccountData;
            while (node.Left != null)
            {
                min = node.Left.AccountData;
                node = node.Left;
            }
            return min;
        }

        // Tìm GTLN
        public Account FindMax()
        {
            return MaxValueOfNode(this.root);
        }

        private Account MaxValueOfNode(Node node)
        {
            Account max = node.AccountData;
            while (node.Right != null)
            {
                max = node.Right.AccountData;
                node = node.Right;
            }
            return max;
        }

        // Phương thức duyệt cây theo trung thứ tự
        public void InOrder(Node theRoot)
        {
            if (theRoot != null)
            {
                InOrder(theRoot.Left);  // Duyệt cây con bên trái
                Console.WriteLine($"Account ID: {theRoot.AccountData.AccountID}, Account Name: {theRoot.AccountData.AccountName}, Balance: {theRoot.AccountData.Balance}, Date: {theRoot.AccountData.AccountDate.ToShortDateString()}");  // In thông tin
                InOrder(theRoot.Right); // Duyệt cây con bên phải
            }
        }

        // Phương thức duyệt cây theo tiền thứ tự
        public void PreOrder(Node theRoot, List<Account> preorder)
        {
            if (!(theRoot == null))
            {
                preorder.Add(theRoot.AccountData);
                PreOrder(theRoot.Left, preorder);
                PreOrder(theRoot.Right, preorder);
            }
        }

        public List<Account> GetPreOrder()
        {
            List<Account> preorder = new List<Account>();
            PreOrder(this.root, preorder);
            return preorder;
        }

        // Phương thức duyệt cây theo hậu thứ tự
        public void PostOrder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                Console.WriteLine($"Account ID: {theRoot.AccountData.AccountID}, Account Name: {theRoot.AccountData.AccountName}, Balance: {theRoot.AccountData.Balance}, Date: {theRoot.AccountData.AccountDate.ToShortDateString()}");  // In thông tin
            }
        }

        // Phương thức tìm kiếm theo Tên
        public List<Account> FindByName(string name)
        {
            List<Account> result = new List<Account>();
            FindByName(root, name, result);
            return result;
        }

        private void FindByName(Node node, string name, List<Account> result)
        {
            if (node != null)
            {
                if (node.AccountData.AccountName.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(node.AccountData);
                }

                FindByName(node.Left, name, result);
                FindByName(node.Right, name, result);
            }
        }


        // Phương thức tìm kiếm theo Số Tài Khoản
        public Account FindByAccountID(string accountID)
        {
            Account account = null;
            FindByAccountID(root, accountID, ref account);
            return account;
        }

        // Dùng PostOrder để duyệt tìm số tài khoản
        private void FindByAccountID(Node theRoot, string accountID, ref Account account)
        {
            if (!(theRoot == null))
            {
                FindByAccountID(theRoot.Left, accountID, ref account);
                FindByAccountID(theRoot.Right, accountID, ref account);
                if (theRoot.AccountData.AccountID.Equals(accountID, StringComparison.OrdinalIgnoreCase))
                {
                    account = theRoot.AccountData;
                }
            }
        }

        // Phương thức tìm kiếm theo khoảng thời gian
        public List<Account> FindByDateRange(DateTime startDate, DateTime endDate)
        {
            List<Account> result = new List<Account>();
            FindByDateRange(root, startDate, endDate, result);
            return result;
        }

        private void FindByDateRange(Node node, DateTime startDate, DateTime endDate, List<Account> result)
        {
            if (node == null) return;

            if (node.AccountData.AccountDate >= startDate && node.AccountData.AccountDate <= endDate)
            {
                result.Add(node.AccountData);
            }

            FindByDateRange(node.Left, startDate, endDate, result);
            FindByDateRange(node.Right, startDate, endDate, result);
        }

        // Phương thức duyệt cây theo thứ tự tăng dần 
        public List<Account> InOrderAscending(Node theRoot)
        {
            List<Account> accounts = new List<Account>();
            InOrderAscending(theRoot, accounts);
            return accounts;
        }

        private void InOrderAscending(Node theRoot, List<Account> accounts)
        {
            if (theRoot != null)
            {
                InOrderAscending(theRoot.Left, accounts);
                accounts.Add(theRoot.AccountData);
                InOrderAscending(theRoot.Right, accounts);
            }
        }
        //Phương thức duyệt cây từ phải qua trái và trả về danh sách tài khoản
        public List<Account> InOrderDescending(Node theRoot)
        {
            List<Account> accounts = new List<Account>();
            InOrderDescending(theRoot, accounts);
            return accounts;
        }

        private void InOrderDescending(Node theRoot, List<Account> accounts)
        {
            if (theRoot != null)
            {
                InOrderDescending(theRoot.Right, accounts);
                accounts.Add(theRoot.AccountData);
                InOrderDescending(theRoot.Left, accounts);
            }
        }

        //Tìm độ sâu của cây
        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.Left), GetTreeDepth(parent.Right)) + 1;
        }
        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.root);
        }
    }
}
