using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TCPChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            

            TcpClient clientSocket = new TcpClient("localhost", 6789);
            Console.WriteLine("Clint started");
            Stream ns = clientSocket.GetStream();
            

            while (true)
            {
                StreamReader sr = new StreamReader(ns);
                string message = sr.ReadLine();
                Console.WriteLine("clit " + message);


                StreamWriter sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                string memessage = Console.ReadLine();
                sw.WriteLine(memessage);

                string s = Console.ReadLine();
                if (s == "end")
                {
                    sr.Close();
                    sw.Close();
                    ns.Close();
                }

            }

           

        }
    }
}
