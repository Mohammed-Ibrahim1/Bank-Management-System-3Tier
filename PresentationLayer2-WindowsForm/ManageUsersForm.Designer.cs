namespace PresentationLayer2_WindowsForm
{
    partial class ManageUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bfind = new System.Windows.Forms.Button();
            this.Bupdate = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.BAddnew = new System.Windows.Forms.Button();
            this.Blistusers = new System.Windows.Forms.Button();
            this.Bmain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bfind
            // 
            this.Bfind.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bfind.Location = new System.Drawing.Point(170, 654);
            this.Bfind.Name = "Bfind";
            this.Bfind.Size = new System.Drawing.Size(1506, 83);
            this.Bfind.TabIndex = 4;
            this.Bfind.Text = "Find User";
            this.Bfind.UseVisualStyleBackColor = true;
            this.Bfind.Click += new System.EventHandler(this.Bfind_Click);
            // 
            // Bupdate
            // 
            this.Bupdate.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bupdate.Location = new System.Drawing.Point(170, 550);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(1506, 83);
            this.Bupdate.TabIndex = 3;
            this.Bupdate.Text = "Update User";
            this.Bupdate.UseVisualStyleBackColor = true;
            this.Bupdate.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdelete.Location = new System.Drawing.Point(170, 444);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(1506, 83);
            this.Bdelete.TabIndex = 2;
            this.Bdelete.Text = "Delete User";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // BAddnew
            // 
            this.BAddnew.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddnew.Location = new System.Drawing.Point(170, 336);
            this.BAddnew.Name = "BAddnew";
            this.BAddnew.Size = new System.Drawing.Size(1506, 83);
            this.BAddnew.TabIndex = 1;
            this.BAddnew.Text = "Add New User";
            this.BAddnew.UseVisualStyleBackColor = true;
            this.BAddnew.Click += new System.EventHandler(this.BAddnew_Click);
            // 
            // Blistusers
            // 
            this.Blistusers.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blistusers.Location = new System.Drawing.Point(170, 232);
            this.Blistusers.Name = "Blistusers";
            this.Blistusers.Size = new System.Drawing.Size(1506, 83);
            this.Blistusers.TabIndex = 0;
            this.Blistusers.Text = "List Users";
            this.Blistusers.UseVisualStyleBackColor = true;
            this.Blistusers.Click += new System.EventHandler(this.Blistusers_Click);
            // 
            // Bmain
            // 
            this.Bmain.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmain.Location = new System.Drawing.Point(170, 761);
            this.Bmain.Name = "Bmain";
            this.Bmain.Size = new System.Drawing.Size(1506, 83);
            this.Bmain.TabIndex = 5;
            this.Bmain.Text = "Main Menue";
            this.Bmain.UseVisualStyleBackColor = true;
            this.Bmain.Click += new System.EventHandler(this.Bmain_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1790, 855);
            this.Controls.Add(this.Bmain);
            this.Controls.Add(this.Bfind);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.Bdelete);
            this.Controls.Add(this.BAddnew);
            this.Controls.Add(this.Blistusers);
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsersForm";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.Controls.SetChildIndex(this.Blistusers, 0);
            this.Controls.SetChildIndex(this.BAddnew, 0);
            this.Controls.SetChildIndex(this.Bdelete, 0);
            this.Controls.SetChildIndex(this.Bupdate, 0);
            this.Controls.SetChildIndex(this.Bfind, 0);
            this.Controls.SetChildIndex(this.Bmain, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bfind;
        private System.Windows.Forms.Button Bupdate;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button BAddnew;
        private System.Windows.Forms.Button Blistusers;
        private System.Windows.Forms.Button Bmain;
    }
}