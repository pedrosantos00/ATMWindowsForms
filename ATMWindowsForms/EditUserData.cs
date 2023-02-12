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
    public partial class EditUserData : Form
    {
        public User _user;
        private readonly UserService _userService;
        private readonly TransactionService _transactionService;

        public EditUserData(User user, UserService userService, TransactionService transactionService)
        {
            InitializeComponent();
            _user = user;
            _userService = userService;
            _transactionService = transactionService;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Transaction transcation = new Transaction();
            transcation.Description = string.Format($"" +
                $"Time: {transcation.time.ToString("g")}" +
                $"\n User ID:{_user.Id}"
                );
            if (!string.IsNullOrEmpty(firstNameInput.Text))
            {
                transcation.Description += $"\nOld FirtName: {_user.FirstName} , updated to {firstNameInput.Text}";
                _user.FirstName = firstNameInput.Text;
            }

            if (!string.IsNullOrEmpty(lastNameInput.Text)) 
            {
                transcation.Description += $"\nOld LastName: {_user.LastName} , updated to {lastNameInput.Text}";
                _user.LastName = lastNameInput.Text;
            }
            if (!string.IsNullOrEmpty(emailInput.Text)) 
            {
                transcation.Description += $"\nOld Email: {_user.Email} , updated to {emailInput.Text}";

                _user.Email = emailInput.Text;
            }
            if (!string.IsNullOrEmpty(phoneNumberInput.Text)) 
            {
                transcation.Description += $"\nOld Phone Number: {_user.PhoneNumber} , updated to {phoneNumberInput.Text}";

                _user.PhoneNumber = phoneNumberInput.Text;
            }
            if ((!string.IsNullOrEmpty(passwordInput.Text) && !string.IsNullOrEmpty(repeatPasswordInput.Text)) &&
                passwordInput.Text == repeatPasswordInput.Text
                )
            {
                _user.Password= passwordInput.Text;
            }

            transcation.time = DateTime.Now;
            transcation.UserId = _user.Id;
            transcation.Name = "ChangeUserData";
            
            _transactionService.Create(transcation);
            MessageBox.Show("Dados alterados Com Sucesso!");
            _userService.Update(_user);
            this.Close();
        }
    }
}
