
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
            this.lbMenu = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnFicheiros = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMenu
            // 
            this.lbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbMenu.Location = new System.Drawing.Point(12, 9);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(690, 89);
            this.lbMenu.TabIndex = 1;
            this.lbMenu.Text = "Menu Principal";
            this.lbMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMenu.Click += new System.EventHandler(this.lbMenu_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(20, 31);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(179, 54);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar ";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(20, 110);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(179, 54);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Desconectar ";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(256, 204);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(179, 54);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Desconectado";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(7, 31);
            this.btnChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(179, 54);
            this.btnChat.TabIndex = 6;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnFicheiros
            // 
            this.btnFicheiros.Location = new System.Drawing.Point(7, 18);
            this.btnFicheiros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFicheiros.Name = "btnFicheiros";
            this.btnFicheiros.Size = new System.Drawing.Size(179, 54);
            this.btnFicheiros.TabIndex = 7;
            this.btnFicheiros.Text = "Ficheiros";
            this.btnFicheiros.UseVisualStyleBackColor = true;
            this.btnFicheiros.Click += new System.EventHandler(this.btnFicheiros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChat);
            this.groupBox1.Location = new System.Drawing.Point(457, 174);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(220, 85);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar/Receber Mensagens";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFicheiros);
            this.groupBox2.Location = new System.Drawing.Point(457, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(220, 85);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enviar/Receber Ficheiros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConectar);
            this.groupBox3.Controls.Add(this.btnDesconectar);
            this.groupBox3.Location = new System.Drawing.Point(34, 174);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(215, 177);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conexão ao servidor";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 386);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnFicheiros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

