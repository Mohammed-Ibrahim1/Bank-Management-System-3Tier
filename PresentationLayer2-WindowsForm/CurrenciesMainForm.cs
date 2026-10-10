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
    public partial class CurrenciesMainForm : BaseForm
    {
        public CurrenciesMainForm()
        {
            InitializeComponent();
        }

        void ShowForm(bool update = false)
        {
            Form F2 = new SearhforCurrency();
            F2.ShowDialog();
            if (SearhforCurrency.Currency.Rows.Count == 0)
            {
                return;
            }
            Form F11 = new FindSetRateCurrencies(SearhforCurrency.Currency ,  update );
            F11.ShowDialog();
        }
        private void CurrenciesMainForm_Load(object sender, EventArgs e)
        {

        }

        private void Blistcurrency_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = clsCurrenciesOperation.AllCurrencies();
            Form F11 = new ListClient(Dt , "List Currencies");
            F11.ShowDialog();
        }

        private void Bfindcurrency_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Bupdaterate_Click(object sender, EventArgs e)
        {
            ShowForm(true);
        }

        private void Bcalcuator_Click(object sender, EventArgs e)
        {
            Form F1=  new CurrenciesCalculator();
            F1.ShowDialog();
        }

        private void Bmain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
