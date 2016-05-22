using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    class Program
    {
        static void Main(string[] args)
        {
            //DerivedA DA = new DerivedA();            
            //DA.display();
            //DA.foo();
            //DA.Bar();
            //DA.foobar();

            //Derived1 D1 = new Derived1();
            //Derived4 D4 = new Derived4();

            //D1.Funct1();
            //D1.Funct2();

            //D4.Funct1();
            //D4.Funct3();
            //D4.Funct4();

            //ClassPrivate CP = new ClassPrivate();
            //CP.EncFunct1();
            //Encapsulation EC = new Encapsulation();
            //EC.inEncFunct1DerivedPublic();


            System.Console.WriteLine("Pascal Triangle Program");
            System.Console.Write("Enter the number of rows: ");
            string input = System.Console.ReadLine();

            int n = Convert.ToInt32(input);


            for (int y = 0; y < n; y++)
            {
                int c = 1;
                for (int q = 0; q < n - y; q++)
                {
                    System.Console.Write("   ");
                }

                for (int x = 0; x <= y; x++)
                {
                    System.Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                System.Console.WriteLine();
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
         
            Console.ReadLine();
        }
    }
}
