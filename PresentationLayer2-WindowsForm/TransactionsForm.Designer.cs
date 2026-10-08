namespace PresentationLayer2_WindowsForm
{
    partial class TransactionsForm
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
            this.BDesposit = new System.Windows.Forms.Button();
            this.Bwithdraw = new System.Windows.Forms.Button();
            this.bTrans = new System.Windows.Forms.Button();
            this.Blog = new System.Windows.Forms.Button();
            this.Bmain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BDesposit
            // 
            this.BDesposit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDesposit.Location = new System.Drawing.Point(170, 240);
            this.BDesposit.Name = "BDesposit";
            this.BDesposit.Size = new System.Drawing.Size(1506, 83);
            this.BDesposit.TabIndex = 0;
            this.BDesposit.Text = "Desposit";
            this.BDesposit.UseVisualStyleBackColor = true;
            this.BDesposit.Click += new System.EventHandler(this.BDesposit_Click);
            // 
            // Bwithdraw
            // 
            this.Bwithdraw.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bwithdraw.Location = new System.Drawing.Point(170, 367);
            this.Bwithdraw.Name = "Bwithdraw";
            this.Bwithdraw.Size = new System.Drawing.Size(1506, 83);
            this.Bwithdraw.TabIndex = 1;
            this.Bwithdraw.Text = "Withdraw";
            this.Bwithdraw.UseVisualStyleBackColor = true;
            this.Bwithdraw.Click += new System.EventHandler(this.Bwithdraw_Click);
            // 
            // bTrans
            // 
            this.bTrans.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTrans.Location = new System.Drawing.Point(170, 501);
            this.bTrans.Name = "bTrans";
            this.bTrans.Size = new System.Drawing.Size(1506, 83);
            this.bTrans.TabIndex = 2;
            this.bTrans.Text = "Transfer";
            this.bTrans.UseVisualStyleBackColor = true;
            this.bTrans.Click += new System.EventHandler(this.bTrans_Click);
            // 
            // Blog
            // 
            this.Blog.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blog.Location = new System.Drawing.Point(170, 632);
            this.Blog.Name = "Blog";
            this.Blog.Size = new System.Drawing.Size(1506, 83);
            this.Blog.TabIndex = 3;
            this.Blog.Text = "Transations Log";
            this.Blog.UseVisualStyleBackColor = true;
            this.Blog.Click += new System.EventHandler(this.Blog_Click);
            // 
            // Bmain
            // 
            this.Bmain.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmain.Location = new System.Drawing.Point(170, 752);
            this.Bmain.Name = "Bmain";
            this.Bmain.Size = new System.Drawing.Size(1506, 83);
            this.Bmain.TabIndex = 4;
            this.Bmain.Text = "Main Menue";
            this.Bmain.UseVisualStyleBackColor = true;
            this.Bmain.Click += new System.EventHandler(this.Bmain_Click);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 847);
            this.Controls.Add(this.Bmain);
            this.Controls.Add(this.Blog);
            this.Controls.Add(this.bTrans);
            this.Controls.Add(this.Bwithdraw);
            this.Controls.Add(this.BDesposit);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            this.Controls.SetChildIndex(this.BDesposit, 0);
            this.Controls.SetChildIndex(this.Bwithdraw, 0);
            this.Controls.SetChildIndex(this.bTrans, 0);
            this.Controls.SetChildIndex(this.Blog, 0);
            this.Controls.SetChildIndex(this.Bmain, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BDesposit;
        private System.Windows.Forms.Button Bwithdraw;
        private System.Windows.Forms.Button bTrans;
        private System.Windows.Forms.Button Blog;
        private System.Windows.Forms.Button Bmain;
    }
}