using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer2_WindowsForm
{
    public partial class AddNew_Update : BaseForm
    {
        clsClientsOperations CurrentClient = null;
        int SelectingOption = 0;
        public AddNew_Update(int Selection , clsClientsOperations Client = null) 
        {
            CurrentClient = Client;
            SelectingOption  = Selection;
            InitializeComponent();
            Tfirstname .Text= "";
            Tlastname.Text = "";
            TBbalance.Text = "";
            TBPin.Text = "";
            Temail.Text = "";
            TphoneNumber.Text = "";
            Bdelete.Visible = false;
            Lmessage.Visible = false;
            linkLabel1.Visible  = false;
            Tfirstname.ReadOnly = false;
            Tlastname.ReadOnly = false;
            TBbalance.ReadOnly = false;
            TBPin.ReadOnly = false;
            Temail.ReadOnly = false;
            TAccountname.ReadOnly = false;

        }

        void filldata ()
        {

            if (CurrentClient == null)
            {
                return;
            }
            LID2.Text = CurrentClient.ID.ToString();
            Tfirstname.Text = CurrentClient.FirstName;
            Tlastname.Text = CurrentClient.LastName;
            TBbalance.Text = CurrentClient.Balance.ToString();
            Temail.Text = CurrentClient.Email;
            TphoneNumber.Text = CurrentClient.Phone;
            TBPin.Text = CurrentClient.PinCode;
            TAccountname.Text = CurrentClient.AccountName;
          

        }
        private void AddNew_Update_Load(object sender, EventArgs e)
        {
            switch (SelectingOption)
            {
                case 1:
                    {
                        CurrentClient = new clsClientsOperations ();
                        Bsave.Visible = true;
                        Header.Text = "Add New Client";


                        break;
                    }

                case 2:
                    {
                        Header.Text = "Update Client";

                        filldata();
                        Bsave.Visible = true;
                        TAccountname.ReadOnly = true;

                        break;
                    }

                case 3:
                    {
                        Bdelete.Visible = true;
                        Header.Text = "Delete Client";

                        filldata();
                        Tfirstname.ReadOnly = true;
                        Tlastname.ReadOnly = true;
                        TBbalance.ReadOnly = true;
                        TBPin.ReadOnly = true;
                        Temail.ReadOnly = true;
                        TAccountname.ReadOnly = true;
                        TphoneNumber.ReadOnly = true;
                        Bsave.Visible = false; 
                        break;
                    }
                case 4:
                    {
                        Header.Text = "Find Client";

                        filldata();
                        Tfirstname.ReadOnly = true;
                        Tlastname.ReadOnly = true;
                        TBbalance.ReadOnly = true;
                        TBPin.ReadOnly = true;
                        Temail.ReadOnly = true;
                        TAccountname.ReadOnly = true;
                        TphoneNumber.ReadOnly = true;
                        Lmessage.Visible = true;
                        linkLabel1.Visible = true;
                        Bsave.Visible = false;

                        break;
                    }

            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bsave_Click(object sender, EventArgs e)
        {

            CurrentClient.FirstName = Tfirstname.Text;
            CurrentClient.LastName = Tlastname.Text;
            if (!string.IsNullOrEmpty(TBbalance.Text))
            {
                CurrentClient.Balance = Convert.ToDouble(TBbalance.Text);
                    }
            CurrentClient.Email = Temail.Text;
            CurrentClient.Phone  =TphoneNumber.Text;
            CurrentClient.AccountName = TAccountname.Text;
            CurrentClient.PinCode = TBPin.Text;

            if (string.IsNullOrEmpty(Tfirstname.Text) || string.IsNullOrEmpty(Tlastname.Text) || string.IsNullOrEmpty(TAccountname.Text) 
                || string.IsNullOrEmpty(TBPin.Text) || string.IsNullOrEmpty(Temail.Text)  || string.IsNullOrEmpty(TphoneNumber.Text))  
            {
                MessageBox.Show("Data was NOT Complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

          if(CurrentClient.Save () )
            {
                MessageBox.Show("Client Saved Successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();

        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Client ? " , "Confirmation" ,MessageBoxButtons.OKCancel , MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
              if(   CurrentClient._DeleteClient() )
                {
                    MessageBox.Show("Client Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Header.Text = "Update Client";

            Tfirstname.ReadOnly = false;
            Tlastname.ReadOnly = false;
            TBbalance.ReadOnly = false;
            TBPin.ReadOnly = false;
            Temail.ReadOnly = false;
            TAccountname.ReadOnly = true;
            TphoneNumber.ReadOnly = false;
            Lmessage.Visible = true;
            linkLabel1.Visible = true;
            Bsave.Visible = true;
            Lmessage.Visible = false;
            linkLabel1 .Visible = false;


        }

        private void Lmessage_Click(object sender, EventArgs e)
        {
            DataTable DT  = new DataTable();
            DT = clsUsersOperations.GetLogs();
            Form F1 = new ListClient(DT , "Login Logs");
            F1.ShowDialog();
        }
    }
}
