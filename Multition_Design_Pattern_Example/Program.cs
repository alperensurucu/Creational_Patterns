namespace Multition_Design_Pattern_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mssql = Database.GetInstance("MSSQL");
            mssql.ConnectionString("sdfsfdsgfsdasdasdasdasdasdsadas");
            mssql.Connection();
            var oracle = Database.GetInstance("Oracle");
            var mongoDB = Database.GetInstance("MongoDB");
        }
    }
}
