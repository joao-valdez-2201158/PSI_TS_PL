
namespace Cliente
{
    partial class CriptoFile
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnGetPrivateKey = new System.Windows.Forms.Button();
            this.btnImportPublicKey = new System.Windows.Forms.Button();
            this.btnExportPublicKey = new System.Windows.Forms.Button();
            this.btnCreateAsmKeys = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCriptoTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(19, 197);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(447, 22);
            this.txtKey.TabIndex = 15;
            // 
            // btnGetPrivateKey
            // 
            this.btnGetPrivateKey.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPrivateKey.Location = new System.Drawing.Point(332, 328);
            this.btnGetPrivateKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetPrivateKey.Name = "btnGetPrivateKey";
            this.btnGetPrivateKey.Size = new System.Drawing.Size(134, 57);
            this.btnGetPrivateKey.TabIndex = 14;
            this.btnGetPrivateKey.Text = "Obter chave privada";
            this.btnGetPrivateKey.UseVisualStyleBackColor = true;
            this.btnGetPrivateKey.Click += new System.EventHandler(this.btnGetPrivateKey_Click);
            // 
            // btnImportPublicKey
            // 
            this.btnImportPublicKey.BackColor = System.Drawing.SystemColors.Control;
            this.btnImportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportPublicKey.Location = new System.Drawing.Point(173, 328);
            this.btnImportPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportPublicKey.Name = "btnImportPublicKey";
            this.btnImportPublicKey.Size = new System.Drawing.Size(134, 57);
            this.btnImportPublicKey.TabIndex = 13;
            this.btnImportPublicKey.Text = "Importar chave pública";
            this.btnImportPublicKey.UseVisualStyleBackColor = true;
            this.btnImportPublicKey.Click += new System.EventHandler(this.btnImportPublicKey_Click);
            // 
            // btnExportPublicKey
            // 
            this.btnExportPublicKey.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPublicKey.Location = new System.Drawing.Point(19, 331);
            this.btnExportPublicKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPublicKey.Name = "btnExportPublicKey";
            this.btnExportPublicKey.Size = new System.Drawing.Size(134, 54);
            this.btnExportPublicKey.TabIndex = 12;
            this.btnExportPublicKey.Text = "Exportar chave pública";
            this.btnExportPublicKey.UseVisualStyleBackColor = true;
            this.btnExportPublicKey.Click += new System.EventHandler(this.btnExportPublicKey_Click);
            // 
            // btnCreateAsmKeys
            // 
            this.btnCreateAsmKeys.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateAsmKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAsmKeys.Location = new System.Drawing.Point(332, 246);
            this.btnCreateAsmKeys.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAsmKeys.Name = "btnCreateAsmKeys";
            this.btnCreateAsmKeys.Size = new System.Drawing.Size(134, 53);
            this.btnCreateAsmKeys.TabIndex = 11;
            this.btnCreateAsmKeys.Text = "Criar chaves";
            this.btnCreateAsmKeys.UseVisualStyleBackColor = true;
            this.btnCreateAsmKeys.Click += new System.EventHandler(this.btnCreateAsmKeys_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnDecryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptFile.Location = new System.Drawing.Point(173, 245);
            this.btnDecryptFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(134, 54);
            this.btnDecryptFile.TabIndex = 10;
            this.btnDecryptFile.Text = "Descriptografar arquivo";
            this.btnDecryptFile.UseVisualStyleBackColor = true;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnEncryptFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptFile.Location = new System.Drawing.Point(19, 244);
            this.btnEncryptFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(134, 53);
            this.btnEncryptFile.TabIndex = 9;
            this.btnEncryptFile.Text = "Criptografar arquivo";
            this.btnEncryptFile.UseVisualStyleBackColor = true;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Chave ainda não definida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCriptoTittle
            // 
            this.lbCriptoTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCriptoTittle.Location = new System.Drawing.Point(21, 37);
            this.lbCriptoTittle.Name = "lbCriptoTittle";
            this.lbCriptoTittle.Size = new System.Drawing.Size(445, 51);
            this.lbCriptoTittle.TabIndex = 16;
            this.lbCriptoTittle.Text = "Criptografia";
            this.lbCriptoTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CriptoFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 440);
            this.Controls.Add(this.lbCriptoTittle);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnGetPrivateKey);
            this.Controls.Add(this.btnImportPublicKey);
            this.Controls.Add(this.btnExportPublicKey);
            this.Controls.Add(this.btnCreateAsmKeys);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.label1);
            this.Name = "CriptoFile";
            this.Text = "Cripto";
            this.Load += new System.EventHandler(this.CriptoFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnGetPrivateKey;
        private System.Windows.Forms.Button btnImportPublicKey;
        private System.Windows.Forms.Button btnExportPublicKey;
        private System.Windows.Forms.Button btnCreateAsmKeys;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCriptoTittle;
    }
}