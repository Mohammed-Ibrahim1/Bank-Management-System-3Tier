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
    public  partial class SerchingForCLientForm : Form
    {
        public SerchingForCLientForm(string Extramessage = "")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Extramessage)) {   
            
           Lextra.Text = "(" + Extramessage + ")";

            }

        }

        public static clsClientsOperations CurrentClient = null;
        private void SerchingForCLientForm_Load(object sender, EventArgs e)
        {
            CurrentClient = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentClient = clsClientsOperations.FindClient(textBox1.Text);
            if (CurrentClient == null) {
                MessageBox.Show("Client Was NOT Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();

            }
            else {
                this.Close();
                    }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) { 
            e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Can NOT search for a NULL value");

            }
        }
    }
}
