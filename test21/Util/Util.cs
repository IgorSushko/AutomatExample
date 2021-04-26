using System;
using test21.model;

namespace test21.Util
{
   public static class Util
    {

        public static Boolean isCharMatchXTimes(char charToFind, int numberOfTimes, string lookingString)
        {
            char[] charsArray = lookingString.ToCharArray();
            int countOfMatch = 0;

           for(int i = 0; i< charsArray.Length; i++)
            {
                
                if (charToFind != Char.ToLower(charsArray[i])) continue ;
                countOfMatch++;

                            }
            if (countOfMatch >= numberOfTimes) return true;
            return false;
        }

        public static CreateEmployee createNewUser(String name, Int32 salary, byte age)
        {

            CreateEmployee createEmployee = new CreateEmployee();
            createEmployee.age = age;
            createEmployee.name = name;
            createEmployee.salary = salary;

            return createEmployee;

        }

        public static String createUserNameWithTimeStamp(String longestUserName)
        {

            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");

            return longestUserName + "_" + date;
        }


    }
}
