namespace Singleton_Design_Pattern_CSharp_AspNetCore_Example.Services
{
    public class DatabaseService
    {
        private DatabaseService()
        {
                Console.WriteLine($"{nameof(DatabaseService)} is created.");
        }

        static DatabaseService _databaseService;

        public static DatabaseService GetInstance
        {
            get
            {
                if (_databaseService == null)
                
                    _databaseService = new DatabaseService();
                
                return _databaseService;
            }
        }
        public int Conut { get; set; }
        public bool Connected()
        {
            Conut++;
            Console.WriteLine("Baülantı sağlandı");
            return true;
        }
        public bool DisConnected()
        {
            Console.WriteLine("Bağlantı Koparıldı");
            return true;
        }
    }
}
