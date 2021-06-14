
namespace Cliente
{
    partial class CriptoMSG
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
            this.tb_TextoDecifrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Decifrar = new System.Windows.Forms.Button();
            this.tb_TextoCifrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Cifrar = new System.Windows.Forms.Button();
            this.tb_TextoACifrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_vi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_chave = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_SegredoPartilhado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_TextoDecifrado
            // 
            this.tb_TextoDecifrado.Location = new System.Drawing.Point(40, 512);
            this.tb_TextoDecifrado.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TextoDecifrado.Multiline = true;
            this.tb_TextoDecifrado.Name = "tb_TextoDecifrado";
            this.tb_TextoDecifrado.ReadOnly = true;
            this.tb_TextoDecifrado.Size = new System.Drawing.Size(403, 65);
            this.tb_TextoDecifrado.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Texto decifrado:";
            // 
            // bt_Decifrar
            // 
            this.bt_Decifrar.Location = new System.Drawing.Point(494, 512);
            this.bt_Decifrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Decifrar.Name = "bt_Decifrar";
            this.bt_Decifrar.Size = new System.Drawing.Size(185, 65);
            this.bt_Decifrar.TabIndex = 27;
            this.bt_Decifrar.Text = "DECIFRAR";
            this.bt_Decifrar.UseVisualStyleBackColor = true;
            this.bt_Decifrar.Click += new System.EventHandler(this.bt_Decifrar_Click);
            // 
            // tb_TextoCifrado
            // 
            this.tb_TextoCifrado.Location = new System.Drawing.Point(40, 397);
            this.tb_TextoCifrado.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TextoCifrado.Multiline = true;
            this.tb_TextoCifrado.Name = "tb_TextoCifrado";
            this.tb_TextoCifrado.ReadOnly = true;
            this.tb_TextoCifrado.Size = new System.Drawing.Size(402, 65);
            this.tb_TextoCifrado.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 372);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Texto cifrado:";
            // 
            // bt_Cifrar
            // 
            this.bt_Cifrar.Location = new System.Drawing.Point(494, 335);
            this.bt_Cifrar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Cifrar.Name = "bt_Cifrar";
            this.bt_Cifrar.Size = new System.Drawing.Size(185, 65);
            this.bt_Cifrar.TabIndex = 24;
            this.bt_Cifrar.Text = "CIFRAR";
            this.bt_Cifrar.UseVisualStyleBackColor = true;
            this.bt_Cifrar.Click += new System.EventHandler(this.bt_Cifrar_Click);
            // 
            // tb_TextoACifrar
            // 
            this.tb_TextoACifrar.Location = new System.Drawing.Point(40, 326);
            this.tb_TextoACifrar.Margin = new System.Windows.Forms.Padding(2);
            this.tb_TextoACifrar.Name = "tb_TextoACifrar";
            this.tb_TextoACifrar.Size = new System.Drawing.Size(402, 22);
            this.tb_TextoACifrar.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Texto a cifrar:";
            // 
            // tb_vi
            // 
            this.tb_vi.Location = new System.Drawing.Point(40, 244);
            this.tb_vi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_vi.Name = "tb_vi";
            this.tb_vi.ReadOnly = true;
            this.tb_vi.Size = new System.Drawing.Size(401, 22);
            this.tb_vi.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Vetor inicialização:";
            // 
            // tb_chave
            // 
            this.tb_chave.Location = new System.Drawing.Point(40, 172);
            this.tb_chave.Margin = new System.Windows.Forms.Padding(2);
            this.tb_chave.Name = "tb_chave";
            this.tb_chave.ReadOnly = true;
            this.tb_chave.Size = new System.Drawing.Size(401, 22);
            this.tb_chave.TabIndex = 19;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.Location = new System.Drawing.Point(37, 133);
            this.aaa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(114, 17);
            this.aaa.TabIndex = 18;
            this.aaa.Text = "Chave Simétrica:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 70);
            this.button1.TabIndex = 17;
            this.button1.Text = "GERAR CHAVE SIMÉTRICA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_SegredoPartilhado
            // 
            this.tb_SegredoPartilhado.Location = new System.Drawing.Point(40, 86);
            this.tb_SegredoPartilhado.Margin = new System.Windows.Forms.Padding(2);
            this.tb_SegredoPartilhado.Name = "tb_SegredoPartilhado";
            this.tb_SegredoPartilhado.Size = new System.Drawing.Size(401, 22);
            this.tb_SegredoPartilhado.TabIndex = 16;
            // 
            // CriptoMSG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 658);
            this.Controls.Add(this.tb_TextoDecifrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Decifrar);
            this.Controls.Add(this.tb_TextoCifrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Cifrar);
            this.Controls.Add(this.tb_TextoACifrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_vi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_chave);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_SegredoPartilhado);
            this.Name = "CriptoMSG";
            this.Text = "CriptoMSG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_TextoDecifrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Decifrar;
        private System.Windows.Forms.TextBox tb_TextoCifrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Cifrar;
        private System.Windows.Forms.TextBox tb_TextoACifrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_vi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_chave;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_SegredoPartilhado;
    }
}