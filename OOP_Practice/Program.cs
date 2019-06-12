using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
   public class Program
    {
        static void Main(string[] args)
        {
            MyClass oop = new MyClass();
            oop.X = 10;
            int xval = oop.X;
            Console.WriteLine("Value of X is :"+xval);
        }
    }

   public class MyClass
    {
        protected int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
    }

    class Poly : MyClass {




    }
}
