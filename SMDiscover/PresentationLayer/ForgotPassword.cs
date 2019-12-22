using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BusinessLayer;
using DataLayer.models;

namespace PresentationLayer
{
    public partial class ForgotPassword : UserControl
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            try 
            {
                if (tbAnswer.Text == "" || tbEmail.Text == "" || cbSecQuestion.SelectedIndex == -1)
                    throw new Exception("You must fill in all of the fields!");

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.Match(tbEmail.Text).Success)
                    throw new Exception("E-mail is not correct!");

                bool found = false;
                UserBusiness usersBusiness = new UserBusiness();
                foreach (User u in usersBusiness.GetAllUsers())
                {
                    if (u.Email == tbEmail.Text && u.SecretQuestion == cbSecQuestion.SelectedItem.ToString() && u.Answer == tbAnswer.Text)
                    {
                        found = true;
                        string passwd = RandomPasswd();
                        u.Password = passwd;
                        usersBusiness.UpdateUser(u);
                        MessageBox.Show("Your password was changed to " + passwd + "!");
                    }
                }
                if (!found)
                    throw new Exception("There is no account with the given field values!");
                clearRecoveryForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        private static string RandomPasswd()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void clearRecoveryForm()
        {
            tbEmail.Text = "";
            tbAnswer.Text = "";
            cbSecQuestion.SelectedIndex = -1;
        }
    }
}
