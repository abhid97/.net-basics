using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cons1;
using secondClass1;
using thirdClass1;
using property;
namespace practise
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Cons obj = new Cons(20,30); 
                    
            Console.WriteLine("a- " + obj.a);
            Console.WriteLine("b- " + obj.b);

            Cons obj3 = new Cons();
            obj3.a = 100;
            obj3.b = obj3.a + obj.b;
            Console.WriteLine("empty cons a- " + obj3.a);
            Console.WriteLine("empty cons b- " + obj3.b);

            secondClass obj1 = new secondClass();
            Console.WriteLine("a- " + obj1.a);
            Console.WriteLine("b- " + obj1.b);

            thirdClass obj2 = new thirdClass();
            Console.WriteLine("a- " + obj2.a);
            Console.WriteLine("b- " + obj2.b);

            pro prop = new pro(20);
            prop.A = 0;
            //prop.B = 100;
            Console.WriteLine("b- " + prop.B);
            //Console.WriteLine(prop.A+" "+prop.B);

            Cons ob = new Cons();
            Cons.e = 200;
            //ob.d = 100;  //readonly can't be assigned value outside constructor

            Console.WriteLine("e= " + Cons.e + " " + "d= " + ob.d +"c= "+Cons.c);

            Cons ob1 = new Cons(1000, 2000);
            Console.WriteLine("c= " + Cons.c + " d= " + ob1.d);

            Cons num = new Cons(gcard.AMD);

            Console.WriteLine("Enter the company");
            string input = Console.ReadLine();
            
            if(input.Equals(gcard.AMD.ToString()))
            {
                staticClass.changeConsoleColor(gcard.AMD);
            }
            else if (input.Equals(gcard.Nvidia.ToString()))
            {
                staticClass.changeConsoleColor(gcard.Nvidia);
            }
            else
            {
                Console.WriteLine("INPUT OUT OF RANGE");
            }
            
            Console.ReadKey();
        }
    }
}
