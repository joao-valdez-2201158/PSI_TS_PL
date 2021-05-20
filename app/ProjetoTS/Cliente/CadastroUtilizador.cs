using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    static class CadastroUtilizador //classes estaticas nao podemos fazer objetos delas. não há necessidade de serem inicial.
    {
        private static Utilizador[] utilizadores = //array de classes inicializadas do tipo Utilizador
        {
            new Utilizador () {Nome= "Joao", Senha="000"},
            new Utilizador () {Nome= "Tiago", Senha="100"},
            new Utilizador () {Nome= "Eduardo", Senha="200"}
        };

        private static Utilizador userLogado = null; //nao precisamos saber qual o utilizador logado dai ser privado


        public static  Utilizador utilizadorLogado //propriedade utilizador logado. 
        {
            get { return userLogado; }
            private set { userLogado = value; } 
        }

        public static bool Login(string nome, string senha)
        {
           foreach(Utilizador utilizador in utilizadores)
            {
                if(utilizador.Nome == nome && utilizador.Senha == senha)
                {
                    utilizadorLogado = utilizador;
                    return true;
                }
            }
            return false;
        }
    }
}
