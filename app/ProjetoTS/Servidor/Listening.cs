using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
   public class Listening
    {
        public int Port { get; set;}

        public Listening(int port)
        {
            this.Port = port;
        }

        public void listen()
        {
            // Definição das variáveis na função principal.
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, this.Port);
            TcpListener listener = new TcpListener(endpoint);

            // Iniciar o listener; apresentação da primeira mensagem na linha de comandos e inicialização do contador.
            listener.Start();
            Console.WriteLine("SERVER READY");
            int clientCounter = 0;

            //Criação do cliclo infinito de forma a que este esteja sempre em execução até ordem em contrário
            while (true)
            {
                // Definição da variável client do tipo TcpClient
                TcpClient client = listener.AcceptTcpClient();

                // Incrementação do contador, de forma a que vá sempre somando 1 (+1)
                clientCounter++;

                // Apresentação da mensagem indicative do nº do client na linha de comandos 
                Console.WriteLine("Client {0} connected", clientCounter);

                // Definição da variável clientHandler do tipo TcpClient
                ClientHandler clientHandler = new ClientHandler(client, clientCounter);
                clientHandler.Handle();
            }

        }

    }


}
                         
       


