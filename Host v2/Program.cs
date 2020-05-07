using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Host_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Wcf_server.Service1)))
            {
                host.Open();
                Console.WriteLine("Запупщен");
                Console.ReadLine();
            }
        }
    }
}
