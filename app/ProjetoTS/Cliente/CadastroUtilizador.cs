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
            new Utilizador () {Nome= "Joao", Senha="2201158"},
            new Utilizador () {Nome= "Tiago", Senha="2202418"},
            new Utilizador () {Nome= "Eduardo", Senha="2202420"},
            new Utilizador () {Nome= "Nuno", Senha="professor"}
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
