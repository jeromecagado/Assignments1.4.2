namespace Assignments1._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            student.StudentId = 007;
            student.StudentFname = "Jerome";
            student.StudentLname = "Cagado";
            student.StudentGrade = 'A';
            student.DisplayInfo();

        }
    }
}
