namespace PresentationLayer2_WindowsForm
{
    partial class SetAccessForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RByes = new System.Windows.Forms.RadioButton();
            this.RBno = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBlist = new System.Windows.Forms.CheckBox();
            this.CBadd = new System.Windows.Forms.CheckBox();
            this.CBupdate = new System.Windows.Forms.CheckBox();
            this.CBdelete = new System.Windows.Forms.CheckBox();
            this.CBfind = new System.Windows.Forms.CheckBox();
            this.CBtransactions = new System.Windows.Forms.CheckBox();
            this.CBmanage = new System.Windows.Forms.CheckBox();
            this.CBLogs = new System.Windows.Forms.CheckBox();
            this.CBcurrencies = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do You want to give full Access ? ";
            // 
            // RByes
            // 
            this.RByes.AutoSize = true;
            this.RByes.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RByes.Location = new System.Drawing.Point(115, 129);
            this.RByes.Name = "RByes";
            this.RByes.Size = new System.Drawing.Size(101, 50);
            this.RByes.TabIndex = 1;
            this.RByes.TabStop = true;
            this.RByes.Text = "Yes";
            this.RByes.UseVisualStyleBackColor = true;
            this.RByes.CheckedChanged += new System.EventHandler(this.RByes_CheckedChanged);
            // 
            // RBno
            // 
            this.RBno.AutoSize = true;
            this.RBno.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBno.Location = new System.Drawing.Point(508, 129);
            this.RBno.Name = "RBno";
            this.RBno.Size = new System.Drawing.Size(87, 50);
            this.RBno.TabIndex = 2;
            this.RBno.TabStop = true;
            this.RBno.Text = "No";
            this.RBno.UseVisualStyleBackColor = true;
            this.RBno.CheckedChanged += new System.EventHandler(this.RBno_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBcurrencies);
            this.panel1.Controls.Add(this.CBLogs);
            this.panel1.Controls.Add(this.CBmanage);
            this.panel1.Controls.Add(this.CBtransactions);
            this.panel1.Controls.Add(this.CBfind);
            this.panel1.Controls.Add(this.CBdelete);
            this.panel1.Controls.Add(this.CBupdate);
            this.panel1.Controls.Add(this.CBadd);
            this.panel1.Controls.Add(this.CBlist);
            this.panel1.Location = new System.Drawing.Point(12, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 531);
            this.panel1.TabIndex = 3;
            // 
            // CBlist
            // 
            this.CBlist.AutoSize = true;
            this.CBlist.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBlist.Location = new System.Drawing.Point(25, 29);
            this.CBlist.Name = "CBlist";
            this.CBlist.Size = new System.Drawing.Size(197, 40);
            this.CBlist.TabIndex = 0;
            this.CBlist.Tag = "1";
            this.CBlist.Text = "List Clients";
            this.CBlist.UseVisualStyleBackColor = true;
            this.CBlist.CheckedChanged += new System.EventHandler(this.CBlist_CheckedChanged);
            // 
            // CBadd
            // 
            this.CBadd.AutoSize = true;
            this.CBadd.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBadd.Location = new System.Drawing.Point(25, 135);
            this.CBadd.Name = "CBadd";
            this.CBadd.Size = new System.Drawing.Size(186, 40);
            this.CBadd.TabIndex = 1;
            this.CBadd.Tag = "2";
            this.CBadd.Text = "Add Client";
            this.CBadd.UseVisualStyleBackColor = true;
            this.CBadd.CheckedChanged += new System.EventHandler(this.CBadd_CheckedChanged);
            // 
            // CBupdate
            // 
            this.CBupdate.AutoSize = true;
            this.CBupdate.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBupdate.Location = new System.Drawing.Point(15, 245);
            this.CBupdate.Name = "CBupdate";
            this.CBupdate.Size = new System.Drawing.Size(231, 40);
            this.CBupdate.TabIndex = 2;
            this.CBupdate.Tag = "4";
            this.CBupdate.Text = "Update Client";
            this.CBupdate.UseVisualStyleBackColor = true;
            this.CBupdate.CheckedChanged += new System.EventHandler(this.CBupdate_CheckedChanged);
            // 
            // CBdelete
            // 
            this.CBdelete.AutoSize = true;
            this.CBdelete.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBdelete.Location = new System.Drawing.Point(25, 359);
            this.CBdelete.Name = "CBdelete";
            this.CBdelete.Size = new System.Drawing.Size(221, 40);
            this.CBdelete.TabIndex = 3;
            this.CBdelete.Tag = "8";
            this.CBdelete.Text = "Delete Client";
            this.CBdelete.UseVisualStyleBackColor = true;
            this.CBdelete.CheckedChanged += new System.EventHandler(this.CBdelete_CheckedChanged);
            // 
            // CBfind
            // 
            this.CBfind.AutoSize = true;
            this.CBfind.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBfind.Location = new System.Drawing.Point(25, 462);
            this.CBfind.Name = "CBfind";
            this.CBfind.Size = new System.Drawing.Size(193, 40);
            this.CBfind.TabIndex = 4;
            this.CBfind.Tag = "16";
            this.CBfind.Text = "Find Client";
            this.CBfind.UseVisualStyleBackColor = true;
            this.CBfind.CheckedChanged += new System.EventHandler(this.CBfind_CheckedChanged);
            // 
            // CBtransactions
            // 
            this.CBtransactions.AutoSize = true;
            this.CBtransactions.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtransactions.Location = new System.Drawing.Point(420, 86);
            this.CBtransactions.Name = "CBtransactions";
            this.CBtransactions.Size = new System.Drawing.Size(221, 40);
            this.CBtransactions.TabIndex = 5;
            this.CBtransactions.Tag = "32";
            this.CBtransactions.Text = "Transactions";
            this.CBtransactions.UseVisualStyleBackColor = true;
            this.CBtransactions.CheckedChanged += new System.EventHandler(this.CBtransactions_CheckedChanged);
            // 
            // CBmanage
            // 
            this.CBmanage.AutoSize = true;
            this.CBmanage.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBmanage.Location = new System.Drawing.Point(420, 191);
            this.CBmanage.Name = "CBmanage";
            this.CBmanage.Size = new System.Drawing.Size(246, 40);
            this.CBmanage.TabIndex = 6;
            this.CBmanage.Tag = "64";
            this.CBmanage.Text = "Manage Users";
            this.CBmanage.UseVisualStyleBackColor = true;
            this.CBmanage.CheckedChanged += new System.EventHandler(this.CBmanage_CheckedChanged);
            // 
            // CBLogs
            // 
            this.CBLogs.AutoSize = true;
            this.CBLogs.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLogs.Location = new System.Drawing.Point(420, 291);
            this.CBLogs.Name = "CBLogs";
            this.CBLogs.Size = new System.Drawing.Size(195, 40);
            this.CBLogs.TabIndex = 7;
            this.CBLogs.Tag = "128";
            this.CBLogs.Text = "Login Logs";
            this.CBLogs.UseVisualStyleBackColor = true;
            this.CBLogs.CheckedChanged += new System.EventHandler(this.CBLogs_CheckedChanged);
            // 
            // CBcurrencies
            // 
            this.CBcurrencies.AutoSize = true;
            this.CBcurrencies.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBcurrencies.Location = new System.Drawing.Point(420, 409);
            this.CBcurrencies.Name = "CBcurrencies";
            this.CBcurrencies.Size = new System.Drawing.Size(195, 40);
            this.CBcurrencies.TabIndex = 8;
            this.CBcurrencies.Tag = "256";
            this.CBcurrencies.Text = "Currencies";
            this.CBcurrencies.UseVisualStyleBackColor = true;
            this.CBcurrencies.CheckedChanged += new System.EventHandler(this.CBcurrencies_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(462, 778);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RBno);
            this.Controls.Add(this.RByes);
            this.Controls.Add(this.label1);
            this.Name = "SetAccessForm";
            this.Text = "SetAccessForm";
            this.Load += new System.EventHandler(this.SetAccessForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RByes;
        private System.Windows.Forms.RadioButton RBno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CBlist;
        private System.Windows.Forms.CheckBox CBupdate;
        private System.Windows.Forms.CheckBox CBadd;
        private System.Windows.Forms.CheckBox CBcurrencies;
        private System.Windows.Forms.CheckBox CBLogs;
        private System.Windows.Forms.CheckBox CBmanage;
        private System.Windows.Forms.CheckBox CBtransactions;
        private System.Windows.Forms.CheckBox CBfind;
        private System.Windows.Forms.CheckBox CBdelete;
        private System.Windows.Forms.Button button1;
    }
}