using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EI.SI;

namespace Cliente
{
    public partial class Ficheiros : Form
    {
        public NetworkClient Client { get; set; }

        public Ficheiros()
        {
            InitializeComponent();

        }
        public Ficheiros(NetworkClient Client)
        {
            this.Client = Client;
            InitializeComponent();
        }

        private void btnEscolherFicheiro_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    MessageBox.Show(filePath, "caminho ficheiro");

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }
        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(tbPath.Text))
                {
                    Directory.CreateDirectory(tbPath.Text);
                    MessageBox.Show("Diretorio Criado");
                }
                else
                {
                    MessageBox.Show("Diretorio nao criado");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Diretorio nao criado" + ex.Message);
            }
            tbPath.Focus();

        }

        private void btnEliminarPasta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(tbPath.Text))
                {
                    Directory.Delete(tbPath.Text);
                    MessageBox.Show("Diretorio Excluido");
                }
                else
                {
                    MessageBox.Show("Diretorio nao existe");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Diretorio nao excluido" + ex.Message);


            }
            tbPath.Focus();

        }

        private void btnCriarFicheiro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(tbPath.Text))
                {
                    File.Create(tbPath.Text);
                    MessageBox.Show("Ficheiro Criado");

                }
                else
                {
                    MessageBox.Show("Ficheiro ja existe!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ficheiro nao criado" + ex.Message);
            }
            tbPath.Focus();

        }

        private void btnEliminarFicheiro_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(tbPath.Text))
                {
                    File.Delete(tbPath.Text);
                    MessageBox.Show("Ficheiro Excluido");
                }
                else
                {
                    MessageBox.Show("Ficheiro nao existe");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Arquivo nao excluido" + ex.Message);
            }
            tbPath.Focus();
        }

        private void btnEnviarFicheiro_Click(object sender, EventArgs e)
        {
            String path = tbPath.Text;
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void Ficheiros_Load(object sender, EventArgs e)
        {

        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
