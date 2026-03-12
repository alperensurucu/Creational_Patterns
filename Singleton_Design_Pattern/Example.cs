/*
 
prvate olmazsa ctor istediğin kadar nesne üretirsin 
Example nesnesi oluşturuldu
Example nesnesi oluşturuldu
Example nesnesi oluşturuldu
Example nesnesi oluşturuldu
Example nesnesi oluşturuldu

ama private olursa bir tane 

Example nesnesi oluşturuldu

 */
//new Example();
//new Example();
//new Example();
//new Example();

Example ex = Example.GetInstance;
Example ex1 = Example.GetInstance;
Example ex2= Example.GetInstance;
Example ex3 = Example.GetInstance;
Example ex4 = Example.GetInstance;    // yine bir tane nesne oluşacak ve output => Example nesnesi oluşturuldu.
class Example
{
    private Example()
    {
        Console.WriteLine($"{nameof(Example)} nesnesi oluşturuldu");
    }

    static Example _example; // _example referansını aşağıda kontrol ediyoruz.

    public static Example GetInstance   // example sınıfından nesne üretme sorumluluğunu üstleniyor.
    {
        get
        {
            if (_example == null)         // burada bir  kontrol var ise bu 1. YÖNTEM. <<<<<================
            {
                _example = new Example();
            }
            return _example;
        }
    }

}