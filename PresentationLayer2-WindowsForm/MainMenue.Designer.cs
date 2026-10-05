namespace PresentationLayer2_WindowsForm
{
    partial class MainMenue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Blogout = new System.Windows.Forms.Button();
            this.Bcurrencies = new System.Windows.Forms.Button();
            this.BLogs = new System.Windows.Forms.Button();
            this.Bmanange = new System.Windows.Forms.Button();
            this.BFind = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.BAddnew = new System.Windows.Forms.Button();
            this.BTransactions = new System.Windows.Forms.Button();
            this.bListClient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Blogout);
            this.panel1.Controls.Add(this.Bcurrencies);
            this.panel1.Controls.Add(this.BLogs);
            this.panel1.Controls.Add(this.Bmanange);
            this.panel1.Controls.Add(this.BFind);
            this.panel1.Controls.Add(this.BUpdate);
            this.panel1.Controls.Add(this.Bdelete);
            this.panel1.Controls.Add(this.BAddnew);
            this.panel1.Controls.Add(this.BTransactions);
            this.panel1.Controls.Add(this.bListClient);
            this.panel1.Location = new System.Drawing.Point(50, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1831, 599);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Blogout
            // 
            this.Blogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogout.Location = new System.Drawing.Point(966, 491);
            this.Blogout.Name = "Blogout";
            this.Blogout.Size = new System.Drawing.Size(847, 89);
            this.Blogout.TabIndex = 9;
            this.Blogout.Text = "Logout";
            this.Blogout.UseVisualStyleBackColor = true;
            this.Blogout.Click += new System.EventHandler(this.Blogout_Click);
            // 
            // Bcurrencies
            // 
            this.Bcurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcurrencies.Location = new System.Drawing.Point(966, 371);
            this.Bcurrencies.Name = "Bcurrencies";
            this.Bcurrencies.Size = new System.Drawing.Size(847, 89);
            this.Bcurrencies.TabIndex = 8;
            this.Bcurrencies.Tag = "256";
            this.Bcurrencies.Text = "Currencies";
            this.Bcurrencies.UseVisualStyleBackColor = true;
            // 
            // BLogs
            // 
            this.BLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogs.Location = new System.Drawing.Point(966, 257);
            this.BLogs.Name = "BLogs";
            this.BLogs.Size = new System.Drawing.Size(847, 89);
            this.BLogs.TabIndex = 7;
            this.BLogs.Tag = "128";
            this.BLogs.Text = "Login Logs";
            this.BLogs.UseVisualStyleBackColor = true;
            // 
            // Bmanange
            // 
            this.Bmanange.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmanange.Location = new System.Drawing.Point(966, 131);
            this.Bmanange.Name = "Bmanange";
            this.Bmanange.Size = new System.Drawing.Size(847, 89);
            this.Bmanange.TabIndex = 6;
            this.Bmanange.Tag = "64";
            this.Bmanange.Text = "Manage User";
            this.Bmanange.UseVisualStyleBackColor = true;
            // 
            // BFind
            // 
            this.BFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFind.Location = new System.Drawing.Point(0, 491);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(847, 89);
            this.BFind.TabIndex = 4;
            this.BFind.Tag = "16";
            this.BFind.Text = "Find Client ";
            this.BFind.UseVisualStyleBackColor = true;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUpdate.Location = new System.Drawing.Point(0, 371);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(847, 89);
            this.BUpdate.TabIndex = 3;
            this.BUpdate.Tag = "8";
            this.BUpdate.Text = "Update Client Info";
            this.BUpdate.UseVisualStyleBackColor = true;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdelete.Location = new System.Drawing.Point(3, 257);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(847, 89);
            this.Bdelete.TabIndex = 2;
            this.Bdelete.Tag = "4";
            this.Bdelete.Text = "Delete Client";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // BAddnew
            // 
            this.BAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAddnew.Location = new System.Drawing.Point(3, 131);
            this.BAddnew.Name = "BAddnew";
            this.BAddnew.Size = new System.Drawing.Size(847, 89);
            this.BAddnew.TabIndex = 1;
            this.BAddnew.Tag = "2";
            this.BAddnew.Text = "Add New Client";
            this.BAddnew.UseVisualStyleBackColor = true;
            this.BAddnew.Click += new System.EventHandler(this.BAddnew_Click);
            // 
            // BTransactions
            // 
            this.BTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTransactions.Location = new System.Drawing.Point(966, 13);
            this.BTransactions.Name = "BTransactions";
            this.BTransactions.Size = new System.Drawing.Size(847, 89);
            this.BTransactions.TabIndex = 5;
            this.BTransactions.Tag = "32";
            this.BTransactions.Text = "Transaction";
            this.BTransactions.UseVisualStyleBackColor = true;
            // 
            // bListClient
            // 
            this.bListClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bListClient.Location = new System.Drawing.Point(3, 13);
            this.bListClient.Name = "bListClient";
            this.bListClient.Size = new System.Drawing.Size(847, 89);
            this.bListClient.TabIndex = 0;
            this.bListClient.Tag = "1";
            this.bListClient.Text = "List Clients";
            this.bListClient.UseVisualStyleBackColor = true;
            this.bListClient.Click += new System.EventHandler(this.bListClient_Click);
            // 
            // MainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 831);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenue";
            this.Text = "MainMenue";
            this.Load += new System.EventHandler(this.MainMenue_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BAddnew;
        private System.Windows.Forms.Button BTransactions;
        private System.Windows.Forms.Button bListClient;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.Button Bmanange;
        private System.Windows.Forms.Button Blogout;
        private System.Windows.Forms.Button Bcurrencies;
        private System.Windows.Forms.Button BLogs;
    }
}