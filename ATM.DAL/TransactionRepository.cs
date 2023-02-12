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
        public ATMDbContext Context { get; set; }
        public TransactionRepository(string connectionString)
        {
            _connectionString = connectionString;
            if (Context == null)
            {
                Context = new ATMDbContext();
            }
        }

        //CRUD

        public int Create (Transaction transaction)
        {
            Context.Transactions.Add(transaction);
            Context.SaveChanges();
            return transaction.Id;
        }

        public Transaction? GetById(int id)
        {
            Transaction? transaction = Context.Transactions.FirstOrDefault(t => t.Id == id);
            return transaction;
        }

        public IEnumerable<Transaction> GetByUserId(int id)
        {
            IEnumerable<Transaction> transactionsList = new List<Transaction>();
            transactionsList = Context.Transactions.Where(t =>
            t.UserId == id
            );

            return transactionsList;
        }

        public IEnumerable<Transaction> Search(string filterWord)
        {
            IEnumerable<Transaction> transactionsList = new List<Transaction>();
            transactionsList = Context.Transactions.Where(t =>
            string.IsNullOrEmpty(filterWord)
            || t.Name.Contains(filterWord)
            );

            return transactionsList;
        }

        public int Update (Transaction transaction)
        {
            Context.Transactions.Update(transaction);
            Context.SaveChanges();
            return transaction.Id;
        }

        public void Delete (Transaction transaction)
        {
            Context.Transactions.Remove(transaction);
            Context.SaveChanges();
        }

        
    }
}
