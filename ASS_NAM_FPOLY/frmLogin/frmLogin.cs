﻿using ASS_NAM_FPOLY.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS_NAM_FPOLY.frmLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {

            InitializeComponent();
            YourDbContext DbContext = new YourDbContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (IsLoginValid(username, password))
            {
                Frm_Action frmAction = new Frm_Action();
                MessageBox.Show("Login Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAction.Show();            
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsLoginValid(string username, string password)
        {
            return (username == "" && password == "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
