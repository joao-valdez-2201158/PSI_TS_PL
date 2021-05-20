using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registrar reg = new Registrar();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = tbUtilizador.Text;
            string senha = tbPassword.Text;
            if (CadastroUtilizador.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado");
            }
            tbUtilizador.Text = "";
            tbPassword.Text = "";
            tbUtilizador.Focus();
                Close();
        }

        private void tbUtilizador_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
