using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    abstract class Abstraction
    {
        public abstract void display();

        public virtual void foo()
        {
            Console.WriteLine("Virtual method in Abstract class.");
        }

        public void foobar()
        {
            Console.WriteLine("foobar method in Abstract class.");
        }

        public abstract void Bar();

    }

    class DerivedA : Abstraction
    {
        public override void display()
        {
            Console.WriteLine("Display method in derived class.");
        }

        public override void foo()
        {
            Console.WriteLine("Override method in derived class.");
        }

        public override void Bar()
        {
            Console.WriteLine("Abstract Bar method in derived class.");
        }
    }

}
