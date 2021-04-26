using Newtonsoft.Json;
using System;
using System.Linq;
using test21.model;
using test21.rest;
using test21.Util;


namespace test21
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(employee.ToString());
            employee.employee_age = 24;
            employee.employee_name = "Tom";
            employee.id = 23;
            employee.employee_salary = 1200;
            Console.WriteLine(employee.ToString());

            
            listOfEmploees(getEmployees());
            String userDateName =  Util.Util.createUserNameWithTimeStamp(longestName(getEmployees()));
            Console.WriteLine(postEmployee(Util.Util.createNewUser(userDateName,584111,111)));
            Console.WriteLine(userDateName);
            sortByAge(getEmployees(),20,50);
            generateRandomEmployee();


        }

        private static void generateRandomEmployee()
        {
            RAndomEmployeeParams rendomEmployee = new RAndomEmployeeParams();
            Console.WriteLine(rendomEmployee.employeeAge);
            Console.WriteLine(rendomEmployee.employeeName);
            Console.WriteLine(rendomEmployee.employeeSalary);
            Console.WriteLine(postEmployee(Util.Util.createNewUser(rendomEmployee.employeeName, rendomEmployee.employeeSalary, rendomEmployee.employeeAge)));
        }

        public static void listOfEmploees(String employeeContent)
        {
            Employees listEmploee = JsonConvert.DeserializeObject<Employees>(employeeContent);
            int count = 0;
            for (int i = 0; i < listEmploee.data.Count(); i++)
            {
                if (Util.Util.isCharMatchXTimes('a', 2, listEmploee.data[i].employee_name) == true) continue;
                Console.WriteLine(count++ + "." + " id: " + listEmploee.data[i].id + "  " + "name: " + listEmploee.data[i].employee_name);
            }

        }

        public static String longestName(String employeeContent)
        {
            Employees listEmploee = JsonConvert.DeserializeObject<Employees>(employeeContent);
            int maxLength = listEmploee.data[0].employee_name.Length;
            int longestNameId = 0;

            for (int i = 0; i < listEmploee.data.Count(); i++)
            {
                if (listEmploee.data[i].employee_name.Length > maxLength) {
                    maxLength = listEmploee.data[i].employee_name.Length;
                    longestNameId = i;
                }
            }
            return listEmploee.data[longestNameId].employee_name;
        }

        public static void sortByAge(String employeeContent,byte minValue, byte maxValue)
        {
            Employees listEmploee = JsonConvert.DeserializeObject<Employees>(employeeContent);
            int count = 0;
            for (int i = 0; i < listEmploee.data.Count(); i++)
            {
                if (listEmploee.data[i].employee_age > minValue && listEmploee.data[i].employee_age < maxValue)
                {
                    Console.WriteLine(count++ + "." + " id: " + listEmploee.data[i].id + "  " + "name: " + listEmploee.data[i].employee_name
                        + "  " + listEmploee.data[i].employee_age);
                }
                
                }


        }

       

        public static String getEmployees()
        {
            return new RestQuery("http://dummy.restapiexample.com")
                                .Get("/api/v1/employees");
        }

        public static String postEmployee(CreateEmployee createEmployee)
        {
            return new RestQuery("http://dummy.restapiexample.com")
                                .Post("/api/v1/create", createEmployee);
        }

        public static String deleteEmployee(Int32 id)
        {
            return new RestQuery("http://dummy.restapiexample.com")
                                .Delete("/api/v1/create", id);
        }
    }
}
