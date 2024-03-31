using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student();

            student.MethodGrades(new int[] { 1, 3, 4, 8, 11, 14 });

            foreach (var item in student.Grades)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
