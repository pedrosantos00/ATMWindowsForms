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

    }
}
