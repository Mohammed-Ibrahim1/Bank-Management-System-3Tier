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
    public partial class ListClient : BaseForm
    {
        public ListClient() 
        {
            LCurrentuser.Text = Login._CurrentUser.UserName;
            Header.Text = "List Clients";
            InitializeComponent();
        }

        private void ListClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsClientsOperations.GetClientList();

        }

        private void Bback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
