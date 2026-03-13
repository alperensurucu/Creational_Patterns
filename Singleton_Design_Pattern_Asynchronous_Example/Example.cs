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
        static object _obj = new object();  //for using lock
        public static Example GetInstane
        {
            #region firs singleton design pattern yöntemi

            //get
            //{
            //    if (_example == null)
            //    {
            //        _example = new Example();
            //    }
            //    return _example;
            //}
            #endregion

            #region Second singleton design pattern 

            #endregion
            lock (_obj)
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
