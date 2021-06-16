using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EI.SI;

namespace Cliente
{
   
    public partial class Menu_Principal : Form
    {
        NetworkClient Client { get; set; }
        private bool autenticado { get; set; }

        public Menu_Principal()
        {
            InitializeComponent();
        }

        /*
        private void btnAutenticacao_Click(object sender, EventArgs e)
        {
            Autenticacao autenticacao = new Autenticacao();
            autenticacao.Show();
        }
        */
        public string lbmenu(string user) 
        {
            lbMenu.Text = user;
            string str = lbMenu.Text;
            return str;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {


            int porto = 10000;


                this.Client = new NetworkClient(porto); //instanciado com a classe NetworkClient
                try
                {
                    if (this.Client.Connect())
                    {
                        this.lbStatus.Text = "Conectado";
                    }
                    else
                    {
                        this.lbStatus.Text = "Desconectado";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            
        

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                bool client = this.Client.Close();
                if (client)
                {
                    this.lbStatus.Text = "Desconectado";
                }
                else
                {
                    this.lbStatus.Text = "Conectado";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex);
            }
            
        }
        private void btnChat_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat(this.Client);
            chat.Show();
           
        }

        private void btnFicheiros_Click(object sender, EventArgs e)
        {
           
            Ficheiros ficheiros = new Ficheiros(this.Client);
            ficheiros.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

            if (!this.autenticado)
            {
                Autenticacao auth = new Autenticacao();
                auth.ShowDialog(this);
            }
            
            

        }
        public void definirAutenticacao(bool resultado, string nome)
        {
            this.autenticado = resultado;
            if(this.autenticado)
                lbMenu.Text = "Olá " + nome + " Seja Bem Vindo";
        }

        
        private void lbMenu_Click(object sender, EventArgs e)
        {

        }

       
    }
}
