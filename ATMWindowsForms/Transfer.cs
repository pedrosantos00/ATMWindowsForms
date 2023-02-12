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
    public partial class Transfer : Form
    {
        public User _user { get; set; }
        private readonly TransactionService _transactionService;
        private readonly UserService _userService;
        public Transfer(User user, UserService userService, TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _user = user;
            _transactionService = transactionService;
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User? userToDeposit = _userService.GetById(Int32.Parse(idToTransfer.Text));
                float balance = float.Parse(balanceInput.Text);
                if (userToDeposit == null) MessageBox.Show("User não existe!");
                if (_user.Balance >= balance && userToDeposit != null)
                {
                    _user.Balance -= balance;
                    userToDeposit.Balance += balance;
                    Transaction transcation = new Transaction();
                    transcation.time = DateTime.Now;
                    transcation.UserId = _user.Id;
                    transcation.Name = "Transfer";
                    transcation.Description = string.Format($"" +
                        $"Time: {transcation.time.ToString("g")}" +
                        $"\n User ID:{_user.Id}" +
                        $"\n Money transferred: {balance}" +
                        $"\n User transferred ID : {userToDeposit.Id}" +
                        $"\n Actual Balance {_user.Balance}");

                    _transactionService.Create(transcation);
                    MessageBox.Show("Transferencia Com Sucesso!");
                    _userService.Update(_user);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
