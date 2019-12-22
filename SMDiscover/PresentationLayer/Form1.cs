using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnLogin.Height;
            SidePanel.Top = btnLogin.Top;
            login1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogin.Height;
            SidePanel.Top = btnLogin.Top;
            login1.BringToFront();
            register1.clearRegisterForm();
            forgotPassword1.clearRecoveryForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnRegister.Height;
            SidePanel.Top = btnRegister.Top;
            register1.BringToFront();
            login1.clearLoginForm();
            forgotPassword1.clearRecoveryForm();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnForgotPassword.Height;
            SidePanel.Top = btnForgotPassword.Top;
            forgotPassword1.BringToFront();
            register1.clearRegisterForm();
            login1.clearLoginForm();
        }


    }
}
