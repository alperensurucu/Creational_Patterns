using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multition_Design_Pattern_Example
{
    class Database
    {
        private Database()
        {
            Console.WriteLine($"{nameof(Database)} object is created. ");
        }

        //static Database _database; // bunu artık kullanmıyoruz tekil tutmayacağız diye .

        static Dictionary<string, Database> _databases = new();

        public static Database GetInstance(string key)  // sınırlı sayıda key kadar nesne oluşturuyoruz .
        {
            if (_databases.ContainsKey(key))  //database nesnesi yoksa   _databases[key] e karşı bir tane database nesnesi üret diyoruz.
            {
                _databases[key] = new Database();
            }
            return _databases[key];
        }

        public void Connection()
        {
            Console.WriteLine("Connected.");
        }
        public void Disconnection()
        {
            Console.WriteLine("Disconnected.");
        }

        public void ConnectionString(string connectionString)
        {
            //...
        }
    }
}
