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
    public partial class Chat : Form
    {
        NetworkClient Client { get; set; }

        public Chat()
        {
            InitializeComponent();
        }

        public Chat(NetworkClient Client)
        {
            InitializeComponent();
            this.Client = Client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensagens msg = new Mensagens(this.Client);
            msg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CriptoMSG cripto = new CriptoMSG();
            cripto.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
