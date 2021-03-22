using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            var s0 = new Student("Naimul 0", "154", 3.50F);
            var s1 = new Student("Naimul 1", "19", 3.61F);
            var s2 = new Student("naimul 10", "22", 3.62F);




            var c0 = new Course("001", "Web tech");
            var c1 = new Course("002", "DLC");
            var c2 = new Course("003", "OOP 2");




            c0.AddStudent(s1, s2);

            c0.PrintStudent();

            c0.RemoveStudent(s0);

            Console.WriteLine("******After student removed*****");

            s0.PrintCourse();
            c0.PrintStudent();

            Console.WriteLine();

            s2.AddCourse(c0, c1, c2);
            s2.PrintCourse();

            s2.RemoveCourse(c1);
            Console.WriteLine("##### After Remove  A Course#####");
            s2.PrintCourse();
            c1.PrintStudent();
        }
    }
}
