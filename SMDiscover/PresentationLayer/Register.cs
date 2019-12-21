using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.models;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try 
            {
                if (tbName.Text == "" || tbSurname.Text == "" || tbEmail.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || tbConfirm.Text == "" || cbSecQuestion.Text == "" || tbAnswer.Text == "")
                    throw new Exception("You must fill all the fields!");

                if (tbUsername.Text.Length < 6)
                    throw new Exception("Username must be at least 6 letters long!");

                if (tbPassword.Text.Length < 8)
                    throw new Exception("Password must be at least 8 characters long!");

                if (tbPassword.Text != tbConfirm.Text)
                    throw new Exception("Passwords must match up!");

                User user = new User
                {
                    Name = tbName.Text,
                    Surname = tbSurname.Text,
                    Username = tbUsername.Text,
                    Email = tbEmail.Text,
                    Password = tbPassword.Text,
                    SecretQuestion = cbSecQuestion.SelectedItem.ToString(),
                    Answer = tbAnswer.Text
                };

                UserBusiness userBusiness = new UserBusiness();
                userBusiness.InsertUser(user);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void cbSecQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbAnswer.Text = "";
        }
    }
}
