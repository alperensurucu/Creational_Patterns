namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Example();
            new Example();
            new Example();
            new Example();
            new Example();
            new Example();
            new Example();
            new Example();
            new Example();
        }
    }

    class Example
    {
        public Example()
        {
                Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu");
        }
    }
}
