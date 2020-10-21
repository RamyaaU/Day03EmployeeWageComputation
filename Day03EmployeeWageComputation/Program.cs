/******************************************************************************
*  Compilation:  csc.exe /t:exe /out:Day03EmployeeWageCompuatation.exe Day03EmployeeWageCompuatation.cs
*  Execution:    Day03EmployeeWageCompuatation.exe 103
*  
*  Purpose: Calculation of Monthly wages of employee
*
*  @author  Ramya U
*  @version 1.0
*  @since   21-10-2020
*
******************************************************************************/

using System;

namespace Day03EmployeeWageComputation
{
	class Program
	{
        private static object getRandom;

        public static object EMP_WAGE_DETAILS { get; private set; }

        static void Main(string[] args)
		{
            //constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 8;
            const int NUM_OF_WORKING_DAYS = 20;
            //variables
            int empHrs = 0;
            int empwage = 0;
            int totalEmpWage = 0;
            //for loop
            for (int day = 0; day <= NUM_OF_WORKING_DAYS; day++)
            {
                //switch cases
                switch (EmpCheck())
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empwage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empwage;
                Console.WriteLine("Employee wage (per day)" + day + " is " + empwage);
            }
            Console.WriteLine("Total employee wage (per month) " + totalEmpWage);

        }
        /// <summary>
        /// Generates the Random value either 0 or 1.
        /// </summary>
        /// <returns>
        /// Returns random value.
        /// </returns>
        public static int EmpCheck()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}