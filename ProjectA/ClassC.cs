using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    internal class ClassC
    {
        public void DisplayClassCMemebers()
        {
            Console.WriteLine("Inside ClassC (Non - Derived)");

            ClassA classA = new ClassA();

            //Console.WriteLine(privateVariable);           //Not Accessible
            //Console.WriteLine(protectedVar);              //Not Accessible
            Console.WriteLine(classA.internalVar);                 //Accessible
            Console.WriteLine(classA.ProtectedInternalVar);        //Accessible
            Console.WriteLine(classA.publicVar);                   //Accessible
        }
    }
}
