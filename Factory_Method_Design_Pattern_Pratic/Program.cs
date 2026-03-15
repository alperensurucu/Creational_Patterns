namespace Factory_Method_Design_Pattern_Pratic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        A a = new A();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
    }
    
    class A
    {

    }
    class B
    {

    }
    class C
    {

    }
}
