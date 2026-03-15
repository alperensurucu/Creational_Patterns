namespace Factory_METOD_Design_Metod
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
                        A? a = ProductCreator.GetInstance(ProductType.A) as A;
                        a.Run();

                        B? b = ProductCreator.GetInstance(ProductType.B) as B;
                        b.Run();
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }
                }
            }
        }
    }
    interface IProduct  
    {
        void Run();
    }
    class A : IProduct
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
    class B : IProduct
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
    class C : IProduct
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
    enum ProductType
    {
        A, B, C
    }
    class ProductCreator  
    {
        public static IProduct GetInstance(ProductType productType)  
        {
            IProduct _product = null;

            switch (productType)
            {
                case ProductType.A:
                    _product = new A();
                    break;
                case ProductType.B:
                    _product = new B();
                    break;
                case ProductType.C:
                    _product = new C();
                    break;
            }
            return _product;
        }
    }
}
