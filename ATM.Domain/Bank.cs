using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Domain
{
    public class Bank
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public List<User> Users { get; set; }
        public Bank()
        {

        }

    }
}
