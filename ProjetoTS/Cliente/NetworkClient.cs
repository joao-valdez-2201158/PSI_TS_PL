using EI.SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class NetworkClient
    {
        public NetworkStream NetworkStream { get; set; }
        public ProtocolSI ProtocolSI { get; set; }
        public TcpClient Client { get; set; }

        public int Port { get; set; }

        public NetworkClient(int port)
        {
            this.Port = port;
        }

        public static TcpClient teste()
        {
            return new TcpClient();
        }

        public bool Connect()
        {
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, this.Port);
            Client = new TcpClient();
            Client.Connect(endpoint);
            NetworkStream = Client.GetStream();
            ProtocolSI = new ProtocolSI();

            return Client.Connected;
        }

        public void SendText(string msg)
        {
            byte[] packet = this.ProtocolSI.Make(ProtocolSICmdType.DATA, msg);
            NetworkStream.Write(packet, 0, packet.Length);
            while (ProtocolSI.GetCmdType() != ProtocolSICmdType.ACK)
            {
                NetworkStream.Read(ProtocolSI.Buffer, 0, ProtocolSI.Buffer.Length);
            }

        }

        public string ListeningText()
        {
            string data = "";

            int bytesreaded = NetworkStream.Read(ProtocolSI.Buffer, 0, ProtocolSI.Buffer.Length);
            if (bytesreaded > 0)
            {
                data = Encoding.UTF8.GetString(ProtocolSI.Buffer, 0, bytesreaded);
            }


            return data;
        }
       
        ////Função para fechar o Client
        public bool Close()
        {
            //try
            //{
            // Definição da variável eot (End of Transmission) do tipo array de byte.
            // Utilização do método Make. ProtocolSICmdType serve para enviar dados
            byte[] eot = ProtocolSI.Make(ProtocolSICmdType.EOT);

            // A classe NetworkStream disponibiliza métodos para enviar/receber dados através de socket Stream
            // O Socket de rede é um endpoint interno para envio e recepção de dados com um nó/computador presente na rede.
            NetworkStream.Write(eot, 0, eot.Length);
            NetworkStream.Read(ProtocolSI.Buffer, 0, ProtocolSI.Buffer.Length);
            NetworkStream.Close();
            Client.Close();

            return !this.Client.Connected;
        }

    }
}
