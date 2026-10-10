using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;

namespace PresentationLayer2_WindowsForm
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            
            InitializeComponent();
            if (Login._CurrentUser != null)
            {
                LCurrentuser.Text = Login._CurrentUser.UserName;
            }
            else
            {
                LCurrentuser.Text = "NULL";
            }
            Ldateandtime.Text = DateTime.Now.ToString("dddd/M/yyyy HH:mm:ss");
        }

      
        private void P1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ldateandtime_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ldateandtime.Text = DateTime.Now.ToString("dddd/M/yyyy HH:mm:ss");
            
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LCurrentuser_Click(object sender, EventArgs e)
        {

        }
    }
}
