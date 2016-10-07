namespace zooManager
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textRegLogin = new System.Windows.Forms.TextBox();
            this.textRegName = new System.Windows.Forms.TextBox();
            this.textRegSurname = new System.Windows.Forms.TextBox();
            this.textRegPassword = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textRegSecretPhrase = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabRegister);
            this.tabControl1.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 238);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.linkLabel1);
            this.tabLogin.Controls.Add(this.buttonLogin);
            this.tabLogin.Controls.Add(this.textPassword);
            this.tabLogin.Controls.Add(this.textLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 24);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(252, 210);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.textRegSecretPhrase);
            this.tabRegister.Controls.Add(this.label2);
            this.tabRegister.Controls.Add(this.buttonRegister);
            this.tabRegister.Controls.Add(this.textRegPassword);
            this.tabRegister.Controls.Add(this.textRegSurname);
            this.tabRegister.Controls.Add(this.textRegName);
            this.tabRegister.Controls.Add(this.textRegLogin);
            this.tabRegister.Location = new System.Drawing.Point(4, 24);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(252, 210);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(7, 89);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(239, 23);
            this.textLogin.TabIndex = 0;
            this.textLogin.Tag = "Login";
            this.textLogin.Text = "Login";
            this.textLogin.TextChanged += new System.EventHandler(this.ValidateLogin);
            this.textLogin.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textLogin.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(7, 116);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(239, 23);
            this.textPassword.TabIndex = 1;
            this.textPassword.Tag = "Password";
            this.textPassword.Text = "Password";
            this.textPassword.TextChanged += new System.EventHandler(this.ValidateLogin);
            this.textPassword.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textPassword.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Enabled = false;
            this.buttonLogin.Location = new System.Drawing.Point(171, 142);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Marker", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(6, 146);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Account";
            // 
            // textRegLogin
            // 
            this.textRegLogin.Location = new System.Drawing.Point(6, 40);
            this.textRegLogin.Name = "textRegLogin";
            this.textRegLogin.Size = new System.Drawing.Size(239, 23);
            this.textRegLogin.TabIndex = 0;
            this.textRegLogin.Tag = "Login";
            this.textRegLogin.Text = "Login";
            this.textRegLogin.TextChanged += new System.EventHandler(this.ValidateRegister);
            this.textRegLogin.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textRegLogin.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // textRegName
            // 
            this.textRegName.Location = new System.Drawing.Point(6, 69);
            this.textRegName.Name = "textRegName";
            this.textRegName.Size = new System.Drawing.Size(239, 23);
            this.textRegName.TabIndex = 1;
            this.textRegName.Tag = "Name";
            this.textRegName.Text = "Name";
            this.textRegName.TextChanged += new System.EventHandler(this.ValidateRegister);
            this.textRegName.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textRegName.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // textRegSurname
            // 
            this.textRegSurname.Location = new System.Drawing.Point(6, 98);
            this.textRegSurname.Name = "textRegSurname";
            this.textRegSurname.Size = new System.Drawing.Size(239, 23);
            this.textRegSurname.TabIndex = 2;
            this.textRegSurname.Tag = "Surname";
            this.textRegSurname.Text = "Surname";
            this.textRegSurname.TextChanged += new System.EventHandler(this.ValidateRegister);
            this.textRegSurname.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textRegSurname.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // textRegPassword
            // 
            this.textRegPassword.Location = new System.Drawing.Point(6, 127);
            this.textRegPassword.Name = "textRegPassword";
            this.textRegPassword.Size = new System.Drawing.Size(239, 23);
            this.textRegPassword.TabIndex = 3;
            this.textRegPassword.Tag = "Password";
            this.textRegPassword.Text = "Password";
            this.textRegPassword.TextChanged += new System.EventHandler(this.ValidateRegister);
            this.textRegPassword.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textRegPassword.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Enabled = false;
            this.buttonRegister.Location = new System.Drawing.Point(171, 185);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Account";
            // 
            // textRegSecretPhrase
            // 
            this.textRegSecretPhrase.Location = new System.Drawing.Point(6, 156);
            this.textRegSecretPhrase.Name = "textRegSecretPhrase";
            this.textRegSecretPhrase.Size = new System.Drawing.Size(239, 23);
            this.textRegSecretPhrase.TabIndex = 6;
            this.textRegSecretPhrase.Tag = "Secret Phrase";
            this.textRegSecretPhrase.Text = "Secret Phrase";
            this.textRegSecretPhrase.TextChanged += new System.EventHandler(this.ValidateRegister);
            this.textRegSecretPhrase.Enter += new System.EventHandler(this.ProccessPlaceholderTagIn);
            this.textRegSecretPhrase.Leave += new System.EventHandler(this.ProccessPlaceholderTagOut);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Manager | Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRegLogin;
        private System.Windows.Forms.TextBox textRegName;
        private System.Windows.Forms.TextBox textRegSurname;
        private System.Windows.Forms.TextBox textRegPassword;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRegSecretPhrase;

    }
}

