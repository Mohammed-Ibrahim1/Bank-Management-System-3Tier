namespace PresentationLayer2_WindowsForm
{
    partial class CurrenciesCalculator
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
            this.CBCurrency1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBCurrency2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Bclose = new System.Windows.Forms.Button();
            this.TAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Currency 1 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "From  : ";
            // 
            // CBCurrency1
            // 
            this.CBCurrency1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurrency1.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCurrency1.FormattingEnabled = true;
            this.CBCurrency1.Location = new System.Drawing.Point(237, 155);
            this.CBCurrency1.Name = "CBCurrency1";
            this.CBCurrency1.Size = new System.Drawing.Size(253, 45);
            this.CBCurrency1.TabIndex = 2;
            this.CBCurrency1.SelectedIndexChanged += new System.EventHandler(this.CBCurrency1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose Currency 2 : ";
            // 
            // CBCurrency2
            // 
            this.CBCurrency2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCurrency2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCurrency2.FormattingEnabled = true;
            this.CBCurrency2.Location = new System.Drawing.Point(237, 390);
            this.CBCurrency2.Name = "CBCurrency2";
            this.CBCurrency2.Size = new System.Drawing.Size(253, 45);
            this.CBCurrency2.TabIndex = 5;
            this.CBCurrency2.SelectedIndexChanged += new System.EventHandler(this.CBCurrency2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "To  : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Result ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 627);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(347, 49);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Bclose
            // 
            this.Bclose.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bclose.Location = new System.Drawing.Point(195, 731);
            this.Bclose.Name = "Bclose";
            this.Bclose.Size = new System.Drawing.Size(333, 83);
            this.Bclose.TabIndex = 10;
            this.Bclose.Text = "Close";
            this.Bclose.UseVisualStyleBackColor = true;
            this.Bclose.Click += new System.EventHandler(this.Bclose_Click);
            // 
            // TAmount
            // 
            this.TAmount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAmount.Location = new System.Drawing.Point(237, 521);
            this.TAmount.Name = "TAmount";
            this.TAmount.Size = new System.Drawing.Size(347, 49);
            this.TAmount.TabIndex = 11;
            this.TAmount.TextChanged += new System.EventHandler(this.TAmount_TextChanged);
            this.TAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TAmount_KeyPress);
            // 
            // CurrenciesCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 826);
            this.Controls.Add(this.TAmount);
            this.Controls.Add(this.Bclose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBCurrency2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBCurrency1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrenciesCalculator";
            this.Text = "CurrenciesCalculator";
            this.Load += new System.EventHandler(this.CurrenciesCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBCurrency1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBCurrency2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Bclose;
        private System.Windows.Forms.TextBox TAmount;
    }
}