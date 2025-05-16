using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDLGT_De8_BinarySearchTree
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string AccountID { get; set; }


        public Customer(string customerID, string customerName, string phoneNumber, DateTime birthday, string address, string email, string accountID)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Address = address;
            Email = email;
            AccountID = accountID;
        }
        public static List<Customer> GetCustomers()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer("6599", "Trần Đức Phát", "0935594813", new DateTime(2006, 03, 18), "Nguyễn Văn Đậu, Quận Bình Thạnh, TP.Hồ Chí Minh", "phattran.31241026599@st.ueh.edu.vn", "IT1232"));
            customer.Add(new Customer("2162", "Nguyễn Hoàng Phúc", "0902159560", new DateTime(2006, 09, 06), "Linh Xuân, Quận Thủ Đức, TP.Hồ Chí Minh", "phucnguyen.31241022162@st.ueh.edu.vn", "IT1233"));
            customer.Add(new Customer("4669", "Nguyễn Thúy Ngân", "0774807235", new DateTime(2006, 12, 05), "Phạm Văn Hai, Quận Tân Bình, TP.Hồ Chí Minh", "ngannguyen.31241024669@st.ueh.edu.vn", "IT1234"));
            customer.Add(new Customer("5839", "Phạm Minh Thư", "0983841732", new DateTime(2006, 04, 24), "Nguyễn Văn Linh, Huyện Bình Chánh, TP.Hồ Chí Minh", "thupham.31241025839@st.ueh.edu.vn", "IT1235"));
            return customer;
        }

        //Tìm tên
        public static string FindName(string accountID, List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                if (customer.AccountID == accountID)
                {
                    return customer.CustomerName;
                }
            }
            return null;
        }

        //Tìm thông tin
        public static Customer FindInfo(string accountID, List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                if (customer.AccountID == accountID)
                {
                    return customer;
                }
            }
            return null;
        }

        //Cập nhật thông tin
        public static void Update(string customerID, string name, DateTime birth, string phone, string address, string email, List<Customer> list)
        {
            Customer customer = FindInfo(customerID, list);
            customer.CustomerName = name;
            customer.Address = address;
            customer.Email = email;
            customer.Birthday = birth;
            customer.PhoneNumber = phone;
            list.Remove(customer);
            list.Add(customer);
        }
    }
}
