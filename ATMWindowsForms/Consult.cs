using ATM.Domain;
using ATM.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMWindowsForms
{
    public partial class Consult : Form
    {
        public User _user;
        private readonly UserService _userService;
        private readonly TransactionService _transactionService;

        public Consult(User user, UserService userService, TransactionService transactionService)
        {
            InitializeComponent();
            _user = user;
            _userService = userService;
            _transactionService = transactionService;
            WelcomeMessage(user);
        }




        private void WelcomeMessage(User user)
        {
            InitLabel.Text = string.Format($"Olá, {user.FirstName} ");
            Transaction transcation = new Transaction();
            transcation.time = DateTime.Now;
            transcation.UserId = _user.Id;
            transcation.Name = "Consult";
            transcation.Description = string.Format($"" +
                $"Time: {transcation.time.ToString("g")}" +
                $"\n User ID:{_user.Id}"
                );
            _transactionService.Create(transcation);
            balanceData.Text += user.Balance.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-es"));
        }

        private void ConsultBtn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = _transactionService.Search("Login", _user.Id);
                    break;

                case 1:
                    dataGridView1.DataSource = _transactionService.Search("Deposit", _user.Id);
                    break;

                case 2:
                    dataGridView1.DataSource = _transactionService.Search("Withdraw", _user.Id);
                    break;

                case 3:
                    dataGridView1.DataSource = _transactionService.Search("Transfer", _user.Id);
                    break;

                case 4:
                    dataGridView1.DataSource = _transactionService.Search("MBWAY", _user.Id);
                    break;

                case 5:
                    List<Transaction> transactions = new List<Transaction> { };
                    transactions.AddRange(_transactionService.Search("Deposit", _user.Id));
                    transactions.AddRange(_transactionService.Search("Withdraw", _user.Id));
                    transactions.AddRange(_transactionService.Search("Transfer", _user.Id));
                    transactions.AddRange(_transactionService.Search("MBWAY", _user.Id));
                    dataGridView1.DataSource = transactions;
                    break;

                case 6:
                    dataGridView1.DataSource = _transactionService.GetByUserId(_user.Id);
                    break;

                default:
                    dataGridView1.DataSource = null;
                    break;
            }
        }
    }
}
