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

namespace Cliente
{
    public partial class CriptoMSG : Form
    { 
        public Criptografia criptografia { get; set; }

        private  byte[] key; // Chave
        private  byte[] iv; // Vetor de inicialização

        /*Algoritmo simétrico:
			Aplica encriptação e desencriptação simétrica
			usando implementação
			Cryptographic Application Programming Interfaces (CAPI)
			do algoritmo Advanced Encryption Standard (AES).*/
        public AesCryptoServiceProvider aesCrypt { get; set; }

        public CriptoMSG()
        {
            InitializeComponent();
        }
        private string GerarChavePrivada(string pass)
        {

            byte[] salt = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(pass, salt, 1000);

            //GERAR KEY
            byte[] key = pwdGen.GetBytes(16);

            //CONVERTER A PASS PARA BASE64. A BASE64 é um método 
            //para codificação de informação e consequente transferência de dados pela Internet
            string passB64 = Convert.ToBase64String(key);

            return passB64;
        }
        private string GerarIV(string pass)
        {
            byte[] salt = new byte[] { 7, 6, 5, 4, 3, 2, 1, 0 };


            Rfc2898DeriveBytes pwdGen = new Rfc2898DeriveBytes(pass, salt, 1000);

            //GERAR IV
            byte[] iv = pwdGen.GetBytes(16);

            string ivB64 = Convert.ToBase64String(iv);

            return ivB64;
        }
        private string CifrarTexto(string txt)
        {
            //VARIÁVEL PARA GUARDAR O TEXTO DECIFRADO EM BYTES
            byte[] txtDecifrado = Encoding.UTF8.GetBytes(txt);
            //VARIÁVEL PARA GUARDAR O TEXTO CIFRADO EM BYTES
            byte[] txtCifrado;
            //RESERVAR ESPAÇO NA MEMÓRIA PARA COLOCAR O TEXTO E CIFRÁ-LO
            MemoryStream ms = new MemoryStream();
            //INICIALIZAR O SISTEMA DE CIFRAGEM (WRITE)
            CryptoStream cs = new CryptoStream(ms, aesCrypt.CreateEncryptor(), CryptoStreamMode.Write);
            //CRIFRAR OS DADOS
            cs.Write(txtDecifrado, 0, txtDecifrado.Length);
            cs.Close();
            //GUARDAR OS DADOS CRIFRADO QUE ESTÃO NA MEMÓRIA
            txtCifrado = ms.ToArray();
            //CONVERTER OS BYTES PARA BASE64 (TEXTO)
            string txtCifradoB64 = Convert.ToBase64String(txtCifrado);
            //DEVOLVER OS BYTES CRIADOS EM BASE64
            return txtCifradoB64;
        }
        private string DecifrarTexto(string txtCifradoB64)
        {
            //VARIÁVEL PARA GUARDAR O TEXTO CIFRADO EM BYTES
            byte[] txtCifrado = Convert.FromBase64String(txtCifradoB64);
            //RESERVAR ESPAÇO NA MEMÓRIA PARA COLOCAR O TEXTO E CIFRÁ-LO
            MemoryStream ms = new MemoryStream(txtCifrado);
            //INICIALIZAR O SISTEMA DE CIFRAGEM (READ)
            CryptoStream cs = new CryptoStream(ms, aesCrypt.CreateDecryptor(), CryptoStreamMode.Read);

            //VARIÁVEL PARA GUARDO O TEXTO DECIFRADO
            byte[] txtDecifrado = new byte[ms.Length];
            //VARIÁVEL PARA TER O NÚMERO DE BYTES DECIFRADOS
            int bytesLidos = 0;
            //DECIFRAR OS DADOS
            bytesLidos = cs.Read(txtDecifrado, 0, txtDecifrado.Length);
            cs.Close();
            //CONVERTER PARA TEXTO
            string textoDecifrado = Encoding.UTF8.GetString(txtDecifrado, 0, bytesLidos);
            //DEVOLVER TEXTO DECRIFRADO
            return textoDecifrado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            aesCrypt = new AesCryptoServiceProvider();
            criptografia = new Criptografia();

            //INICIALIZAR SERVIÇO DE CIFRAGEM AES
            aesCrypt = new AesCryptoServiceProvider();

            //GUARDAR A CHAVE GERADA
            key = aesCrypt.Key;

            //GUARDAR O VETOR DE INICIALIZAÇÃO GERADO
            iv = aesCrypt.IV;
            tb_chave.Text = GerarChavePrivada(tb_SegredoPartilhado.Text);
            tb_vi.Text = GerarIV(tb_SegredoPartilhado.Text);
        }

        private void bt_Cifrar_Click(object sender, EventArgs e)
        {
            //IR BUSCAR CHAVE E IV
            string keyB64 = tb_chave.Text;
            string ivB64 = tb_vi.Text;

            //CONVERTER DE BASE64 PARA BYTES E SUBSTITUIR NO AES
            aesCrypt.Key = Convert.FromBase64String(keyB64);
            aesCrypt.IV = Convert.FromBase64String(ivB64);

            //IR BUSCAR O TEXTO DA TEXTBOX TextoACifrar
            string textoACifrar = tb_TextoACifrar.Text;

            //CHAMAR A FUNÇÃO CifrarTexto E ENVIAR O TEXTO GUARDADO ANTES E GUARDÁ-LO NA VARÍAVEL TEXTOCIFRADO
            string textoCifrado = CifrarTexto(textoACifrar);

            //COLOCAR O TEXTO CIFRADO NA TEXTBOX TextoCifrado
            tb_TextoCifrado.Text = textoCifrado;
        }

        private void bt_Decifrar_Click(object sender, EventArgs e)
        {
        
            //IR BUSCAR CHAVE E IV
            string keyB64 = tb_chave.Text;
            string ivB64 = tb_vi.Text;

            //CONVERTER DE BASE64 PARA BYTES E SUBSTITUIR NO AES
            aesCrypt.Key = Convert.FromBase64String(keyB64);
            aesCrypt.IV = Convert.FromBase64String(ivB64);

            //IR BUSCAR O TEXTO DA TEXTBOX TextoCifrado (BASE64)
            string textoCifrado = tb_TextoCifrado.Text;

            //CHAMAR A FUNÇÃO CifrarTexto E ENVIAR O TEXTO GUARDADO ANTES E GUARDÁ-LO NA VARÍAVEL TEXTOCIFRADO
            string textoDecifrado = DecifrarTexto(textoCifrado);

            //COLOCAR O TEXTO CIFRADO NA TEXTBOX TextoCifrado
            tb_TextoDecifrado.Text = textoDecifrado;
        }

        private void CriptoMSG_Load(object sender, EventArgs e)
        {

        }
    }



   

    
}
