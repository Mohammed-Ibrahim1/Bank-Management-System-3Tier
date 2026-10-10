namespace PresentationLayer2_WindowsForm
{
    partial class CurrenciesMainForm
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
            this.Bmain = new System.Windows.Forms.Button();
            this.Bcalcuator = new System.Windows.Forms.Button();
            this.Bupdaterate = new System.Windows.Forms.Button();
            this.Bfindcurrency = new System.Windows.Forms.Button();
            this.Blistcurrency = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bmain
            // 
            this.Bmain.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmain.Location = new System.Drawing.Point(170, 732);
            this.Bmain.Name = "Bmain";
            this.Bmain.Size = new System.Drawing.Size(1506, 83);
            this.Bmain.TabIndex = 9;
            this.Bmain.Text = "Main Menue";
            this.Bmain.UseVisualStyleBackColor = true;
            this.Bmain.Click += new System.EventHandler(this.Bmain_Click);
            // 
            // Bcalcuator
            // 
            this.Bcalcuator.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcalcuator.Location = new System.Drawing.Point(170, 601);
            this.Bcalcuator.Name = "Bcalcuator";
            this.Bcalcuator.Size = new System.Drawing.Size(1506, 83);
            this.Bcalcuator.TabIndex = 8;
            this.Bcalcuator.Text = "Currencies Calcualtor";
            this.Bcalcuator.UseVisualStyleBackColor = true;
            this.Bcalcuator.Click += new System.EventHandler(this.Bcalcuator_Click);
            // 
            // Bupdaterate
            // 
            this.Bupdaterate.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bupdaterate.Location = new System.Drawing.Point(170, 476);
            this.Bupdaterate.Name = "Bupdaterate";
            this.Bupdaterate.Size = new System.Drawing.Size(1506, 83);
            this.Bupdaterate.TabIndex = 7;
            this.Bupdaterate.Text = "Update Rate";
            this.Bupdaterate.UseVisualStyleBackColor = true;
            this.Bupdaterate.Click += new System.EventHandler(this.Bupdaterate_Click);
            // 
            // Bfindcurrency
            // 
            this.Bfindcurrency.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bfindcurrency.Location = new System.Drawing.Point(170, 348);
            this.Bfindcurrency.Name = "Bfindcurrency";
            this.Bfindcurrency.Size = new System.Drawing.Size(1506, 83);
            this.Bfindcurrency.TabIndex = 6;
            this.Bfindcurrency.Text = "Find Currency";
            this.Bfindcurrency.UseVisualStyleBackColor = true;
            this.Bfindcurrency.Click += new System.EventHandler(this.Bfindcurrency_Click);
            // 
            // Blistcurrency
            // 
            this.Blistcurrency.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blistcurrency.Location = new System.Drawing.Point(170, 225);
            this.Blistcurrency.Name = "Blistcurrency";
            this.Blistcurrency.Size = new System.Drawing.Size(1506, 83);
            this.Blistcurrency.TabIndex = 5;
            this.Blistcurrency.Text = "List Currencies";
            this.Blistcurrency.UseVisualStyleBackColor = true;
            this.Blistcurrency.Click += new System.EventHandler(this.Blistcurrency_Click);
            // 
            // CurrenciesMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 849);
            this.Controls.Add(this.Bmain);
            this.Controls.Add(this.Bcalcuator);
            this.Controls.Add(this.Bupdaterate);
            this.Controls.Add(this.Bfindcurrency);
            this.Controls.Add(this.Blistcurrency);
            this.Name = "CurrenciesMainForm";
            this.Text = "CurrenciesMainForm";
            this.Load += new System.EventHandler(this.CurrenciesMainForm_Load);
            this.Controls.SetChildIndex(this.Blistcurrency, 0);
            this.Controls.SetChildIndex(this.Bfindcurrency, 0);
            this.Controls.SetChildIndex(this.Bupdaterate, 0);
            this.Controls.SetChildIndex(this.Bcalcuator, 0);
            this.Controls.SetChildIndex(this.Bmain, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bmain;
        private System.Windows.Forms.Button Bcalcuator;
        private System.Windows.Forms.Button Bupdaterate;
        private System.Windows.Forms.Button Bfindcurrency;
        private System.Windows.Forms.Button Blistcurrency;
    }
}