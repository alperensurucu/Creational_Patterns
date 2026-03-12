
// ikinci yöntemde static ctorda üretiyoruz nesneyi.
class Exam
{
    static void Main(string[] args)
    {
        Exam exeee = Exam.GetInstace;
    }

    private Exam()
    {
         Console.WriteLine($"{nameof(Exam)}");   
    }

    static Exam()
    {
        _exam = new Exam();
    }
    static Exam _exam;

    public static Exam GetInstace
    {
        get { return _exam; }
    }
}
