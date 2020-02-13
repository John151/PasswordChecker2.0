using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordChecker2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEstimateStrength_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            int complexity = 0;

            if (password.Any(char.IsDigit))
            {
                complexity++;
            }
            if (password.Any(char.IsLetter))
            {
                complexity++;
            }
            if (password.Any(char.IsLower))
            {
                complexity++;
            }
            if (password.Any(char.IsUpper))
            {
                complexity++;
            }
            if (password.Any(char.IsPunctuation))
            {
                complexity++;
            }

            if (password.Length > 10 && complexity > 4)
            {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightGreen;
            }
            else
            {
                lblResult.Text = "Bad";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
