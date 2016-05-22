using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    class Inheritance
    {
       
    }

    public class BaseClass
    {
        public void Funct1()
        {
            Console.WriteLine("Inside base class.");
        }
    }

    public class Derived1 : BaseClass
    {
        public void Funct2()
        {
            Console.WriteLine("Inside derived 1 class.");
        }
    }

    public class Derived2 : BaseClass
    {
        public void Funct3()
        {
            Console.WriteLine("Inside derived 2 class.");
        }
    }

    public class Derived3 : BaseClass
    {
        public void Funct4()
        {
            Console.WriteLine("Inside derived 3 class.");
        }
    }

    public class Derived4 : Derived2
    {
        public void Funct4()
        {
            Console.WriteLine("Inside derived 4 class.");
        }
    }
    
}
