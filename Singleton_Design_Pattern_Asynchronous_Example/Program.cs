namespace Singleton_Design_Pattern_Asynchronous_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var t1 = Task.Run(() => { Example example = Example.GetInstane; });
            //var t2 = Task.Run(() => { Example example = Example.GetInstane; });
            //var t3 = Task.Run(() => { Example example = Example.GetInstane; });
            //var t4 = Task.Run(() => { Example example = Example.GetInstane; });
            //var t5 = Task.Run(() => { Example example = Example.GetInstane; });

            var t1 = Task.Run(() => { Example example = Example.GetInstane(); });
            var t2 = Task.Run(() => { Example example = Example.GetInstane(); });
            var t3 = Task.Run(() => { Example example = Example.GetInstane(); });
            var t4 = Task.Run(() => { Example example = Example.GetInstane(); });
            var t5 = Task.Run(() => { Example example = Example.GetInstane(); });
        }
    }

}
