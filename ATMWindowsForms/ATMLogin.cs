using ATM.DAL;
using ATM.Domain;
using ATM.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWindowsForms
{
    public partial class ATMLogin : Form
    {
        public bool UserSuccessfullyAuthenticated { get; private set; }
        private readonly UserService _userService;
        private readonly BankService _bankService;
        private readonly TransactionService _transactionService;
        private readonly string _connectionString;
        private List<User> _userList;
        private User _user;
        public ATMLogin(string connectionstring)
        {
            _connectionString = connectionstring;
            InitializeComponent();

            UserRepository userRepository = new UserRepository(_connectionString);
            BankRepository bankRepository = new BankRepository(_connectionString);
            TransactionRepository transactionRepository = new TransactionRepository(_connectionString);


            _userService = new UserService(userRepository);
            _bankService = new BankService(bankRepository);
            _transactionService = new TransactionService(transactionRepository);
            // ASYNC == FAZ PROCESSAMENTO EM BACKGROUND
            LoadDataAsync();
        }

        // ASYNC == FAZ PROCESSAMENTO EM BACKGROUND
        private async void LoadDataAsync()
        {
            _userList = await _userService.GetUsersAsync("");
        }

        public User? GetUser()
        {
            return _user;
        }

        public UserService GetUserService()
        {
            return _userService;
        }
        public BankService GetBankService()
        {
            return _bankService;
        }
        public TransactionService GetTransactionService()
        {
            return _transactionService;
        }

        private void ATMLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                LoginBtn.PerformClick();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                int id = Int32.Parse(idInput.Text);
                User? user = _userService.GetById(Int32.Parse(idInput.Text));
                if (user == null) MessageBox.Show("Cannot find User!");
                if (user != null && passwordInput.Text != null)
                {
                    if (user.Password == passwordInput.Text)
                    {
                        _user = user;
                        Transaction transcation = new Transaction();
                        transcation.time = DateTime.Now;
                        transcation.UserId = _user.Id;
                        transcation.Name = "Login";
                        transcation.Description = string.Format($"" +
                            $"Time: {transcation.time.ToString("g")}" +
                            $"\n User ID:{_user.Id}"
                            );
                        _transactionService.Create(transcation);
                        UserSuccessfullyAuthenticated = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect  Password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       
    }
}
