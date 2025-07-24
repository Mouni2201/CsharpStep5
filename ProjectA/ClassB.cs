using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    internal class ClassB:ClassA
    {
        void DisplayDerivedClassMembers()
        {
            Console.WriteLine("Inside ClassB (Derived):");
            //Console.WriteLine(privateVariable);           //Not Accessible
            Console.WriteLine(protectedVar);                //Accessible
            Console.WriteLine(internalVar);                 //Accessible
            Console.WriteLine(ProtectedInternalVar);        //Accessible
            Console.WriteLine(publicVar);                   //Accessible
        }
    }
}
