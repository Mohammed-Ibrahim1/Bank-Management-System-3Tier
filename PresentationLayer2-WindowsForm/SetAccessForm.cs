using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer2_WindowsForm
{
    public partial class SetAccessForm : Form
    {
        public static int Access = 0;
        public SetAccessForm()
        {
            Access = 0;
            InitializeComponent();
        }

        void GetTotalPermisstions()
        {
            int access = 0;
            if (CBlist.Checked)
            {
                access = access | Convert.ToInt32(CBlist.Tag.ToString());
            }
            if (CBadd.Checked)
            {
                access = access | Convert.ToInt32(CBadd.Tag.ToString());
            }
            if (CBdelete.Checked)
            {
                access = access | Convert.ToInt32(CBdelete.Tag.ToString());
            }
            if (CBupdate.Checked)
            {
                access = access | Convert.ToInt32(CBupdate.Tag.ToString());
            }
            if (CBfind.Checked)
            {
                access = access | Convert.ToInt32(CBfind.Tag.ToString());
            }

            if (CBtransactions.Checked)
            {
                access = access | Convert.ToInt32(CBtransactions.Tag.ToString());
            }

            if (CBmanage.Checked)
            {
                access = access | Convert.ToInt32(CBmanage.Tag.ToString());
            }
            if (CBLogs.Checked)
            {
                access = access | Convert.ToInt32(CBLogs.Tag.ToString());
            }
            if (CBcurrencies.Checked)
            {
                access = access | Convert.ToInt32(CBcurrencies.Tag.ToString());
            }

            Access = access;

        }
        private void RByes_CheckedChanged(object sender, EventArgs e)
        {
            if (RByes.Checked)
            {
                CBadd.Checked = true;
                CBcurrencies.Checked = true;
                CBdelete.Checked = true;
                CBfind.Checked = true;
                CBlist.Checked = true;
                CBLogs.Checked = true;
                CBmanage.Checked = true;
                CBtransactions.Checked = true;
                CBupdate.Checked = true;
                panel1.Enabled = false;
                Access = -1;
            }
        }

        private void SetAccessForm_Load(object sender, EventArgs e)
        {
           
        }

        private void RBno_CheckedChanged(object sender, EventArgs e)
        {
            if (RBno.Checked)
            {
                CBadd.Checked = false;
                CBcurrencies.Checked = false;
                CBdelete.Checked = false;
                CBfind.Checked = false;
                CBlist.Checked = false;
                CBLogs.Checked = false;
                CBmanage.Checked = false;
                CBtransactions.Checked = false;
                CBupdate.Checked = false;
                panel1.Enabled = true;
                Access = 0;
            }
        }

        private void CBlist_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBadd_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBupdate_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBdelete_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBfind_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBtransactions_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBmanage_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBLogs_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void CBcurrencies_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPermisstions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Access == 0)
            {
                MessageBox.Show("You Should give the User at Least one Permesstion", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }
    }
}
