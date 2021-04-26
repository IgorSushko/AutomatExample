using System;
using System.Collections.Generic;
using System.Text;

namespace test21.model
{
    public class CreateEmployee
    {
        public String name { get; set; }
        public Int32 salary { get; set; }
        public Byte age { get; set; }


        public override string ToString()
        {
            return "name: " + name + ", " + "salary: " + salary + ", " + "age: " + age + ".";
        }


    }
}
