using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_De8_BinarySearchTree
{
    public class Transaction
    {
        public string TransactionID { get; set; }
        public string Account {  get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public int Amount { get; set; }

        public Transaction(string transactionID, string account, DateTime transactionDate, string transactionType, int amount)
        {
            TransactionID = transactionID;
            Account = account;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
            Amount = amount;
        }


        public static List<Transaction> GetTransaction()
        {
            List<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction("GD00001", "IT1234", new DateTime(2025, 01, 22, 08, 19, 22), " Nhận tiền", 200000));
            transactions.Add(new Transaction("GD00002", "IT1232", new DateTime(2025, 03, 25, 12, 15, 10), " Nhận tiền", 500000));
            transactions.Add(new Transaction("GD00003", "IT1233", new DateTime(2025, 02, 22, 19, 26, 11), " Nhận tiền", 50000));
            transactions.Add(new Transaction("GD00004", "IT1233", new DateTime(2025, 01, 29, 09, 47, 5), " Chuyển tiền", 10000));
            transactions.Add(new Transaction("GD00005", "IT1234", new DateTime(2025, 04, 03, 08, 19, 22), " Chuyển tiền", 50000));
            transactions.Add(new Transaction("GD00006", "IT1232", new DateTime(2025, 04, 05, 12, 15, 10), " Chuyển tiền", 100000));
            transactions.Add(new Transaction("GD00007", "IT1233", new DateTime(2025, 03, 09, 09, 47, 5), " Nhận tiền", 200000));
            transactions.Add(new Transaction("GD00008", "IT1235", new DateTime(2025, 01, 01, 10, 27, 31), " Nhận tiền", 200000));
            return transactions;
        }

        public static List<(DateTime, string, int)> FindTransInfo(string AccountID, List<Transaction> infolist)
        {
            List<Transaction> info = GetTransactionsInfo(AccountID, infolist);
            var result = new List<(DateTime, string, int)>();
            foreach (var i in info)
            {
                result.Add((i.TransactionDate, i.TransactionType, i.Amount));
            }
            return result;
        }

        public static List<Transaction> GetTransactionsInfo(string AccountID, List<Transaction> info)
        {
            List<Transaction> transactions = new List<Transaction>();
            foreach(Transaction transaction in info)
            {
                if(transaction.Account.Equals(AccountID))
                {
                    transactions.Add(transaction);
                }
            }
            return transactions;
        }         
    }
}
