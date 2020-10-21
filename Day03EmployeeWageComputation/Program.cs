/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day03EmployeeWageCompuatation.exe Day03EmployeeWageCompuatation.cs
 *  Execution:    Day03EmployeeWageCompuatation.exe 103
 *  
 *  Purpose: Determines whether employee is present or not
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
        static void Main(string[] args)
        {
            //constants
            const int IS_FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            //reference for random class
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {

                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}