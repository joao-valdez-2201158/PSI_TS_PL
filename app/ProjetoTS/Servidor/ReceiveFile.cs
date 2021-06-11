using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Servidor
{
    class ReceiveFile
    {
        public void ListenerThread()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, port);

            tcpListener.Start();
            while (!shutdown)
            {
                Socket handlerSocket = tcpListener.AcceptSocket();
                if (handlerSocket.Connected)
                {
                    Invoke(new MethodInvoker(delegate ()
                    {
                        listBox1.Items.Add(DateTime.Now.ToShortTimeString() + " : " + handlerSocket.RemoteEndPoint.ToString() + " Connected.");
                    }));
                    tcpListener.Stop();
                    var thdstHandler = new ParameterizedThreadStart(HandlerThread);

                    Thread thdHandler = new Thread(thdstHandler);
                    thdHandler.Start(handlerSocket);
                }
            }

        }
        public void HandlerThread(object state)
        {
            using (Socket handlerSocket = (Socket)state)
            using (NetworkStream networkStream = new NetworkStream(handlerSocket))
            {
                int thisRead = 0;
                int blockSize = 1024;
                Byte[] dataByte = new Byte[blockSize];
                var ms = new MemoryStream();

                while (true)
                {
                    thisRead = networkStream.Read(dataByte, 0, blockSize);
                    if (thisRead == 0) break;
                    ms.Write(dataByte, 0, thisRead);
                }
                //File.WriteAllBytes(filedir, ms.ToArray());
                networkStream.Close();
                handlerSocket.Close();



            }

        }
    }
}
