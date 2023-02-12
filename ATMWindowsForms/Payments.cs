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
    }
}
