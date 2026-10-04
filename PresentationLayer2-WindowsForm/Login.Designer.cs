namespace PresentationLayer2_WindowsForm
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.Tbpassword = new System.Windows.Forms.TextBox();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(977, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Please Enter Your UserName and Password to Login : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 55);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 55);
            this.label5.TabIndex = 7;
            this.label5.Text = "User Name : ";
            // 
            // TBusername
            // 
            this.TBusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusername.Location = new System.Drawing.Point(411, 359);
            this.TBusername.Multiline = true;
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(551, 89);
            this.TBusername.TabIndex = 0;
            this.TBusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBusername.Validating += new System.ComponentModel.CancelEventHandler(this.TBusername_Validating);
            // 
            // Tbpassword
            // 
            this.Tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbpassword.Location = new System.Drawing.Point(411, 487);
            this.Tbpassword.Multiline = true;
            this.Tbpassword.Name = "Tbpassword";
            this.Tbpassword.PasswordChar = '*';
            this.Tbpassword.Size = new System.Drawing.Size(551, 89);
            this.Tbpassword.TabIndex = 1;
            this.Tbpassword.TextChanged += new System.EventHandler(this.Tbpassword_TextChanged);
            this.Tbpassword.Validating += new System.ComponentModel.CancelEventHandler(this.Tbpassword_Validating);
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // BLogin
            // 
            this.BLogin.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.Location = new System.Drawing.Point(1309, 628);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(379, 89);
            this.BLogin.TabIndex = 8;
            this.BLogin.Text = "Login";
            this.BLogin.UseVisualStyleBackColor = true;
            this.BLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(998, 540);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(255, 36);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BExit
            // 
            this.BExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BExit.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExit.Location = new System.Drawing.Point(36, 628);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(379, 89);
            this.BExit.TabIndex = 10;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.BLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BExit;
            this.ClientSize = new System.Drawing.Size(1804, 782);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.Tbpassword);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TBusername, 0);
            this.Controls.SetChildIndex(this.Tbpassword, 0);
            this.Controls.SetChildIndex(this.BLogin, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.BExit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox Tbpassword;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BExit;
    }
}