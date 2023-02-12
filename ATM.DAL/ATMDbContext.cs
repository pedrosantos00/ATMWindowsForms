using ATM.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL
{
    public class ATMDbContext : DbContext
    {
        private string _connectionString {get; set; }
        public ATMDbContext () : base ()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ATMdb"].ConnectionString;
        }

        public ATMDbContext(string connectionString): base()
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
