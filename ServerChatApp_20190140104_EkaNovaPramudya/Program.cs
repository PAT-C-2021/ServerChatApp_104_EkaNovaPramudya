using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_2019014014;

namespace ServerChatApp_20190140104_EkaNovaPramudya
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = null;
            try
            {
                serviceHost = new ServiceHost(typeof(ServiceCallBack));
                serviceHost.Open();

                Console.WriteLine("Server is READY....!");
                Console.ReadLine();

                serviceHost.Close();
            }
            catch (Exception e)
            {
                serviceHost = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
