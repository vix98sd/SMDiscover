using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.models;

namespace PresentationLayer
{
    public partial class Login : UserControl
    {
        public Form1 f1;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text == "" || tbUsername.Text == "")
                    throw new Exception("You must fill in all of the fields!");

                bool found = false;
                UserBusiness usersBusiness = new UserBusiness();
                foreach (User u in usersBusiness.GetAllUsers())
                {
                    if (u.Username == tbUsername.Text)
                    {
                        if (u.Password == tbPassword.Text)
                        {
                            clearLoginForm();
                            found = true;
                            if (u.Admin == 0)
                            {
                                Form2 f2 = new Form2(u);
                                f2.Show(); 
                            }
                            else
                            {
                                Form3 f3 = new Form3();
                                f3.Show();
                            }
                        }
                        else
                            throw new Exception("Wrong password!");
                    }
                }
                if (!found)
                    throw new Exception("Wrong username!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void lblFindMall_Click(object sender, EventArgs e)
        {

        }

        public void clearLoginForm()
        {
            tbPassword.Text = "";
            tbUsername.Text = "";
        }
    }
}
