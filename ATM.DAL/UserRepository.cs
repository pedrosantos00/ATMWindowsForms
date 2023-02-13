using ATM.Domain;
using Microsoft.EntityFrameworkCore;
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
        public ATMDbContext _context { get; set; }
        public UserRepository(ATMDbContext context, string connectionString)
        {
            _connectionString = connectionString;
            if (_context == null) _context = context;

        }

        public UserRepository(string connectionstring)
        {
            _connectionString = connectionstring;
            if (this._context == null) this._context = new ATMDbContext();
        }

        public UserRepository(ATMDbContext context)
        {
            if (_context == null) _context = context;
        }

        //CRUD

        public int Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }

        public User? GetById(int id)
        {
            User? user = _context.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public User? GetByPhoneNumber(string phoneNumber)
        {
            User? user = _context.Users.FirstOrDefault(u => u.PhoneNumber == phoneNumber);
            return user;
        }

        public IEnumerable<User> Search(string? filterWord)
        { 
            IEnumerable<User> ListUsers = new List<User>();

            ListUsers = _context.Users.Where(u =>
                string.IsNullOrEmpty(filterWord)
                 || u.FirstName.Contains(filterWord)
                 || u.LastName.Contains(filterWord)
                 || u.Email.Contains(filterWord)
                ); 
            return ListUsers;
        }

        public int Update(User user) 
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user.Id;
        }

        public void Delete(User user) 
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
