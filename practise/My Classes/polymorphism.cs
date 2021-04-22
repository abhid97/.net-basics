using System;

namespace Polymorphism
{
    class functionOverload
    {
        public void sum(int a)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Cyan;
            System.Console.WriteLine(a);
            System.Console.ResetColor();
        }
        public void sum(double a)
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine(a);
            System.Console.ResetColor();
        }
        public void sum(string str)
        {
            System.Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            System.Console.WriteLine(str);
            System.Console.ResetColor();
        }
        
    }

    abstract class poly
    {
        abstract public void absMethod();

        public void nonabsMehtod()
        {
            System.Console.WriteLine("This in non abstract method in abstract class");
        }

        public poly()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Red;
            System.Console.WriteLine("This is a constructor of abstract class");
            System.Console.ResetColor();
        }
            
    }
    interface firstInt
    {
        void firstintmethod();
     
    }
    interface secondInt
    {
        void secintmethod();
    }
    class abs : poly, firstInt, secondInt
    {
        public abs()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine("This is a constructor of derived class");
            System.Console.ResetColor();
        }
        public override void absMethod()
        {
            Console.WriteLine("This is abstract method which has a definition in derived class from abstrct class");
        }
        public void firstintmethod()
        {
            Console.WriteLine("This is first interface method defined without using override keyword");
        }
        public void secintmethod()
        {
            Console.WriteLine("This is second interface method defined without using override keyword");
        }

    }
    
}
