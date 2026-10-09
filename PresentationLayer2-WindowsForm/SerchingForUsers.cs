using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer2_WindowsForm
{
    public partial class SerchingForUsers : Form
    {
        bool DeleteMode = false;
        public SerchingForUsers(bool deleteMode  = false)
        {
            DeleteMode = deleteMode;
            InitializeComponent();
        }
        public static clsUsersOperations CurrentUser = null;
        private void SerchingForUsers_Load(object sender, EventArgs e)
        {
            CurrentUser = null;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Can NOT search for a NULL value");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DeleteMode)
            {
                if (textBox1.Text.ToLower() == "admin") { MessageBox.Show("You Can NOT Delete (Admin) Insert another Username to Delete ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            }
            CurrentUser = clsUsersOperations.TryLogin(textBox1.Text.ToString() , false);
          
                if (CurrentUser == null)
            {
                MessageBox.Show("User Was NOT Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();

            }
            else
            {
                this.Close();
            }
        }
    }
}
