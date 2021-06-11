﻿using System;
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

            Mensagens mensagens = new Mensagens(this.Client);
            mensagens.Show();
        }

        private void btnFicheiros_Click(object sender, EventArgs e)
        {
           
            Ficheiros ficheiros = new Ficheiros(this.Client);
            ficheiros.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            Autenticacao autenticacao = new Autenticacao();

            while(CadastroUtilizador.utilizadorLogado == null){
                autenticacao.ShowDialog();
                Visible = false;
            }
            Visible = true;
            lbMenu.Text = "Caro(a) " + CadastroUtilizador.utilizadorLogado.Nome + " Seja Bem Vindo";
        }

      

       
    }
}