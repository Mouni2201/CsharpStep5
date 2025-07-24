using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA;

namespace ProjectC
{
    //classA: by default its not
    //Now by default you can't access the class directly over here, and classA should be public
    internal class ClassX:ClassA
    {
        void DisplayClassXMembers()
        {
            Console.WriteLine("Inside ClassX (Derived):");
            //Console.WriteLine(privateVariable);           //Not Accessible
            Console.WriteLine(protectedVar);                //Accessible
            //Console.WriteLine(internalVar);                 //Not Accessible  even we create instance can't access
            Console.WriteLine(ProtectedInternalVar);        //Accessible
            Console.WriteLine(publicVar);                   //Accessible
        
    }
    }
}
