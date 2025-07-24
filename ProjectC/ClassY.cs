using ProjectA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC
{
    internal class ClassY
    {
        public void DisplayClassYMemebers()
        {
            Console.WriteLine("Inside ClassY (Independent)");


            //Console.WriteLine(privateVariable);           //Not Accessible
            //Console.WriteLine(protectedVar);              //Not Accessible

            ClassA classA = new ClassA();
            //Console.WriteLine(classA.internalVar);                 //Not Accessible
            //Console.WriteLine(classA.ProtectedInternalVar);        //Not Accessible
            Console.WriteLine(classA.publicVar);                   //Accessible
        }
    }
}
