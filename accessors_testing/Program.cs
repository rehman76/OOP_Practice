using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Practice;

namespace accessors_testing
{
    public abstract class client
    {
        public void message() {

            Console.WriteLine("hello world");
        }
    }
   

    interface ICustomer
    {
         void FirstName();
         void LastName(); 
    }

    interface IClient
    {
        void FirstName();
        void LastName();


    }
    public class Customer :client
    {
       


    }

    public class RegualrCustomer : Customer
    {
        

    }

    public class TemporaryCustomer : RegualrCustomer
    {
        public int Experience;
        public string FirstName;
        public string LastName;


        public static void CustomerList(List<TemporaryCustomer> tempcustomer,Ispromotable promote)
        {
            foreach(var temp in tempcustomer)
            {
                if (promote(temp))
                {
                    Console.WriteLine("Employee:{0}{1} is Promoted",temp.FirstName,temp.LastName);

                }

            }

        }


    }



    public class CorporateCustomer : Customer
    { 


    }

    class Complex
    {
        private int x;
        private int y;
        public Complex()
        {
        }
        public Complex(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static Complex operator -(Complex c)
        {
            Complex temp = new Complex();
            temp.x = -c.x;
            temp.y = -c.y;
            return temp;
        }
    }
    public delegate bool Ispromotable(TemporaryCustomer temp);

    class Program
    {
       public static void Main()
        {
            MyClass check = new MyClass();
            check.X = 20;
            int x = check.X;
            Console.WriteLine(x);

            Customer c1 = new Customer();
            //ICustomer)c1).FirstName();
            //IClient)c1).FirstName();

            float q = 323456.51232332F;
            decimal dm = (decimal)q;
            decimal a = dm;
            Console.WriteLine("Value after type casting is :{0}", a);

            RegualrCustomer cust = new RegualrCustomer();
            cust.message();
            List<TemporaryCustomer> templist = new List<TemporaryCustomer>();
            templist.Add(new TemporaryCustomer {Experience =10,FirstName="Rehman",LastName="Ali" });
            templist.Add(new TemporaryCustomer { Experience = 2, FirstName = "Rehman", LastName = "Ali" });
            templist.Add(new TemporaryCustomer { Experience = 5, FirstName = "Khalil", LastName = "Ahmed" });
            templist.Add(new TemporaryCustomer { Experience = 4, FirstName = "Rehman", LastName = "Ali" });
            templist.Add(new TemporaryCustomer { Experience = 8, FirstName = "Fahad", LastName = "Munir" });
            TemporaryCustomer.CustomerList(templist, customer => customer.Experience >= 5);

            Complex b1 = new Complex(10, 20);
            b1.ShowXY(); // displays 10 & 20  
            Complex c2 = new Complex();
            c2.ShowXY(); // displays 0 & 0  
            c2 = -b1;
            c2.ShowXY(); // diapls -10 & -20  

        }
    }
}
