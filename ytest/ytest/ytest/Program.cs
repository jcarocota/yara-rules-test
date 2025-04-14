using System.Diagnostics;
using System.Net.Sockets;

namespace ytest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de prueba para yara");

            /*
            List<string> triggerStrings = new List<string>()
            {
                "ws2_32.dll", 
                "System.Net",
                "wsock32.dll",
                "WSAStartup",
                "sendto",
                "recvfrom",
                "WSASendTo",
                "WSARecvFrom",
                "UdpClient"
            };

            //triggerStrings.ForEach(x => Console.WriteLine(x));

            foreach(String s in triggerStrings)
            {
                Console.WriteLine("\t - "  + s);
            }

            var processes = Process.GetProcessesByName("ytest");

            foreach (var process in processes)
            {
                Console.WriteLine($"ytest process found with ID: {process.Id}");
            }*/
            Console.WriteLine("Iniciando lectura...");
            try
            {
                var triggerFile = File.ReadAllLines("ytest.txt");
                var triggerStrings = new List<String>(triggerFile);

                Console.WriteLine("Strings listados:");
                foreach (String s in triggerStrings)
                {
                    Console.WriteLine("\t - " + s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error de lectura del archivo");
                Console.WriteLine(ex.ToString());
                Environment.Exit(0);
            };

            var processes = Process.GetProcessesByName("ytest");

            foreach (var process in processes)
            {
                Console.WriteLine($"ytest process found with ID: {process.Id}");
            }

            Console.WriteLine("ready to yara rules testing bitches!");
            Console.WriteLine("press any key ti continue...");
            Console.ReadLine();
        }
    }

}