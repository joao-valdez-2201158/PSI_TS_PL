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
            this.ChatMessages = new List<string>();

            if (DateTime.Now.Hour <= 12)
            {
                this.ChatMessages.Add("Bom dia são: " + DateTime.Now.Hour + " Horas e " + DateTime.Now.Minute +  " Minutos");
            }
            if (DateTime.Now.Hour >= 12)
            {
                this.ChatMessages.Add("Boa tarde são: " + DateTime.Now.Hour + " Horas e " + DateTime.Now.Minute + " Minutos");
            }
            if (DateTime.Now.Hour >= 20)
            { 
                this.ChatMessages.Add("Boa noite são: " + DateTime.Now.Hour + " Horas e " + DateTime.Now.Minute +  " Minutos");
            }


        }

        public string getRandomText()
        {
            Random r = new Random();
            int indice = r.Next(this.ChatMessages.Count);
            return this.ChatMessages[indice];

        }
    }
}
