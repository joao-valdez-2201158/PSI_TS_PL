
namespace Cliente
{
    partial class Mensagens
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
            this.tbChat = new System.Windows.Forms.TextBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.tb2Chat = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(12, 412);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.Size = new System.Drawing.Size(625, 43);
            this.tbChat.TabIndex = 1;
            this.tbChat.TextChanged += new System.EventHandler(this.tbChat_TextChanged);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(654, 412);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(134, 43);
            this.btnChat.TabIndex = 5;
            this.btnChat.Text = "Enviar";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // tb2Chat
            // 
            this.tb2Chat.Location = new System.Drawing.Point(12, 63);
            this.tb2Chat.Multiline = true;
            this.tb2Chat.Name = "tb2Chat";
            this.tb2Chat.ReadOnly = true;
            this.tb2Chat.Size = new System.Drawing.Size(776, 343);
            this.tb2Chat.TabIndex = 6;
            // 
            // lbChat
            // 
            this.lbChat.AutoSize = true;
            this.lbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChat.Location = new System.Drawing.Point(246, 22);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(328, 25);
            this.lbChat.TabIndex = 7;
            this.lbChat.Text = "Enviar/Receber Mensagens de Chat";
            // 
            // Mensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 490);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.tb2Chat);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.tbChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Mensagens";
            this.Text = "Mensagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.TextBox tb2Chat;
        private System.Windows.Forms.Label lbChat;
    }
}