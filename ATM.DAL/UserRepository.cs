using ATM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
    public class UserRepository
    {
        private string _connectionString { get; set; }
        public ATMDbContext Context { get; set; }
        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
            if (Context == null)
            {
                Context = new ATMDbContext();
            }
        }

        //CRUD

        public int Create(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
            return user.Id;
        }

        public User? GetById(int id)
        {
            User? user = Context.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public User? GetByPhoneNumber(string phoneNumber)
        {
            User? user = Context.Users.FirstOrDefault(u => u.PhoneNumber == phoneNumber);
            return user;
        }

        public IEnumerable<User> Search(string? filterWord)
        { 
            IEnumerable<User> ListUsers = new List<User>();

            ListUsers = Context.Users.Where(u =>
                string.IsNullOrEmpty(filterWord)
                 || u.FirstName.Contains(filterWord)
                 || u.LastName.Contains(filterWord)
                 || u.Email.Contains(filterWord)
                ); 
            return ListUsers;
        }

        public int Update(User user) 
        {
            Context.Users.Update(user);
            Context.SaveChanges();
            return user.Id;
        }

        public void Delete(User user) 
        {
            Context.Users.Remove(user);
            Context.SaveChanges();
        }
    }
}
