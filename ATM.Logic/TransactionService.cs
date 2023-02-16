using ATM.DAL;
using ATM.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Logic
{
    public class TransactionService
    {
        public TransactionRepository _transactionRepository { get; set; }

        public TransactionService(TransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        //CRUD

        public int Create(Transaction transaction)
        {
            int id = 0;
            if(transaction == null) throw new ArgumentNullException("transaction");
            if (transaction != null) id = _transactionRepository.Create(transaction);
            return id;
        }

        public int Update(Transaction transaction)
        {
            return _transactionRepository.Update(transaction);
        }

        public Transaction? GetById(int id)
        {
            return _transactionRepository.GetById(id);
        }
        public List<Transaction> GetByUserId(int id)
        {
            return _transactionRepository.GetByUserId(id).ToList();
        }

        public List<Transaction> Search(string filterword, int userId)
        {
            return _transactionRepository.Search(filterword, userId).ToList();
        }

        public void Delete(int id)
        {
            Transaction? transaction = _transactionRepository.GetById(id);
            _transactionRepository.Delete(transaction);
        }

        public void Delete(Transaction transaction)
        {
            _transactionRepository.Delete(transaction);
        }
    }
}
