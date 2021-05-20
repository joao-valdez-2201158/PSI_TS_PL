
namespace Cliente
{
    partial class Menu_Principal
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
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnFicheiros = new System.Windows.Forms.Button();
            this.lbMensagens = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(12, 175);
            this.tbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPort.Multiline = true;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(135, 26);
            this.tbPort.TabIndex = 0;
            // 
            // lbMenu
            // 
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMenu.Location = new System.Drawing.Point(176, 29);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(399, 56);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu Principal";
            this.lbMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbMenu.Click += new System.EventHandler(this.lbMenu_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 31);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(133, 54);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar ";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(12, 276);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(133, 54);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Desconectar ";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(290, 137);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(176, 31);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Desconectado";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(176, 276);
            this.btnChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(188, 54);
            this.btnChat.TabIndex = 6;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnFicheiros
            // 
            this.btnFicheiros.Location = new System.Drawing.Point(387, 276);
            this.btnFicheiros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFicheiros.Name = "btnFicheiros";
            this.btnFicheiros.Size = new System.Drawing.Size(188, 54);
            this.btnFicheiros.TabIndex = 7;
            this.btnFicheiros.Text = "Ficheiros";
            this.btnFicheiros.UseVisualStyleBackColor = true;
            this.btnFicheiros.Click += new System.EventHandler(this.btnFicheiros_Click);
            // 
            // lbMensagens
            // 
            this.lbMensagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagens.Location = new System.Drawing.Point(176, 207);
            this.lbMensagens.Name = "lbMensagens";
            this.lbMensagens.Size = new System.Drawing.Size(188, 66);
            this.lbMensagens.TabIndex = 8;
            this.lbMensagens.Text = "Enviar /Receber Msgs";
            this.lbMensagens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 66);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enviar /Receber Ficheiros";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Porto";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 354);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMensagens);
            this.Controls.Add(this.btnFicheiros);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.tbPort);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnFicheiros;
        private System.Windows.Forms.Label lbMensagens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

