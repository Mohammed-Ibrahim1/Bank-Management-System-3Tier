using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer2_WindowsForm
{
    public partial class Login : BaseForm
    {
        public static clsUsersOperations _CurrentUser = null;

        public Login()
        {
            InitializeComponent();
            Header.Text = "Logging IN";
            _CurrentUser = null;
            Counter = 1;
            TBusername.Text = "";
            Tbpassword .Text = "";
        }

        int Counter = 1;

    
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TBusername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TBusername.Text))
            {
                e.Cancel = true;
                TBusername.Focus();
                ErrorProvider1.SetError(TBusername, "UserName Should NOT be empty");

            }


        }

        private void Tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Tbpassword.Text))
            {

                ErrorProvider1.SetError(Tbpassword, "Password Should NOT be empty");

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { Tbpassword.PasswordChar = '\0'; }
            else { Tbpassword.PasswordChar = '*'; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUsersOperations CurrentUser = clsUsersOperations.TryLogin(TBusername.Text.ToString(), true , Tbpassword.Text.ToString() );
            if (CurrentUser == null)
            {
                if (Counter == 3)
                { MessageBox.Show("System is Locked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                Counter++;
                MessageBox.Show($"Wrong Password  /  User Name Try again  ({3 - Counter + 1 } Trial(s) Left ).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBusername.Text = "";
                Tbpassword.Text = "";
                TBusername.Focus();
                TBusername.Select();
            }
            else
            {
                LCurrentuser.Text = CurrentUser.UserName.ToString();
                CurrentUser.SaveLogin();
                _CurrentUser = CurrentUser;
                Form F1 = new MainMenue();
                F1.ShowDialog();
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
