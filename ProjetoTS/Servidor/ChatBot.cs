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
            if (TextBox_Text == "Que horas são?" || TextBox_Text == "horas?" || TextBox_Text == "Quais as horas?" || TextBox_Text == "que horas sao?" || TextBox_Text == "que horas são?" || TextBox_Text == "Que horas sao?" || TextBox_Text == "horas?" || TextBox_Text == "quais as horas?")
            {
                str = "As Horas são: " + DateTime.Now.ToString("HH:mm");
            }
            if (TextBox_Text == "Data?" || TextBox_Text == "data?" || TextBox_Text == "Data de hoje?" || TextBox_Text == "data de hoje?")
            {
                str = "A Data é a seguinte: " + DateTime.Now.ToString("D");
            }
            if (TextBox_Text == "Como estas?" || TextBox_Text == "como estas?" || TextBox_Text == "Como estás?" || TextBox_Text == "como estás?")
            {
                str = "Eu estou estático, entendeu? ahahah";
            }
            if (TextBox_Text == "como anda?" || TextBox_Text == "como andas?" || TextBox_Text == "Como anda?" || TextBox_Text == "Como andas?")
            {
                str = "Está me a causar inveja? Você sabe muito bem que eu não posso andar";
            }
            if (TextBox_Text == "Adeus" || TextBox_Text == "adeus" || TextBox_Text == "xau" || TextBox_Text == "tchau")
            {
                str = "Adeus, Fique bem!";
            }
            else
            {
                str = "Não entendi!";
            }
            return str;
        } 

        public string getRandomText()
        {
            return "";
        }
    }
}
