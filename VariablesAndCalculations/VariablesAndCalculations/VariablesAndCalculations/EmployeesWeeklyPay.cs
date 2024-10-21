using System;

namespace VariablesAndCalculations
{
    public class EmployeesWeeklyPay
    {
        public int hourlyRate;
        public int hoursWorked;

        public void calculations()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Please input the hourly rate:");
                    hourlyRate = Convert.ToInt32(Console.ReadLine());
                    if (hourlyRate < 0)
                    {
                        Console.WriteLine("Invalid input. Hourly rate cannot be negative.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            }


            while (true)
            {
                try
                {
                    Console.WriteLine("Please input the hours worked:");
                    hoursWorked = Convert.ToInt32(Console.ReadLine());
                    if (hoursWorked < 0)
                    {
                        Console.WriteLine("Invalid input. Hours worked cannot be negative.");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

            }

            int regularPay;
            if (hoursWorked <= 40)
            {
                regularPay = (hourlyRate * (hoursWorked));
            }
            else
            {
                regularPay = (int)(hourlyRate * 40 + hourlyRate * 1.5 * (hoursWorked - 40));
            }

            var taxToBePaid = regularPay * 0.2f;

            Console.WriteLine("The gross pay is: " + regularPay);
            Console.WriteLine("The tax to be paid is: " + taxToBePaid);
            Console.WriteLine("The net pay is: " + (regularPay - taxToBePaid));

        }
    }
}