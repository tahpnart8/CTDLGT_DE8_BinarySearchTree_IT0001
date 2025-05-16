using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_De8_BinarySearchTree
{
    public class Account
    {
        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; set; } = 0;
        public int TransactionNum { get; set; } = 0;
        public DateTime AccountDate { get; set; }

        public Account(string accountID, List<Customer> customers, List<Transaction> transactions)
        {
            AccountID = accountID;
            AccountName = Customer.FindName(accountID, customers);
            List<(DateTime, string, int)> TransInfo = Transaction.FindTransInfo(accountID, transactions);
            AccountDate = TransInfo[0].Item1;
            for (int i = 0; i < TransInfo.Count; i++)
            {
                TransactionNum = TransactionNum + 1;
                if (AccountDate.CompareTo(TransInfo[i].Item1) > 0)
                {
                    AccountDate = TransInfo[i].Item1;
                }
                if (TransInfo[i].Item2.Equals(" Nhận tiền"))
                {
                    Balance = Balance + TransInfo[i].Item3;
                }
                else
                {
                    Balance = Balance - TransInfo[i].Item3;
                }
            }
        }
        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("IT1232", Customer.GetCustomers(), Transaction.GetTransaction()));
            accounts.Add(new Account("IT1233", Customer.GetCustomers(), Transaction.GetTransaction()));
            accounts.Add(new Account("IT1234", Customer.GetCustomers(), Transaction.GetTransaction()));
            accounts.Add(new Account("IT1235", Customer.GetCustomers(), Transaction.GetTransaction()));
            return accounts;
        }

        public void Refresh(List<Transaction> transactions)
        {
            TransactionNum = 0;
            Balance = 0;
            List<(DateTime, string, int)> TransInfo = Transaction.FindTransInfo(AccountID, transactions);
            for (int i = 0; i < TransInfo.Count; i++)
            {
                TransactionNum = TransactionNum + 1;
                if (TransInfo[i].Item2.Equals(" Nhận tiền"))
                {
                    Balance = Balance + TransInfo[i].Item3;
                }
                else
                {
                    Balance = Balance - TransInfo[i].Item3;
                }
            }
        }

        public void Refresh(string accountid, List<Customer> customers)
        {
            AccountName = Customer.FindName(accountid, customers);
        }
    }

}
