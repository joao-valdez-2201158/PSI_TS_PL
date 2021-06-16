
namespace Cliente
{
    partial class Chat
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnMensagens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Criptografia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMensagens
            // 
            this.btnMensagens.Location = new System.Drawing.Point(65, 142);
            this.btnMensagens.Name = "btnMensagens";
            this.btnMensagens.Size = new System.Drawing.Size(171, 59);
            this.btnMensagens.TabIndex = 2;
            this.btnMensagens.Text = "Mensagens";
            this.btnMensagens.UseVisualStyleBackColor = true;
            this.btnMensagens.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMensagens);
            this.Controls.Add(this.button2);
            this.Name = "Chat";
            this.Text = "Chat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMensagens;
        private System.Windows.Forms.Label label1;
    }
}