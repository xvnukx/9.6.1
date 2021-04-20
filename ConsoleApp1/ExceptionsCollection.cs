using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class ExceptionsCollection : Exception
    {
        private Exception[] ex = new Exception[5];

        public ExceptionsCollection()
        {
            ex[0] = new DivideByZeroException();
            ex[1] = new DirectoryNotFoundException();
            ex[2] = new ArgumentException();
            ex[3] = new MyException("Моё исключение.");
            ex[4] = new ArgumentNullException();
        }
        public Exception this[int index]
        {
            get
            {
                return ex[index];
            }

        }
        public void ShowException()
        {
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    throw ex[i];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    Console.WriteLine();
                }

            }
        }
    }
}
