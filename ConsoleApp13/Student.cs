using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Student
    {
        public int[] _grades;

        public int[] Grades
        {
            get { return _grades; }
        }

        public void MethodGrades(int[] grades)
        {
            int count = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]%2==0)
                {
                    count++;
                }
            }

            _grades=new int[count];
            count = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]%2==0)
                {
                    _grades[count] = grades[i];
                    count++;
                }
            }
        }

        
    }
}
