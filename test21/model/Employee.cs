using System;
using System.Collections.Generic;
using System.Text;

namespace test21.model
{
   public class Employee
    {
        public int id { get; set; }
        public String employee_name { get; set; }
        public int employee_salary { get; set; }
        public Byte employee_age { get; set; }
        public String profile_image { get; set; }

        public override string ToString()
        {
            return "id: " + id + ", " + "employee_name: " + employee_name + ", "
                     + "employee_salary: " + employee_salary + ", " + "employee_age: "
                     + employee_age + ", " + "profile_image: " + profile_image +".";
        }

    }
}
