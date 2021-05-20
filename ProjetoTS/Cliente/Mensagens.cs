using EI.SI;
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

namespace Cliente
{
    public partial class Mensagens : Form
    {
        NetworkClient Client { get; set; } // variavel da classe network client. comparavel com structs em c


        public Mensagens()
        {
            InitializeComponent();
           
        }

        public Mensagens(NetworkClient Client)
        {
            this.Client = Client;
            InitializeComponent();

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (this.Client != null)
            {
                if (this.Client.Client.Connected)
                {
                    this.Client.SendText(tbChat.Text);

                    tb2Chat.Text += "Me: " + tbChat.Text + Environment.NewLine;
                    tbChat.Text = string.Empty;

                    string resposta = this.Client.ListeningText();
                    if (!string.IsNullOrEmpty(resposta))
                    {
                        tb2Chat.Text += "BOT: " + resposta + Environment.NewLine;
                    }
                } else
                {
                    MessageBox.Show("Cliente nao Conectado!");
                }
            } else
            {
                MessageBox.Show("Cliente nao incializado!");
            }
        }

        private void Mensagens_Load(object sender, EventArgs e)
        {

        }

        private void lbChat_Click(object sender, EventArgs e)
        {

        }
    }
}
