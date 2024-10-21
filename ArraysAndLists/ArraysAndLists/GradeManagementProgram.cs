using System;
using System.Linq;
using System.Xml.Schema;

namespace ArraysAndLists
{
    public class GradeManagementProgram
    {
        private int numberOfStudents;
        

        public GradeManagementProgram(int numberOfStudents)
        {
            this.numberOfStudents = numberOfStudents;
        }

        public double averageMarks(int numberOfStudents)
        {
            var marks = new int[numberOfStudents];
            for (int i = 0; i < marks.Length; i++)
            {  Console.WriteLine("input the student marks");
            
                marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            
            double total = marks.Sum();

            var average = (total / numberOfStudents);
            Console.WriteLine("the average mark is: "+average);
            Console.WriteLine("the max value is :" + marks.Max());
            Console.WriteLine("the min value is :" + marks.Min());

            var count = marks.Where(x => x >= 50).Count();
            Console.WriteLine("the number of passed students are: "+ count);
            return average;

        }

        
    }
}