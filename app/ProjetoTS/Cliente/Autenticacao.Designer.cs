
namespace Cliente
{
    partial class Autenticacao
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
            this.buttonGenerateSaltedHash = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxSizeSalt = new System.Windows.Forms.TextBox();
            this.textBoxSizePass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSalt = new System.Windows.Forms.TextBox();
            this.textBoxSaltedHash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerateSaltedHash
            // 
            this.buttonGenerateSaltedHash.Location = new System.Drawing.Point(827, 360);
            this.buttonGenerateSaltedHash.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerateSaltedHash.Name = "buttonGenerateSaltedHash";
            this.buttonGenerateSaltedHash.Size = new System.Drawing.Size(101, 29);
            this.buttonGenerateSaltedHash.TabIndex = 46;
            this.buttonGenerateSaltedHash.Text = "Generate";
            this.buttonGenerateSaltedHash.UseVisualStyleBackColor = true;
            this.buttonGenerateSaltedHash.Click += new System.EventHandler(this.buttonGenerateSaltedHash_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(223, 278);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 29);
            this.buttonLogin.TabIndex = 45;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // textBoxSizeSalt
            // 
            this.textBoxSizeSalt.Location = new System.Drawing.Point(950, 302);
            this.textBoxSizeSalt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSizeSalt.Name = "textBoxSizeSalt";
            this.textBoxSizeSalt.ReadOnly = true;
            this.textBoxSizeSalt.Size = new System.Drawing.Size(63, 22);
            this.textBoxSizeSalt.TabIndex = 44;
            // 
            // textBoxSizePass
            // 
            this.textBoxSizePass.Location = new System.Drawing.Point(947, 138);
            this.textBoxSizePass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSizePass.Name = "textBoxSizePass";
            this.textBoxSizePass.ReadOnly = true;
            this.textBoxSizePass.Size = new System.Drawing.Size(63, 22);
            this.textBoxSizePass.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(950, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Size (Bits)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "Size (Bits)";
            // 
            // textBoxSalt
            // 
            this.textBoxSalt.Location = new System.Drawing.Point(503, 278);
            this.textBoxSalt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSalt.Multiline = true;
            this.textBoxSalt.Name = "textBoxSalt";
            this.textBoxSalt.ReadOnly = true;
            this.textBoxSalt.Size = new System.Drawing.Size(425, 46);
            this.textBoxSalt.TabIndex = 40;
            // 
            // textBoxSaltedHash
            // 
            this.textBoxSaltedHash.Location = new System.Drawing.Point(503, 144);
            this.textBoxSaltedHash.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSaltedHash.Multiline = true;
            this.textBoxSaltedHash.Name = "textBoxSaltedHash";
            this.textBoxSaltedHash.ReadOnly = true;
            this.textBoxSaltedHash.Size = new System.Drawing.Size(425, 71);
            this.textBoxSaltedHash.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Salt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Salted Password Hash";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(78, 278);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(100, 29);
            this.buttonRegister.TabIndex = 36;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(68, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Login Window";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(78, 219);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(245, 22);
            this.textBoxPassword.TabIndex = 34;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(78, 145);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(245, 22);
            this.textBoxUsername.TabIndex = 33;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Username";
            // 
            // Autenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 425);
            this.Controls.Add(this.buttonGenerateSaltedHash);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxSizeSalt);
            this.Controls.Add(this.textBoxSizePass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSalt);
            this.Controls.Add(this.textBoxSaltedHash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autenticacao";
            this.Text = "UtilizadorDB";
            this.Load += new System.EventHandler(this.UtilizadorDB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateSaltedHash;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxSizeSalt;
        private System.Windows.Forms.TextBox textBoxSizePass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSalt;
        private System.Windows.Forms.TextBox textBoxSaltedHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}