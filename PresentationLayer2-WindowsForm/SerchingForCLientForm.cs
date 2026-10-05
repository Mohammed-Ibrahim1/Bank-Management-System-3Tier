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
        public SerchingForCLientForm()
        {
            InitializeComponent();
        }

        public static clsClientsOperations CurrentClient = null;
        private void SerchingForCLientForm_Load(object sender, EventArgs e)
        {

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
    }
}
