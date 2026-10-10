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
    public partial class FindSetRateCurrencies : Form
    {
        DataRow Currency;
        bool update = false;
        public FindSetRateCurrencies(DataTable DT ,  bool IsUpdate = false)
        {
            update = IsUpdate;
            Currency = DT.Rows[0];
            InitializeComponent();
        }

        private void Bback_Click(object sender, EventArgs e)
        {
            this.Close  ();
        }

        private void FindSetRateCurrencies_Load(object sender, EventArgs e)
        {
            LID.Text = Currency["CurrencyID"].ToString();
            Lname.Text = Currency["CurrencyName"].ToString ();
            Lcode.Text = Currency["CurrencyCode"].ToString();
            Lcountry.Text = Currency["Country"].ToString();
            Lrate.Text = Currency["Rate"].ToString();
            if (update)
            {
                panel1.Visible = true;

            }

        }
        
        private void Bsubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are Sure to Update this Currency Rate ? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
            clsCurrenciesOperation.UpdateRate(Lcode.Text, Convert.ToDouble(textBox1.Text.ToString()));
                MessageBox.Show("Rate Updated Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; 
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
