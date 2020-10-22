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
            const int IS_PART_TIME = 2;
            const int IS_FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_OF_WORKING_DAYS = 20;
            const int MAX_WORKING_HOURS_IN_A_MONTH = 100;
            //variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            
            while (totalEmpHrs <= MAX_WORKING_HOURS_IN_A_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                ///Switch case is used to check whether employee is working part time or full time
                switch (EmpCheck())
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " : " + "Emp Hr: " + empHrs);
                empWage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empWage;
            }
            Console.WriteLine("total employee wage for a month " + totalEmpWage);
        }
        /// <summary>
        /// returns Random value which is 1 or 2.
        /// </summary>
        /// <returns>
        /// Returns the generated random value.
        /// </returns>
        public static int EmpCheck()
        {
            Random random = new Random();
            return random.Next(1, 3);
        }
    }

}