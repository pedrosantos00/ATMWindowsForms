using ATM.DAL;
using ATM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Logic
{
    public class BankService
    {
        public BankRepository _bankRepository { get; set; }

        public BankService(BankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        //CRUD

        public int Create(Bank bank)
        {
            int id = 0;
            if (bank == null) throw new ArgumentNullException("Bank");
            if (bank != null) id = _bankRepository.Create(bank);
            return id;
        }

        public Bank? GetById(int id)
        {
            return _bankRepository.GetById(id);
        }

        public List<Bank> Search(string filterword)
        {
            return _bankRepository.Search(filterword).ToList();
        }

        public int Update(Bank bank)
        {
            return _bankRepository.Update(bank);
        }

        public void Delete(int id)
        {
            Bank? bank = _bankRepository.GetById(id);
            _bankRepository.Delete(bank);
        }

        public void Delete(Bank bank)
        {
            _bankRepository.Delete(bank);
        }

        
    }
}
