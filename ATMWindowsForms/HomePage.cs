using ATM.Domain;
using ATM.Logic;
using ATMWindowsForms.Properties;
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
    public partial class HomePage : Form
    {
        private readonly UserService _userService;
        private readonly BankService _bankService;
        private readonly TransactionService _transactionService;
        public User _user { get; set; }
        public HomePage(User user, UserService userService,BankService bankSerive,TransactionService transactionService)
        {
            InitializeComponent();
            _userService = userService;
            _bankService = bankSerive;
            _transactionService = transactionService;
            _user = user;
            InitLabel.Text = string.Format($"Olá, {user.FirstName} ");
            switch (_user.BankId)
            {
                case 1:
                    pictureBox1.Image = Resources.kisspng_banco_comercial_portugus_bank_millennium_s_a_co_portugal_5b0c080d3e26f9_2712041015275151492546;
                    break;

                case 2:
                    pictureBox1.Image = Resources.montepio;

                    break;
                case 3:
                    pictureBox1.Image = Resources.novobanco;

                    break;
                case 4:
                    pictureBox1.Image = Resources.santander;
                    break;
                default:
                    pictureBox1.Image = Resources.kisspng_banco_comercial_portugus_bank_millennium_s_a_co_portugal_5b0c080d3e26f9_2712041015275151492546;
                    break;
            }
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(_user, _userService, _transactionService);
            deposit.Show();
            
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw(_user, _userService, _transactionService);
            withdraw.Show();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer(_user, _userService, _transactionService);
            transfer.Show();
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments(_user, _userService, _transactionService);
            payments.Show();
        }

        private void editUserData_Click(object sender, EventArgs e)
        {
            EditUserData editUserData = new EditUserData(_user, _userService, _transactionService);
            editUserData.Show();
        }

        private void Consult_Click(object sender, EventArgs e)
        {
            Consult consults = new Consult(_user, _userService, _transactionService);
            consults.Show();

        }

        private void Mbway_Click(object sender, EventArgs e)
        {
            MBWay mbway = new MBWay(_user, _userService, _transactionService);
            mbway.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
