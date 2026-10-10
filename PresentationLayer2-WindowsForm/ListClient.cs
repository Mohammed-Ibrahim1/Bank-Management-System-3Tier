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
        DataTable CurrentDataTable = null;
        public ListClient(DataTable DT ,  string Message) 
        {
            CurrentDataTable = DT;
            LCurrentuser.Text = Login._CurrentUser.UserName;
            Header.Text = Message;
            InitializeComponent();
        }

        private void ListClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CurrentDataTable;

        }

        private void Bback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
