namespace PresentationLayer2_WindowsForm
{
    partial class BaseForm
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
            this.Header = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Panel();
            this.Ldateandtime = new System.Windows.Forms.Label();
            this.LCurrentuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.P1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(70, 34);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(159, 81);
            this.Header.TabIndex = 0;
            this.Header.Text = "Null";
            // 
            // P1
            // 
            this.P1.Controls.Add(this.Ldateandtime);
            this.P1.Controls.Add(this.LCurrentuser);
            this.P1.Controls.Add(this.label2);
            this.P1.Controls.Add(this.label1);
            this.P1.Controls.Add(this.Header);
            this.P1.Location = new System.Drawing.Point(170, 12);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(1506, 183);
            this.P1.TabIndex = 1;
            this.P1.Paint += new System.Windows.Forms.PaintEventHandler(this.P1_Paint);
            // 
            // Ldateandtime
            // 
            this.Ldateandtime.AutoSize = true;
            this.Ldateandtime.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldateandtime.Location = new System.Drawing.Point(1005, 102);
            this.Ldateandtime.Name = "Ldateandtime";
            this.Ldateandtime.Size = new System.Drawing.Size(65, 36);
            this.Ldateandtime.TabIndex = 4;
            this.Ldateandtime.Text = "null";
            this.Ldateandtime.Click += new System.EventHandler(this.Ldateandtime_Click);
            // 
            // LCurrentuser
            // 
            this.LCurrentuser.AutoSize = true;
            this.LCurrentuser.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCurrentuser.Location = new System.Drawing.Point(1005, 16);
            this.LCurrentuser.Name = "LCurrentuser";
            this.LCurrentuser.Size = new System.Drawing.Size(78, 45);
            this.LCurrentuser.TabIndex = 3;
            this.LCurrentuser.Text = "null";
            this.LCurrentuser.Click += new System.EventHandler(this.LCurrentuser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(640, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date And Time : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current User  : ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 742);
            this.Controls.Add(this.P1);
            this.Name = "BaseForm";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Header;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ldateandtime;
        public System.Windows.Forms.Label LCurrentuser;
        private System.Windows.Forms.Timer timer1;
    }
}

