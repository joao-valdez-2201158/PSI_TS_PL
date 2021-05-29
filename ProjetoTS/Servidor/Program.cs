using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EI.SI;

namespace Servidor
{
    class Program
    {

        static void Main(string[] args)
        {



                int porto = 10000;
                Listening listening = new Listening(porto);
                listening.listen();
            

        }
    }
}
