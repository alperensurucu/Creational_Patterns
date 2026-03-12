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
            if (_example == null)
            {
                _example = new Example();
            }
            return _example;
        }
    }

}