using ATM.Domain;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
    public class TransactionRepository
    {
        private string _connectionString { get; set; }
        public ATMDbContext _context { get; set; }
        public TransactionRepository(ATMDbContext? context,string connectionString)
        {
            _connectionString = connectionString;
            if (_context == null) _context = context;

        }

        public TransactionRepository(string connectionstring)
        {
            _connectionString = connectionstring;
            if (this._context == null) this._context = new ATMDbContext();
        }

        public TransactionRepository(ATMDbContext context)
        {
            if (_context == null) _context = context;
        }

        //CRUD

        public int Create (Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transaction.Id;
        }

        public Transaction? GetById(int id)
        {
            Transaction? transaction = _context.Transactions.FirstOrDefault(t => t.Id == id);
            return transaction;
        }

        public IEnumerable<Transaction> GetByUserId(int id)
        {
            IEnumerable<Transaction> transactionsList = new List<Transaction>();
            transactionsList = _context.Transactions.Where(t =>
            t.UserId == id
            );

            return transactionsList;
        }

        public IEnumerable<Transaction> Search(string filterWord)
        {
            IEnumerable<Transaction> transactionsList = new List<Transaction>();
            transactionsList = _context.Transactions.Where(t =>
            string.IsNullOrEmpty(filterWord)
            || t.Name.Contains(filterWord)
            );

            return transactionsList;
        }

        public int Update (Transaction transaction)
        {
            _context.Transactions.Update(transaction);
            _context.SaveChanges();
            return transaction.Id;
        }

        public void Delete (Transaction transaction)
        {
            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
        }

        
    }
}
