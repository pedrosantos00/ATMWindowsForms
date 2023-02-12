using ATM.Domain;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
    public class BankRepository
    {
        private string _connectionString { get; set; }
        public ATMDbContext context { get; set; }
        public BankRepository(string connectionstring)
        {
            _connectionString = connectionstring;
            if (context== null)
            {
                context = new ATMDbContext(_connectionString);
            }
        }
        //CRUD
        public int Create(Bank bank)
        {
            context.Banks.Add(bank);
            context.SaveChanges();
            return bank.Id;
        }

        public Bank? GetById (int id) 
        {
            Bank? filteredBank = context.Banks.FirstOrDefault(b => b.Id == id);
            return filteredBank;
        }

        public IEnumerable<Bank> Search(string searchFilter)
        {
            IEnumerable<Bank> filteredBanks = new List<Bank>();
            filteredBanks =
                context.Banks.Where(b =>
                string.IsNullOrEmpty(searchFilter)
                || b.BankName.Contains(searchFilter)
                   );
            return filteredBanks;
        }

        public int Update(Bank bank)
        {
            context.Banks.Update(bank);
            context.SaveChanges();
            return bank.Id;
        }

        public void Delete(Bank bank)
        {
            context.Banks.Remove(bank);
            context.SaveChanges();
        }

      
    }
}
