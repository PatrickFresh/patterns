using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current time: {DateTime.Now}, {Singleton.Instance.Show()}");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Current time: {DateTime.Now}, {Singleton.Instance.Show()}");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine($"Current time: {DateTime.Now}, {Singleton.Instance.Show()}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
