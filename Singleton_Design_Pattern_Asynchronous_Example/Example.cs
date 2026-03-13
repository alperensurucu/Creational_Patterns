using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern_Asynchronous_Example
{
    class Example
    {
        private Example()
        {
            Console.WriteLine($"{nameof(Example)} object created.");     
        }
        static Example _example;
        public static Example GetInstane
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
}
