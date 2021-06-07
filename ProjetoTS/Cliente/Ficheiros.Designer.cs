
namespace Cliente
{
    partial class Ficheiros
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
            this.btnEnviarFicheiro = new System.Windows.Forms.Button();
            this.btnEscolherFicheiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCriarFicheiro = new System.Windows.Forms.Button();
            this.btnEliminarPasta = new System.Windows.Forms.Button();
            this.btnCriarPasta = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnEliminarFicheiro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviarFicheiro
            // 
            this.btnEnviarFicheiro.Location = new System.Drawing.Point(396, 296);
            this.btnEnviarFicheiro.Name = "btnEnviarFicheiro";
            this.btnEnviarFicheiro.Size = new System.Drawing.Size(134, 54);
            this.btnEnviarFicheiro.TabIndex = 6;
            this.btnEnviarFicheiro.Text = "Enviar Ficheiro";
            this.btnEnviarFicheiro.UseVisualStyleBackColor = true;
            this.btnEnviarFicheiro.Click += new System.EventHandler(this.btnEnviarFicheiro_Click);
            // 
            // btnEscolherFicheiro
            // 
            this.btnEscolherFicheiro.Location = new System.Drawing.Point(396, 205);
            this.btnEscolherFicheiro.Name = "btnEscolherFicheiro";
            this.btnEscolherFicheiro.Size = new System.Drawing.Size(134, 54);
            this.btnEscolherFicheiro.TabIndex = 7;
            this.btnEscolherFicheiro.Text = "Escolher Ficheiro";
            this.btnEscolherFicheiro.UseVisualStyleBackColor = true;
            this.btnEscolherFicheiro.Click += new System.EventHandler(this.btnEscolherFicheiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ficheiros";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(514, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCriarFicheiro
            // 
            this.btnCriarFicheiro.Location = new System.Drawing.Point(83, 296);
            this.btnCriarFicheiro.Name = "btnCriarFicheiro";
            this.btnCriarFicheiro.Size = new System.Drawing.Size(134, 54);
            this.btnCriarFicheiro.TabIndex = 10;
            this.btnCriarFicheiro.Text = "Criar Ficheiro";
            this.btnCriarFicheiro.UseVisualStyleBackColor = true;
            this.btnCriarFicheiro.Click += new System.EventHandler(this.btnCriarFicheiro_Click);
            // 
            // btnEliminarPasta
            // 
            this.btnEliminarPasta.Location = new System.Drawing.Point(246, 205);
            this.btnEliminarPasta.Name = "btnEliminarPasta";
            this.btnEliminarPasta.Size = new System.Drawing.Size(134, 54);
            this.btnEliminarPasta.TabIndex = 11;
            this.btnEliminarPasta.Text = "Eliminar Pasta";
            this.btnEliminarPasta.UseVisualStyleBackColor = true;
            this.btnEliminarPasta.Click += new System.EventHandler(this.btnEliminarPasta_Click);
            // 
            // btnCriarPasta
            // 
            this.btnCriarPasta.Location = new System.Drawing.Point(83, 205);
            this.btnCriarPasta.Name = "btnCriarPasta";
            this.btnCriarPasta.Size = new System.Drawing.Size(134, 54);
            this.btnCriarPasta.TabIndex = 12;
            this.btnCriarPasta.Text = "Criar Pasta";
            this.btnCriarPasta.UseVisualStyleBackColor = true;
            this.btnCriarPasta.Click += new System.EventHandler(this.btnCriarPasta_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(83, 130);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(447, 22);
            this.tbPath.TabIndex = 13;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // btnEliminarFicheiro
            // 
            this.btnEliminarFicheiro.Location = new System.Drawing.Point(246, 296);
            this.btnEliminarFicheiro.Name = "btnEliminarFicheiro";
            this.btnEliminarFicheiro.Size = new System.Drawing.Size(134, 54);
            this.btnEliminarFicheiro.TabIndex = 14;
            this.btnEliminarFicheiro.Text = "Eliminar Arquivo";
            this.btnEliminarFicheiro.UseVisualStyleBackColor = true;
            this.btnEliminarFicheiro.Click += new System.EventHandler(this.btnEliminarFicheiro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 21;
            // 
            // Ficheiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarFicheiro);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnCriarPasta);
            this.Controls.Add(this.btnEliminarPasta);
            this.Controls.Add(this.btnCriarFicheiro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscolherFicheiro);
            this.Controls.Add(this.btnEnviarFicheiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ficheiros";
            this.Text = "Ficheiros";
            this.Load += new System.EventHandler(this.Ficheiros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviarFicheiro;
        private System.Windows.Forms.Button btnEscolherFicheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCriarFicheiro;
        private System.Windows.Forms.Button btnEliminarPasta;
        private System.Windows.Forms.Button btnCriarPasta;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnEliminarFicheiro;
        private System.Windows.Forms.Label label2;
    }
}