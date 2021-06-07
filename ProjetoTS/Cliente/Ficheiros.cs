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
        public void SendFile()

        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                this.Port = 10000;
                string ficheiro = openDialog.FileName;
                string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                byte[] fileRead = File.ReadAllBytes(doc);
                byte[] fileBuffer = new byte[fileRead.Length];
                tcpClient = new TcpClient(IPAddress.Any.ToString(), this.Port);
                NetworkStream = tcpClient.GetStream();
                NetworkStream.Write(fileRead.ToArray(), 0, fileBuffer.GetLength(0));
                NetworkStream.Close();
            }
            
        }

        private void btnEnviarFicheiro_Click(object sender, EventArgs e)
        {
            SendFile();
        }

        private void Ficheiros_Load(object sender, EventArgs e)
        {

        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
