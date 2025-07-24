using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class ClassA   //public needs to be here
    {
        private string privateVariable = "Private: Only accessible within the class";
        protected string protectedVar = "Protected: Accessible inderived class";
        internal string internalVar = "Internal: Accessible within the assembly class";
        protected internal string ProtectedInternalVar = "Protected Internal:Accessible in same assembly or derived class of another assembly";
        public string publicVar = "Public: access anywhere";



        void DisplayBaseClassMember()
        {
            Console.WriteLine("Inside ClassA:");      
            Console.WriteLine(privateVariable);         //Accessible
            Console.WriteLine(protectedVar);            //Accessible
            Console.WriteLine(internalVar);
            Console.WriteLine(ProtectedInternalVar);    //Accessible
            Console.WriteLine(publicVar);               //Accessible

        }

    }
}
