using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            Console.ReadLine();
        }

        class CustomerManager
        {
            public ILogger Logger { get; set; }
            public void Add()
            {
               Logger.log();
                Console.WriteLine("Customer Added!");
            }
        }

        class DatabaseLogger : ILogger
        {
         

            public void log()
            {
                Console.WriteLine("Logged To Database");
            }
        }

        class FileLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged To File");
            }
        }

        class SmsLogger : ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged To Sms");
            }
        }

        interface ILogger
        {
            void log();
        }
    }
}
