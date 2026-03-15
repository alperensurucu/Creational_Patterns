using System.Diagnostics;

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
                        /* A a = new A();*/  // buradaki durum,nesne üretimini ihtiyaç duyulan koddan arındırmamışız,
                                             // 
                        A? a = ProductCreator.GetInstance(ProductType.A) as A;
                        a.Run();

                        B? b =  ProductCreator.GetInstance(ProductType.B) as B;
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
    #region Abstract Product
    interface IProduct   // bunun implement edilmemiş sınıflardan artık nesne üretilmeyecek.
    {
        void Run();
    }
    #endregion

    #region Concrete Products 
    //süreçte üretmeyi hedeflediğimiz nesne grupları.
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
    #endregion
    #region Creator 
    enum ProductType
    {
        A, B, C
    }

    // product  concrete  sınıfların nesne üretimini üstlenecek sınıfımız Creator sınıfı.
    class ProductCreator  // nesne üretme talebi alabileceği ve üretip döndürebileceği bir metoda ihtiyacı var.
    {
        public static IProduct GetInstance(ProductType productType)  // IProduct geri döndürüyoruz çünkü temsil edebilir hepsine implement verdi.
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
    #endregion
}
