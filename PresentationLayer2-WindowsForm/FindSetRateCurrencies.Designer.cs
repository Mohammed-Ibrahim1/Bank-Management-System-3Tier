namespace PresentationLayer2_WindowsForm
{
    partial class FindSetRateCurrencies
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bsubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Bback = new System.Windows.Forms.Button();
            this.LID = new System.Windows.Forms.Label();
            this.Lcountry = new System.Windows.Forms.Label();
            this.Lcode = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Lrate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency Code : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Currency Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rate : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Bsubmit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 156);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // Bsubmit
            // 
            this.Bsubmit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsubmit.Location = new System.Drawing.Point(351, 81);
            this.Bsubmit.Name = "Bsubmit";
            this.Bsubmit.Size = new System.Drawing.Size(281, 61);
            this.Bsubmit.TabIndex = 9;
            this.Bsubmit.Text = "Submit";
            this.Bsubmit.UseVisualStyleBackColor = true;
            this.Bsubmit.Click += new System.EventHandler(this.Bsubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "Enter New Rate  : ";
            // 
            // Bback
            // 
            this.Bback.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bback.Location = new System.Drawing.Point(119, 765);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(455, 71);
            this.Bback.TabIndex = 10;
            this.Bback.Text = "Back";
            this.Bback.UseVisualStyleBackColor = true;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LID.Location = new System.Drawing.Point(342, 152);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(97, 36);
            this.LID.TabIndex = 11;
            this.LID.Text = "NULL";
            // 
            // Lcountry
            // 
            this.Lcountry.AutoSize = true;
            this.Lcountry.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcountry.Location = new System.Drawing.Point(342, 245);
            this.Lcountry.Name = "Lcountry";
            this.Lcountry.Size = new System.Drawing.Size(97, 36);
            this.Lcountry.TabIndex = 12;
            this.Lcountry.Text = "NULL";
            // 
            // Lcode
            // 
            this.Lcode.AutoSize = true;
            this.Lcode.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcode.Location = new System.Drawing.Point(342, 332);
            this.Lcode.Name = "Lcode";
            this.Lcode.Size = new System.Drawing.Size(97, 36);
            this.Lcode.TabIndex = 13;
            this.Lcode.Text = "NULL";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(342, 424);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(97, 36);
            this.Lname.TabIndex = 14;
            this.Lname.Text = "NULL";
            // 
            // Lrate
            // 
            this.Lrate.AutoSize = true;
            this.Lrate.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lrate.Location = new System.Drawing.Point(342, 515);
            this.Lrate.Name = "Lrate";
            this.Lrate.Size = new System.Drawing.Size(97, 36);
            this.Lrate.TabIndex = 15;
            this.Lrate.Text = "NULL";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(351, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 40);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // FindSetRateCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 848);
            this.Controls.Add(this.Lrate);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lcode);
            this.Controls.Add(this.Lcountry);
            this.Controls.Add(this.LID);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindSetRateCurrencies";
            this.Text = "FindSetRateCurrencies";
            this.Load += new System.EventHandler(this.FindSetRateCurrencies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bsubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label Lcountry;
        private System.Windows.Forms.Label Lcode;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lrate;
        private System.Windows.Forms.TextBox textBox1;
    }
}