using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TCP_IP
{
    public class TCPClass
    {
        public string Status;
        public Thread T;
        private const string IP = "127.0.0.1";
        private const int Port = 29250;
        private const int BufferSize = 1024;

        public void StartReceiving()
        {
            ReceiveTCP(Port);
        }

        public void StartClient()
        {
            try
            {
                IPAddress ipAd = IPAddress.Parse(IP);
                Console.ForegroundColor = ConsoleColor.Cyan;
                TcpClient tcpclnt = new TcpClient();
                Console.WriteLine("Buscant planeta...");

                tcpclnt.Connect(IP, 29250);

                Console.WriteLine("Conectat amb el planeta");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Escriu el missatge que vulgui enviar al planeta: ");

                String str = Console.ReadLine();
                Stream stm = tcpclnt.GetStream();
                Console.ForegroundColor = ConsoleColor.Cyan;
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                Console.WriteLine("Missatge enviat");

                stm.Write(ba, 0, ba.Length);

                byte[] lletres = new byte[100];
                int x = stm.Read(lletres, 0, 100);

                for (int i = 0; i < x; i++)
                    Console.Write(Convert.ToChar(lletres[i]));

                Console.Read();
                tcpclnt.Close();
            }

            catch (Exception)
            {
                Console.WriteLine("No s'ha pogut establir connexió amb el planeta sel·leccionat");
                Console.Read();
            }
        }

        public void StartServer()
        {
            ThreadStart Ts = new ThreadStart(StartReceiving);

            T = new Thread(Ts);
            //T.SetApartmentState(ApartmentState.STA);
            T.Start();
        }

        public void ReceiveTCP(int portN)
        {
            TcpListener Listener = null;
            TcpClient client;
            NetworkStream netstream;

            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;

            for (; ; )
            {
                try
                {
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        int totalrecbytes = 0;

                        Status = "Conectado al cliente\n";

                        RecBytes = netstream.Read(RecData, 0, RecData.Length);

                        Status = Encoding.ASCII.GetString(RecData, 0, RecBytes);
                        totalrecbytes += RecBytes;
                        netstream.Close();
                        client.Close();
                        T.Abort();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
