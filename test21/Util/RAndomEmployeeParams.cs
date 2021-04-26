using System;
using System.Collections.Generic;
using System.Text;

namespace test21.Util
{
   public class RAndomEmployeeParams
    {
        public String employeeName { get;}
        public Int32 employeeSalary { get;}
        public Byte employeeAge { get; }
        private readonly Random _random = new Random();

       public RAndomEmployeeParams()
        {
            this.employeeAge = getAge();
            this.employeeName = getName();
            this.employeeSalary = getSalary();
        }

        private  Byte getAge() {

            return (Byte)_random.Next(20,50);
        }

        private String getName()
        {

                byte[] randomName = new byte[_random.Next(9)];
                byte[] randomSecondName = new byte[_random.Next(9)];
                _random.NextBytes(randomName);
                _random.NextBytes(randomSecondName);
            return Convert.ToBase64String(randomName) + " " + Convert.ToBase64String(randomSecondName);
            
        }

        private Int32 getSalary()
        {

            return _random.Next(3200, 15000);
        }
    }
}
