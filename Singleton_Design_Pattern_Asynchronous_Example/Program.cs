namespace Singleton_Design_Pattern_Asynchronous_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = Example.GetInstane;
            Example example1 = Example.GetInstane;
            Example example2 = Example.GetInstane;
            Example example3 = Example.GetInstane;
        }
    }

}
