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
    public partial class TransferForm : BaseForm 
    {
        clsClientsOperations Client1 = null;
        clsClientsOperations Client2 = null;
        int mode = 0;
        public TransferForm(clsClientsOperations Client , int Mode , clsClientsOperations client2 = null)
        {
            mode = Mode;
            Client1 = Client;
            Client2 = client2;
            InitializeComponent();
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    {
                        Header.Text = "Desposit";
                        LID.Text = Client1.ID.ToString();
                        LNAME.Text = Client1.FirstName + " " + Client1.LastName;
                        LACCOUNT.Text = Client1.AccountName;
                        LPHONE.Text = Client1.Phone;    
                        LBAL.Text  = Client1.Balance.ToString();
                         LCODE.Text = Client1.PinCode.ToString();
                        panel2.Visible = false;
                        button1.Text = "Desposit";
                        Lamount.Text = "Amount to Desposit";
                        Lfrom.Visible = false;
                        Lto.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        break;
                    }

                case 2:
                    {
                        Header.Text = "Withdraw";
                        LID.Text = Client1.ID.ToString();
                        LNAME.Text = Client1.FirstName + " " + Client1.LastName;
                        LACCOUNT.Text = Client1.AccountName;
                        LPHONE.Text = Client1.Phone;
                        LBAL.Text = Client1.Balance.ToString();
                        LCODE.Text = Client1.PinCode.ToString();
                        panel2.Visible = false;
                        button1.Text = "Withdraw";
                        Lamount.Text = "Amount to Withdraw";
                        Lfrom.Visible = false;
                        Lto.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        break;


                    }

                case 3:
                    {
                        Header.Text = "Transfer";
                        LID.Text = Client1.ID.ToString();
                        LNAME.Text = Client1.FirstName + " " + Client1.LastName;
                        LACCOUNT.Text = Client1.AccountName;
                        LPHONE.Text = Client1.Phone;
                        LBAL.Text = Client1.Balance.ToString();
                        LCODE.Text = Client1.PinCode.ToString();
                        panel2.Visible = true;
                        LID2.Text = Client2.ID.ToString();
                        LNAME2.Text = Client2.FirstName + " " + Client2.LastName;
                        LACCOUNT2.Text  = Client2.AccountName;
                        LPHONE2.Text = Client2.Phone;
                        LBALANCE2.Text = Client2.Balance.ToString();
                        LCODE2.Text  = Client2.PinCode.ToString();
                        button1.Text = "Transfer";
                        Lamount.Text = "Amount to Transfer";
                        Lfrom.Visible = true;
                        Lto.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        Lfrom.Text  = Client1.AccountName;
                        Lto.Text = Client2.AccountName;
                        LAccount1header.Text = "Sender";
                        LAccount2header.Text = "Receiver";

                        break;
                    }



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 2:
                    {
                        double amount = Convert.ToDouble(maskedTextBox1.Text.ToString());
                        if (amount > Client1.Balance)
                        {
                            MessageBox.Show("Amount Exceeds Client Balance", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            maskedTextBox1.Text = "";
                            maskedTextBox1.Focus();
                            return;
                        }
                        Client1.Balance -= amount;
                        Client1.Save();
                        MessageBox.Show("Amount Desposited Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        break;

                    }

                case 1:
                    {
                        double amount = Convert.ToDouble(maskedTextBox1.Text.ToString());
                        Client1.Balance += amount;
                        Client1.Save();
                        MessageBox.Show("Amount Withdrawed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        break;
                    }


                case 3:
                    {
                        double amount = Convert.ToDouble(maskedTextBox1.Text.ToString());
                        if (amount > Client1.Balance)
                        {
                            MessageBox.Show("Amount Exceeds Client Balance", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            maskedTextBox1.Text = "";
                            maskedTextBox1.Focus();
                            return;
                        }
                        Client1.Balance -= amount;
                        Client2.Balance += amount;
                        Client2.Save();
                        Client1.Save();
                        MessageBox.Show("Amount Transfered Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsClientsOperations.CreateTransferLog(Client1.ID, Client2.ID, amount, Login._CurrentUser.UserID);
                        this.Close();
                        break;
                    }
            }
        }
    }
}

