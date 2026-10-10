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
    public partial class CurrenciesCalculator : Form
    {

        DataTable Currency1;
        DataTable Currency2;

        public CurrenciesCalculator()
        {
            InitializeComponent();
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrenciesCalculator_Load(object sender, EventArgs e)
        {
            DataTable Dt = clsCurrenciesOperation.AllCurrencies();
            foreach (DataRow dr in Dt.Rows)
            {
                CBCurrency1.Items.Add(dr["CurrencyCode"]);
            }
            foreach (DataRow dr in Dt.Rows)
            {
                CBCurrency2.Items.Add(dr["CurrencyCode"]);
            }

        }

        private void CBCurrency1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency1 = clsCurrenciesOperation.FindCurrency(CBCurrency1.SelectedItem.ToString());

        }

        private void CBCurrency2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency2 = clsCurrenciesOperation.FindCurrency(CBCurrency2.SelectedItem.ToString());
        }

     

        private void TAmount_TextChanged(object sender, EventArgs e)
        {
            DataRow C1 = Currency1.Rows[0];
            DataRow C2 = Currency2.Rows[0];
            if (!string.IsNullOrEmpty(TAmount.Text))
            {
                textBox1.Text = ((Convert.ToDouble(C2["Rate"]) * Convert.ToInt32(TAmount.Text.ToString())) / Convert.ToDouble(C1["Rate"])).ToString();
            } 
        }

        private void TAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
