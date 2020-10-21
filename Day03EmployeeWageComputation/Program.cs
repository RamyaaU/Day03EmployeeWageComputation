/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day03EmployeeWageCompuatation.exe Day03EmployeeWageCompuatation.cs
 *  Execution:    Day03EmployeeWageCompuatation.exe 103
 *  
 *  Purpose: Adds part time employee and wage
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
			const int IS_PART_TIME = 2;
			const int EMP_RATE_PER_HOUR = 20;
			
	
			// Variables
			int empHrs = 0;
			int empWage = 0;
			// Computation
			if (empCheck() == IS_PART_TIME)
			{
				empHrs = 8;
			}
			else if (empCheck == IS_PART_TIME)
			{
				empHrs = 0;
			}
			empWage = empHrs * EMP_RATE_PER_HOUR;
			Console.WriteLine("Emp Wage: " + "20" * empWage);
		}
			public static int EmpCheck()
        		{
           		 Random random = new Random();
            		return random.Next(0, 2);
        }
    }
}
    

