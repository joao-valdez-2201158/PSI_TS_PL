using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{

    public class ChatBot
    {

        public List<string> ChatMessages { get; set; }



        public ChatBot()
        {
            
        }

        public string ReadText(string TextBox_Text)
        {

            string str = "";
            if (TextBox_Text == "que horas são?" ||TextBox_Text == "que horas sao?" || TextBox_Text == "que horas sao" || TextBox_Text == "que horas são" || TextBox_Text == "horas?" || TextBox_Text == "horas" || TextBox_Text == "hora" || TextBox_Text == "hora?" || TextBox_Text == "diz as horas" || TextBox_Text == "diz-me as horas" || TextBox_Text == "quais as horas?")
            {
                //str = "As Horas são: " + DateTime.Now.ToString("HH:mm");

                string str1 = "As Horas são: " + DateTime.Now.ToString("HH:mm");

                string str2 = "São: " + DateTime.Now.ToString("HH:mm");

                string str3 = "Neste momento são: " + DateTime.Now.ToString("HH:mm");

                string str4 = "Aqui tens: " + DateTime.Now.ToString("HH:mm");

                str = getRandomText(str1, str2, str3, str4);
            }
            else if (TextBox_Text == "ola" || TextBox_Text == "oi" || TextBox_Text == "boas" || TextBox_Text == "olá")
            {

                string str1 = "Olá :D";

                string str2 = "Olá, bem vindo!";

                string str3 = "Saudações!";

                string str4 = "Bem vindo!";

                str = getRandomText(str1, str2, str3, str4);
            }
            else if (TextBox_Text == "data?" || TextBox_Text == "data" || TextBox_Text == "data de hoje?" || TextBox_Text == "qual a data de hoje?" || TextBox_Text == "qual a data" || TextBox_Text == "que dia é hoje?")
            {
                //str = "A Data é a seguinte: " + DateTime.Now.ToString("D");

                string str1 = "A Data é a seguinte: " + DateTime.Now.ToString("D");

                string str2 = "Hoje é: " + DateTime.Now.ToString("D");

                string str3 = "A Data de hoje é: " + DateTime.Now.ToString("D");

                string str4 = "Aqui tens: " + DateTime.Now.ToString("D");

                str = getRandomText(str1, str2, str3, str4);
            }
            else if (TextBox_Text == "como estas?" || TextBox_Text == "como estás?" || TextBox_Text == "como estas" || TextBox_Text == "como estás")
            {
                //str = "Eu estou estático, entendeste? ahahah";

                string str1 = "Eu estou estático, entendeste? ahahah";

                string str2 = "Na verdade como eu sou um bot não tenho nenhum estado, estás a ler uma mensagem pre-escrita";

                string str3 = "Eu estou operacional! Obrigado por perguntar";

                string str4 = "Eu estou operacional! Obrigado por perguntar";

                str = getRandomText(str1, str2, str3, str4);
            }
            else if (TextBox_Text == "como anda?" || TextBox_Text == "como andas?" || TextBox_Text == "como anda" || TextBox_Text == "como andas")
            {
                str = "Estás me a causar inveja? Tu sabes muito bem que eu não posso andar";
            }
            else if (TextBox_Text == "obrigado" || TextBox_Text == "ok obrigado" || TextBox_Text == "muito obrigado" || TextBox_Text == "obg")
            {
                str = "De nada :)";
            }
            else if (TextBox_Text == "de nada")
            {
                str = ":)";
            }
            else if (TextBox_Text == "quem te criou?" || TextBox_Text == "quem te criou")
            {
                string str1 = "Foram o João, o Tiago e o Eduardo";

                string str2 = "Foram o Tiago, o Eduardo e o João";

                string str3 = "Foram o Eduardo, o João e o Tiago";

                string str4 = "Foi Deus";

                str = getRandomText(str1, str2, str3, str4);
            }
            else if (TextBox_Text == "fica bem" || TextBox_Text == "adeus" || TextBox_Text == "xau" || TextBox_Text == "tchau")
            {
                //string[] llk = { "Adeus, fique bem!", "Xau, até à próxima!" , "Adeus, até à próxima!", "Xau, fique bem!"};

                string str1 = "Adeus, fique bem!";

                string str2 = "Xau, até à próxima!";

                string str3 = "Adeus, até à próxima!";

                string str4 = "Xau, fique bem!";

                str = getRandomText(str1, str2, str3, str4);
            }
            else
            {
                string str1 = "Desculpa, não entendi";

                string str2 = "Não percebi";

                string str3 = "Não entendi";

                string str4 = "Desculpa, não percebi";

                str = getRandomText(str1, str2, str3, str4);
            }
            return str;
        }

        public string getRandomText(string txt1, string txt2, string txt3, string txt4)
        {
            Random rnd = new Random();

            string[] BotAnswers = {txt1, txt2, txt3, txt4};

            int nAns = rnd.Next(BotAnswers.Length);

            string answer = BotAnswers[nAns];

            return answer;
        }
    }
}
