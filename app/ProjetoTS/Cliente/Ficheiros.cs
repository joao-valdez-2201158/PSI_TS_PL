using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EI.SI;

namespace Cliente
{
    public partial class Ficheiros : Form
    {
        public NetworkStream NetworkStream { get; set; }
        public NetworkClient Client { get; set; }
        public TcpClient tcpClient { get; set; }
        public int Port { get; set; }
        public ProtocolSI ProtocolSI { get; set; }

        public Ficheiros()
        {
            InitializeComponent();

        }
        public Ficheiros(NetworkClient Client)
        {
            this.Client = Client;
            InitializeComponent();
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
       
        
        public string escolherFicheiro()
        {

            string fileContent = string.Empty;
            string filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                }
                return filePath;
            }  
        }

        private void btnEnviarFicheiro_Click(object sender, EventArgs e)
        {
            string file = "Ficheiro recebido com exito: " + escolherFicheiro();
            byte[] file1 = Encoding.ASCII.GetBytes(file);
            if (this.Client != null)
            {
                if (this.Client.Client.Connected)
                {
                    this.Client.SendFile(file1);


                    string resposta = this.Client.ListeningText();
                    if (!string.IsNullOrEmpty(resposta))
                    {
                        tbPath.Text = "Ficheiro enviado";
                        MessageBox.Show("Ficheiro enviado com exito");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente nao Conectado!");
                }
            }
            else
            {
                MessageBox.Show("Cliente nao incializado!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ficheiros_Load(object sender, EventArgs e)
        {
          
        }

        private void btnCripto_Click(object sender, EventArgs e)
        {
            CriptoFile cripto = new CriptoFile();
            cripto.Show();
        }
    }
}
