using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class MyType
    {
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrint;

        public delegate void AfterPrint(string message);
        public event AfterPrint afterPrint;


        public void Print(string message)
        {
            beforePrint?.Invoke(message);
            Console.WriteLine(message);
            if (afterPrint != null)
                afterPrint(message);
        }
    }
}
