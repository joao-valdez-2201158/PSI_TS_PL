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

            Console.WriteLine("Introduzir porto: ");

            string portoIntroduzido = Console.ReadLine();

            int porto = 10000;

            if(int.TryParse(portoIntroduzido, out porto))
            { /*///faz a conversao de um numero em formato 
              string para um inteiro equivalente///*/
                Listening listening = new Listening(porto);
                listening.listen();
            } else
            {
                Console.WriteLine("Porto invalido");
            }

        }
    }
}
