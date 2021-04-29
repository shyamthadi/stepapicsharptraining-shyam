using System;
using System.Collections.Generic;
using System.Text;

namespace StartingC
{
    class Ob
    {
        private String name;
       
        public Ob(String name)
        {
            Console.WriteLine("the firstobj name is {0}", name);


        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        static void Main()
        {
            String firstobjname = null;
            Console.Write("Enter the name of the first obj");
            firstobjname = Console.ReadLine();
             Ob firstobj = new Ob(firstobjname);
             
             
             }
}
}
