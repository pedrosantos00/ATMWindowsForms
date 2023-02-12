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
    public partial class Withdraw : Form
    {
        public User _user;
        private readonly TransactionService _transactionService;
        private readonly UserService _userService;
        public Withdraw(User user, UserService userService, TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _user = user;
            _transactionService = transactionService;
        }

        private void Deposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                with.PerformClick();
            }
        }

        private void with_Click(object sender, EventArgs e)
        {
            try
            {
                float balance = float.Parse(balanceInput.Text);

                if (_user.Balance >= balance)
                {
                    _user.Balance -= balance;
                    
                    Transaction transcation = new Transaction();
                    transcation.time = DateTime.Now;
                    transcation.UserId = _user.Id;
                    transcation.Name = "Withdraw";
                    transcation.Description = string.Format($"" +
                        $"Time: {transcation.time.ToString("g")}" +
                        $"\n User ID:{_user.Id}" +
                        $"\n Money Withrawed: {balance}" +
                        $"\n Actual Balance {_user.Balance}");

                    _transactionService.Create(transcation);
                    MessageBox.Show("Levantamento Com Sucesso!");
                    _userService.Update(_user);
                }
                else
                {
                    MessageBox.Show("Não tens dinheiro suficiente na conta!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }
    }
}
