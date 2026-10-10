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
    public partial class TransactionsForm : BaseForm
    {
        enum enOption {Desposit =1  ,  Withdraw = 2 , Transfer =3  }
        public TransactionsForm()
        {
            Header.Text = "Transactions";
            InitializeComponent();
        }

        void ShowForm( enOption Option ,string clienttype = "" )
        {
            clsClientsOperations Client2 = new clsClientsOperations();
            Client2 = null;
            if (Option == enOption.Transfer)
            {
                Form F3 = new SerchingForCLientForm("Sender");
                F3.ShowDialog();
                Client2 = SerchingForCLientForm.CurrentClient;
                clienttype = "Receiver";
            }
            Form F1 = new SerchingForCLientForm(clienttype);
            F1.ShowDialog();
            clsClientsOperations Client = SerchingForCLientForm.CurrentClient;
            if (Client != null && Client2 !=null && Client.AccountName == Client2.AccountName ) { MessageBox.Show("Sender & Receiver should NOT be the Same " , "Error" , MessageBoxButtons.OK
                , MessageBoxIcon.Information); return; }
            if (Client == null) { return; }
            Form F2 = new TransferForm(Client , (int)Option ,Client2 );
            F2.ShowDialog();


            if(Client == null && Client2 == null) { return; }
           
        }
        private void TransactionsForm_Load(object sender, EventArgs e)
        {

        }

        private void BDesposit_Click(object sender, EventArgs e)
        {
            ShowForm(enOption.Desposit);
        }

        private void Bwithdraw_Click(object sender, EventArgs e)
        {
            ShowForm(enOption.Withdraw);
        }

        private void bTrans_Click(object sender, EventArgs e)
        {
            ShowForm(enOption.Transfer);
        }

        private void Blog_Click(object sender, EventArgs e)
        {
            DataTable DT = clsClientsOperations.GetLogs ();
            Form F1 = new ListClient(DT , "Transfer Log");
            F1.ShowDialog();
        }

        private void Bmain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
