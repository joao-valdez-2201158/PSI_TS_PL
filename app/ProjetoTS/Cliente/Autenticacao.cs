using System;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Autenticacao : Form
    {
        private const int SALTSIZE = 8;
        private const int NUMBER_OF_ITERATIONS = 50000;

        public Autenticacao()
        {
            InitializeComponent();
        }
     
        public bool VerifyLogin(string username, string password)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\jpval\Dropbox\PSI\2º_SEMESTRE\PROJETOS\PSI_TS_PL\app\ProjetoTS\Cliente\Database3.mdf';Integrated Security=True");
                //conn.ConnectionString = Properties.Settings.Default.connectionString;

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração do comando SQL
                String sql = "SELECT * FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;

                // Declaração dos parâmetros do comando SQL
                SqlParameter param = new SqlParameter("@username", username);

                // Introduzir valor ao parâmentro registado no comando SQL
                cmd.Parameters.Add(param);

                // Associar ligação à Base de Dados ao comando a ser executado
                cmd.Connection = conn;

                // Executar comando SQL
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    throw new Exception("Error while trying to access an user");
                }

                // Ler resultado da pesquisa
                reader.Read();

                // Obter Hash (password + salt)
                byte[] saltedPasswordHashStored = (byte[])reader["SaltedPasswordHash"];

                // Obter salt
                byte[] saltStored = (byte[])reader["Salt"];

                conn.Close();

                //byte[] pass = Encoding.UTF8.GetBytes(password);

                byte[] hash = GenerateSaltedHash(password, saltStored);

                return saltedPasswordHashStored.SequenceEqual(hash);
            }
            catch
            {
                MessageBox.Show("An error occurred");
                return false;
            }
        }

        private void Register(string username, byte[] saltedPasswordHash, byte[] salt)
        {
            SqlConnection conn = null;
            try
            {

                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\jpval\Dropbox\PSI\2º_SEMESTRE\PROJETOS\PSI_TS_PL\app\ProjetoTS\Cliente\Database3.mdf';Integrated Security=True");
                //conn.ConnectionString = Properties.Settings.Default.connectionString;

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração dos parâmetros do comando SQL
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassHash = new SqlParameter("@saltedPasswordHash", saltedPasswordHash);
                SqlParameter paramSalt = new SqlParameter("@salt", salt);

                // Declaração do comando SQL
                String sql = "INSERT INTO Users (Username, SaltedPasswordHash, Salt) VALUES (@username,@saltedPasswordHash,@salt)";

                // Prepara comando SQL para ser executado na Base de Dados
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Introduzir valores aos parâmentros registados no comando SQL
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassHash);
                cmd.Parameters.Add(paramSalt);

                // Executar comando SQL
                int lines = cmd.ExecuteNonQuery();

                // Fechar ligação
                conn.Close();
                if (lines == 0)
                {
                    // Se forem devolvidas 0 linhas alteradas então o não foi executado com sucesso
                    throw new Exception("Error while inserting an user");
                }
                MessageBox.Show("Registado com sucesso!");
            }
            catch (Exception e)
            {
                throw new Exception("Error while inserting an user:" + e.Message);
            }
        }

        private static byte[] GenerateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return buff;
        }

        private static byte[] GenerateSaltedHash(string plainText, byte[] salt)
        {
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(plainText, salt, NUMBER_OF_ITERATIONS);
            return rfc2898.GetBytes(32);
        }


        public bool validacao()
        {
            String password = textBoxPassword.Text;
            String username = textBoxUsername.Text;

            if (!VerifyLogin(username, password))
            {
                return false;

            }
            
                return true;

        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            String pass = textBoxPassword.Text;

            String username = textBoxUsername.Text;

            byte[] salt = GenerateSalt(SALTSIZE);

            byte[] hash = GenerateSaltedHash(pass, salt);

            Register(username, hash, salt);
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {            
            
            if(validacao())
            {

                (this.Owner as Menu_Principal).definirAutenticacao(true, this.nomeUtilizador());
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid User");
            }

        }

        private void buttonGenerateSaltedHash_Click_1(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;

            byte[] salt = GenerateSalt(SALTSIZE);
            byte[] hash = GenerateSaltedHash(password, salt);

            textBoxSaltedHash.Text = Convert.ToBase64String(hash);
            textBoxSalt.Text = Convert.ToBase64String(salt);

            textBoxSizePass.Text = (hash.Length * 8).ToString();
            textBoxSizeSalt.Text = (salt.Length * 8).ToString();
        }

        private void UtilizadorDB_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
        public string nomeUtilizador()
        {
            string nome = textBoxUsername.Text;

            return nome;
        }
       
        


        
    }

}
