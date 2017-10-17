using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static object locker = new object();
        private DateTime creationDate;
        private Singleton()
        {
            creationDate = DateTime.Now;
        }

        public static Singleton Instance
        {
            get
            {
                lock (locker)
                {
                    return instance ?? (instance = new Singleton());
                }
            }
        }

        public string Show()
        {
            return $"Singleton instance created: {creationDate.ToString()}";
        }
    }
}
