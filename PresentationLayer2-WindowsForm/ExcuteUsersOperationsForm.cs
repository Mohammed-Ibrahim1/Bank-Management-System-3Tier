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
    public partial class ExcuteUsersOperationsForm : BaseForm
    {
        int mode = 0;
        public ExcuteUsersOperationsForm(int Mode , clsUsersOperations User  = null) 
        {
            CurrentUser = User;
            mode = Mode;
            InitializeComponent();
            

        }


        void FillData ()
        {
            Laccess.Text = CurrentUser.Accessibilities.ToString();
            Tfirstname.Text = CurrentUser.FirstName.ToString();
            Tlastname.Text = CurrentUser.LastName.ToString();
            Temail.Text = CurrentUser.Email.ToString();
            TphoneNumber.Text = CurrentUser.Phone.ToString();
            Tpassword.Text = CurrentUser.Password.ToString();
            Tusername.Text = CurrentUser.UserName.ToString();
            LUserid.Text = CurrentUser.UserID.ToString();

        }
        clsUsersOperations CurrentUser = null;
        private void ExcuteUsersOperationsForm_Load(object sender, EventArgs e)
        {
            switch (mode)
            {

                case 2:

                    {
                        Header.Text = "Add New User";
                        Laccess.Text = "0";
                        clsUsersOperations User = new clsUsersOperations();
                        CurrentUser = User;
                        break;
                    }

                case 3:
                    {
                        Header.Text = "Delete User";
                      FillData();
                        Bsave.Visible = false;
                        Tfirstname.ReadOnly = true;
                        Tlastname.ReadOnly = true;
                        Temail.ReadOnly = true;
                        TphoneNumber.ReadOnly = true;
                        Tpassword.ReadOnly = true;
                        Tusername.ReadOnly = true;
                        linkLabel1.Visible = false;
                        break;
                    }
                case 4:
                    {
                        Header.Text = "Update User";
                        FillData(); 

                        Bsave.Visible = true;
                        Tfirstname.ReadOnly = false;
                        Tlastname.ReadOnly = false;
                        Temail.ReadOnly = false;
                        TphoneNumber.ReadOnly = false;
                        Tusername.ReadOnly = true;
                        linkLabel1.Visible = true;
                        Bdelete.Visible = false;

                        break;
                    }

                case 5:
                    {
                        Header.Text = "Find User";
                        FillData();
                        Bsave.Visible = false;
                        Tfirstname.ReadOnly = true;
                        Tlastname.ReadOnly = true;
                        Temail.ReadOnly = true;
                        TphoneNumber.ReadOnly = true;
                        Tpassword.ReadOnly = true;
                        Tusername.ReadOnly = true;
                        linkLabel1.Visible = false;
                        Bdelete.Visible = false;
                        linkLabel2.Visible = true;
                        Lmessage.Visible = true;
                        break;
                    }
            
            
            
            
         
            
            }
        }

        private void Bsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Tfirstname.Text) || string.IsNullOrEmpty(Tlastname.Text) || string.IsNullOrEmpty(Temail.Text) || string.IsNullOrEmpty(TphoneNumber.Text)
               || string.IsNullOrEmpty(Tusername.Text) || string.IsNullOrEmpty(Tpassword.Text) || Convert.ToInt32(Laccess.Text) == 0)
            {
                MessageBox.Show("NO Empty Field Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                        LUserid.Text = "Auto";
                CurrentUser.FirstName = Tfirstname.Text.ToString();
                CurrentUser.LastName = Tlastname.Text.ToString();
                CurrentUser.Email = Temail.Text.ToString();
                CurrentUser.Phone = TphoneNumber.Text.ToString();
                CurrentUser.UserName  = Tusername.Text.ToString();
                CurrentUser.Password = Tpassword.Text.ToString();
                CurrentUser.Accessibilities = Convert.ToInt32(Laccess.Text.ToString());

              
                 if (MessageBox.Show("Are You Sure ?" ,  "Confirmation" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question , MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        if (CurrentUser.Save())
                    {
                        MessageBox.Show("User Saved Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Operation Canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                this .Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form F1 = new SetAccessForm();
            F1.ShowDialog();
            Laccess.Text = SetAccessForm.Access.ToString();
        }

        private void Laccess_Click(object sender, EventArgs e)
        {

        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
         
            if (MessageBox.Show("Are you sure to Delete this User ?" , "Confirmation"  , MessageBoxButtons.OKCancel , MessageBoxIcon.Question , MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (CurrentUser._DeleteUser())
                {
                    MessageBox.Show("User Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation Cancled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this .Close();
            }
        }
    }
}
