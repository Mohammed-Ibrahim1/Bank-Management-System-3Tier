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
        public MainMenue()
        {
            Header.Text = "Main Menue";
            InitializeComponent();
        }

        private void MainMenue_Load(object sender, EventArgs e)
        {

        }
        
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();


        }
    }
}
