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
            this.ChatMessages.Add("Ola");
            this.ChatMessages.Add("Está tudo bem.");
            this.ChatMessages.Add("Como está o tempo?");
            this.ChatMessages.Add("Isto e um teste");
            this.ChatMessages.Add("Espero que gostes");
        }

        public string getRandomText()
        {
            Random r = new Random();
            int indice = r.Next(this.ChatMessages.Count);
            return this.ChatMessages[indice];

        }
    }
}
