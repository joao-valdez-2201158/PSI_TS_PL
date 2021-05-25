using EI.SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Servidor
{
    public class ClientHandler
    {
        // Definição das variáveis client e clientID.
        private TcpClient client;
        private int clientID;


        public ClientHandler(TcpClient client, int clientID)
        {
            this.client = client;
            this.clientID = clientID;
        }
        public void Handle()
        {
            // Definição da variável thread e arranque da mesma
            // Para relembrar: Threads são unidades de execução dentro de um processo; um conjunto de instruções.
            Thread thread = new Thread(threadHandler);
            thread.Start();
        }
        private void threadHandler()
        {
            // Definição das variáveis networkStream e protocolSI
            NetworkStream networkStream = this.client.GetStream();
            ProtocolSI protocolSI = new ProtocolSI();

            // Ciclo a ser executado até ao fim da transmissão.
            while (protocolSI.GetCmdType() != ProtocolSICmdType.EOT)
            {
                int bytesRead = networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
                byte[] ack;

                // "Alteração"/mudança entre a apresentação da mensagem e o fim da tranmissão.
                switch (protocolSI.GetCmdType())
                {
                    //Dica do ALT
                    case ProtocolSICmdType.DATA:
                        Console.WriteLine("Client " + clientID + ": " + protocolSI.GetStringFromData());
                        ack = protocolSI.Make(ProtocolSICmdType.ACK);
                        networkStream.Write(ack, 0, ack.Length);

                        string str = protocolSI.GetStringFromData();

                        ChatBot cb = new ChatBot();
                        string rt = cb.ReadText(str);
                        byte[] bt = Encoding.UTF8.GetBytes(rt);

                        networkStream.Write(bt, 0, bt.Length);
                        str = "";
                        
                     

                        break;

                    case ProtocolSICmdType.EOT:
                        Console.WriteLine("Ending Thread from Client {0}", clientID);
                        ack = protocolSI.Make(ProtocolSICmdType.ACK);
                        networkStream.Write(ack, 0, ack.Length);
                        break;
                }
            }

            // Fecho do networkStream e do cliente (TcpClient)
            networkStream.Close();
            client.Close();
        }
    }
}
