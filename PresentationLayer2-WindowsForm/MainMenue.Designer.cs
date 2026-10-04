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
            this.Bback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Bback
            // 
            this.Bback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Bback.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bback.Location = new System.Drawing.Point(12, 12);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(152, 93);
            this.Bback.TabIndex = 2;
            this.Bback.Text = "Back";
            this.Bback.UseVisualStyleBackColor = true;
            this.Bback.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1854, 601);
            this.panel1.TabIndex = 3;
            // 
            // MainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Bback;
            this.ClientSize = new System.Drawing.Size(1909, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bback);
            this.Name = "MainMenue";
            this.Text = "MainMenue";
            this.Load += new System.EventHandler(this.MainMenue_Load);
            this.Controls.SetChildIndex(this.Bback, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.Panel panel1;
    }
}