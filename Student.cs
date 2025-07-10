using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1._4._2
{
    public class Student
    {
        private int _studentId;

        public int StudentId
        {
            get
            {
                return _studentId;
            }
            set
            {
                if (value > 1)
                {
                    _studentId = value;
                }
                else
                {
                    _studentId = 1;
                }
            }
        }
        public string StudentFname { get; set; }
        public string StudentLname { get; set; }
        public char StudentGrade { get; set; }

        public void DisplayInfo()
        {

            Console.WriteLine($"Student id: {StudentId:000}");
            Console.WriteLine($"Student's name is: {StudentFname} {StudentLname}");
            Console.WriteLine($"Student's grade is a: {StudentGrade}");
        }
    }
}
