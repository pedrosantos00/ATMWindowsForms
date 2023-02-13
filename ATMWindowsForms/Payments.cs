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
    public partial class Payments : Form
    {
        public User _user;
        private readonly UserService _userService;
        private readonly TransactionService _transactionService;

        public Payments(User user, UserService userService, TransactionService transactionService)
        {
            InitializeComponent();
            _user = user;
            _userService = userService;
            _transactionService = transactionService;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
          
            try
            {
                bool flagEntity = CheckEntity();
                bool flagRef = CheckRef();
                float balance = float.Parse(balanceInput.Text);
                if (_user.Balance >= balance && flagRef && flagEntity)
                {
                    _user.Balance -= balance;
                    Transaction transcation = new Transaction();
                    transcation.time = DateTime.Now;
                    transcation.UserId = _user.Id;
                    transcation.Name = "Payment";
                    transcation.Description = string.Format($"" +
                        $"Time: {transcation.time.ToString("g")}" +
                        $"\n User ID:{_user.Id}" +
                        $"\n Entity : {entityInput.Text}" +
                        $"\n Reference : {refInput.Text}" +
                        $"\n Balance : {balance}" +
                        $"\n Actual Balance {_user.Balance}");

                    _transactionService.Create(transcation);
                    MessageBox.Show("Pagamento Com Sucesso!");
                    _userService.Update(_user);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Preencha devidamente os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckRef()
        {
            if (entityInput.Text.Length >= 5 || !string.IsNullOrEmpty(entityInput.Text)) return true;
            else return false;
        }

        private bool CheckEntity()
        {
            if (refInput.Text.Length >= 9 || !string.IsNullOrEmpty(refInput.Text)) return true;
            else return false;
        }
    }
}
