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
        public ATMDbContext _context { get; set; }
        public BankRepository(ATMDbContext? context, string connectionstring)
        {
            _connectionString = connectionstring;
            if (this._context== null) this._context = context;
        }

        public BankRepository(ATMDbContext context)
        {
            if (this._context == null) this._context = context;
        }

        public BankRepository(string connectionstring)
        {
            _connectionString = connectionstring;
            if (this._context == null) this._context = new ATMDbContext();
        }

        //CRUD
        public int Create(Bank bank)
        {
            _context.Banks.Add(bank);
            _context.SaveChanges();
            return bank.Id;
        }

        public Bank? GetById (int id) 
        {
            Bank? filteredBank = _context.Banks.FirstOrDefault(b => b.Id == id);
            return filteredBank;
        }

        public IEnumerable<Bank> Search(string searchFilter)
        {
            IEnumerable<Bank> filteredBanks = new List<Bank>();
            filteredBanks =
                _context.Banks.Where(b =>
                string.IsNullOrEmpty(searchFilter)
                || b.BankName.Contains(searchFilter)
                   );
            return filteredBanks;
        }

        public int Update(Bank bank)
        {
            _context.Banks.Update(bank);
            _context.SaveChanges();
            return bank.Id;
        }

        public void Delete(Bank bank)
        {
            _context.Banks.Remove(bank);
            _context.SaveChanges();
        }

      
    }
}
