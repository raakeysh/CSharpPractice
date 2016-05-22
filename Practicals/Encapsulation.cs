using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
   public class Encapsulation
    {
       

       public void inEncFunct1DerivedPublic()
       {
           
       }

       private void inEncFunct1DerivedPrivate()
       {
           
       }

       protected void inEncFunct1DerivedProtected()
       {
           Console.WriteLine("This is public funct inside class of class.");
       }

       internal void inEncFunct1DerivedInternal()
       {
           Console.WriteLine("This is public funct inside class of class.");
       }
        
    }

    class ClassPrivate
    {
        public void EncFunct1()
        {
            Encapsulation EC = new Encapsulation();
            EC.inEncFunct1DerivedInternal();
            Console.WriteLine("This is private funct inside private class.");
        }
        
                
    }

}
