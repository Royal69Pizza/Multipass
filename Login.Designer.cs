namespace Multipass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonExitBeforeLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Praetorian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "MULTIPASS";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.Green;
            this.ButtonLogin.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(17, 75);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(202, 26);
            this.ButtonLogin.TabIndex = 19;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // inputLogin
            // 
            this.inputLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputLogin.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLogin.ForeColor = System.Drawing.Color.White;
            this.inputLogin.Location = new System.Drawing.Point(104, 43);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.PasswordChar = '∎';
            this.inputLogin.Size = new System.Drawing.Size(185, 26);
            this.inputLogin.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Master Key";
            // 
            // ButtonExitBeforeLogin
            // 
            this.ButtonExitBeforeLogin.BackColor = System.Drawing.Color.Maroon;
            this.ButtonExitBeforeLogin.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExitBeforeLogin.Location = new System.Drawing.Point(225, 75);
            this.ButtonExitBeforeLogin.Name = "ButtonExitBeforeLogin";
            this.ButtonExitBeforeLogin.Size = new System.Drawing.Size(64, 26);
            this.ButtonExitBeforeLogin.TabIndex = 22;
            this.ButtonExitBeforeLogin.Text = "EXIT";
            this.ButtonExitBeforeLogin.UseVisualStyleBackColor = false;
            this.ButtonExitBeforeLogin.Click += new System.EventHandler(this.ButtonExitBeforeLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(307, 113);
            this.Controls.Add(this.ButtonExitBeforeLogin);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonExitBeforeLogin;
    }
}