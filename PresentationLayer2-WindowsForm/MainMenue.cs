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
    public partial class MainMenue : BaseForm
    {

        public enum enMode {Addnew  =1  , Update =2, Delete = 3 ,  Find =4 ,}
        enMode Mode = enMode.Update;
        public clsUsersOperations _CurrentUser = Login._CurrentUser;

        
       public  void CheckPermissions ()
        {
            if (_CurrentUser.Accessibilities == -1) { 
                    bListClient.Enabled = true;
                BAddnew.Enabled = true;
                BUpdate.Enabled = true;
                Bdelete.Enabled = true;
                BFind.Enabled = true;
                BTransactions.Enabled = true;
                Bmanange.Enabled = true;
                BLogs.Enabled = true;  
                Bcurrencies.Enabled = true;
            }




            else
            {
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(bListClient.Tag.ToString())) != Convert.ToInt32(bListClient.Tag.ToString()))
                {
                    bListClient.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(BAddnew.Tag.ToString())) != Convert.ToInt32(BAddnew.Tag.ToString()))
                {
                    BAddnew.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(Bdelete.Tag.ToString())) != Convert.ToInt32(Bdelete.Tag.ToString()))
                {
                    Bdelete.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(BUpdate.Tag.ToString())) != Convert.ToInt32(BUpdate.Tag.ToString()))
                {
                    BUpdate.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(BFind.Tag.ToString())) != Convert.ToInt32(BFind.Tag.ToString()))
                {
                    BFind.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(BTransactions.Tag.ToString())) != Convert.ToInt32(BTransactions.Tag.ToString()))
                {
                    BTransactions.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(Bmanange.Tag.ToString())) != Convert.ToInt32(Bmanange.Tag.ToString()))
                {
                    Bmanange.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(BLogs.Tag.ToString())) != Convert.ToInt32(BLogs.Tag.ToString()))
                {
                    BLogs.Enabled = false;
                }
                if ((_CurrentUser.Accessibilities & Convert.ToInt32(Bcurrencies.Tag.ToString())) != Convert.ToInt32(Bcurrencies.Tag.ToString()))
                {
                    Bcurrencies.Enabled = false;
                }
            }

            }
        public MainMenue() 
        {
           
            InitializeComponent();

            Header.Text = "Main Menue";
           CheckPermissions();



            }

        

        void ShowForms (enMode Mode)
        {
            Form F1 = new SerchingForCLientForm();
            F1.ShowDialog();
            clsClientsOperations Client = SerchingForCLientForm.CurrentClient;
            if (Client != null)
            {
                Form F2 = new AddNew_Update((int)Mode, Client);
                F2.ShowDialog();
            }


        }

        private void MainMenue_Load(object sender, EventArgs e)
        {


        }
        public  void Refreshform ()
        { 
           CheckPermissions();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Blogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();

        }

        private void bListClient_Click(object sender, EventArgs e)
        {
            DataTable DT =clsClientsOperations.GetClientList();
            Form F1 = new ListClient(DT ,"List Clients");
            F1.ShowDialog();

        }

     
        private void BAddnew_Click(object sender, EventArgs e)
        {
            Mode = enMode.Addnew;
            Form F1 = new AddNew_Update((int)Mode);
            F1.ShowDialog();
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            Mode = enMode.Update;
            ShowForms(Mode);
        }

        private void BFind_Click(object sender, EventArgs e)
        {
            Mode = enMode.Find;
            ShowForms(Mode);
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            Mode = enMode.Delete;
            ShowForms(Mode);
        }

        private void BTransactions_Click(object sender, EventArgs e)
        {
            Form F1   = new TransactionsForm();
            F1.ShowDialog();
        }

        private void Bmanange_Click(object sender, EventArgs e)
        {
            Form F1 = new ManageUsersForm();
            F1.ShowDialog();
            _CurrentUser = clsUsersOperations.TryLogin(_CurrentUser.UserName ,  false);
            Refreshform();

        }

        private void BLogs_Click(object sender, EventArgs e)
        {
         DataTable DT = clsUsersOperations.GetLogs();
            Form F1 = new ListClient(DT, "Login Logs");
            F1.ShowDialog();
        }
    }
}
