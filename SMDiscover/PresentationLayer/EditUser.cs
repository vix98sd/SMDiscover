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
using System.Text.RegularExpressions;

namespace PresentationLayer
{
    public partial class EditUser : UserControl
    {
        User user = new User();
        public EditUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text == "" || tbEmail.Text == "")
                    throw new Exception("You must fill in all of the fields");
 
                UserBusiness userBusiness = new UserBusiness();

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.Match(tbEmail.Text).Success)
                    throw new Exception("E-mail is not correct!");

                bool found=false;
                foreach(User temp in userBusiness.GetAllUsers())
                {
                    if (temp.Username == tbUsername.Text && temp.Email == tbEmail.Text)
                    {
                        found = true;
                        user = temp;
                    }
                }

                if (!found)
                    throw new Exception("User was not found!");

                tbName.Text = user.Name;
                tbSurname.Text = user.Surname;
                tbAnswer.Text = user.Answer;

                btnDelete.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            try
            {
                if (tbUsername.Text == "" || tbEmail.Text == "")
                    throw new Exception("You must fill in all of the fields");

                UserBusiness userBusiness = new UserBusiness();

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!regex.Match(tbEmail.Text).Success)
                    throw new Exception("E-mail is not correct!");

                var confirmResult = MessageBox.Show("Are you sure to delete this user ??", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                    throw new Exception("You must confirm delete if you want to deleta an user!");

                userBusiness.DeleteUser(user);
                MessageBox.Show("Usere successfully deleted!");

                ClearEditUserForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void  ClearEditUserForm()
        {
            tbUsername.Text = "";
            tbName.Text = "";
            tbPassword.Text = "";
            tbConfirm.Text = "";
            tbSurname.Text = "";
            tbAnswer.Text = "";
            rbAdmin.Checked = false;
            cbSecQuestion.SelectedIndex = -1;
            tbEmail.Text = "";
            btnDelete.Enabled = false;
        }
    }
}
