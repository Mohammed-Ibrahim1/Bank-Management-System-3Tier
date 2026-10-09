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
    enum enMode {List =1 , Add  = 2  ,  Delete = 3 , Update = 4,  Find = 5 }
    public partial class ManageUsersForm : BaseForm
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

       
        void ShowForm (int Mode , clsUsersOperations User = null)
        {
            Form F1 = new ExcuteUsersOperationsForm(Mode ,User );
            F1.ShowDialog();

        }
        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            Header.Text = "Manage Users";
        }

        private void Blistusers_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT  = clsUsersOperations.ListUsers();
            foreach (DataRow Dr in DT.Rows)
            {
                Dr["Password"] = clsUsersOperations._Decription(Dr["Password"].ToString(), 2);
            }
            Form F1 = new ListClient(DT , "Users");
            F1.ShowDialog();
        }

        private void BAddnew_Click(object sender, EventArgs e)
        {
            ShowForm((int)enMode.Add);
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            Form F1 = new SerchingForUsers(true);
            F1.ShowDialog();
            clsUsersOperations Current = SerchingForUsers.CurrentUser;
            if (Current == null) { return; }
            ShowForm((int)enMode.Delete , Current);
        }

        private void Bupdate_Click(object sender, EventArgs e)
        {
            Form F1 = new SerchingForUsers();
            F1.ShowDialog();
            clsUsersOperations Current = SerchingForUsers.CurrentUser;
            if (Current == null) { return; }
            ShowForm((int)enMode.Update, Current);
        }

        private void Bfind_Click(object sender, EventArgs e)
        {
            Form F1 = new SerchingForUsers();
            F1.ShowDialog();
            clsUsersOperations Current = SerchingForUsers.CurrentUser;
            if (Current == null) { return; }
            ShowForm((int)enMode.Find, Current);
        }

        private void Bmain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
