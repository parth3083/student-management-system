using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Program
    {
        public static void display(Student[] student)
        {
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine($"Name : {student[i].Name}");
                Console.WriteLine($"Enrolment No. : {student[i].Enrollment_no}");
                Console.WriteLine($"Branch : {student[i].Branch}");
                Console.WriteLine("Courses : ");
                for(int j = 0; j < student[i].courses.Length; j++)
                {
                    Console.WriteLine($"{string.Join(",", student[i].courses[j])}");
                }
            }
            Console.WriteLine("---------------------------------------------------------");
        }
        static void Main(string[] args)
        {
            Console.Write("How many data of students you want to enter : ");
            string data_string= Console.ReadLine();
            int data=Convert.ToInt32(data_string);
            Student[] student_data=new Student[data];
            for (int i=0;i<student_data.Length;i++)
            {
                student_data[i]=new Student();
                Console.Write("Enter your name : ");
                student_data[i].Name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter your enrolment no.(last 4 digits) : ");
                string enroll_string=Console.ReadLine();
                Console.WriteLine();
                student_data[i].Enrollment_no=Convert.ToInt32(enroll_string);
                Console.Write("Enter your branch name  : ");
                student_data[i].Branch = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter the total no. of courses : ");
                string count_string=Console.ReadLine();
                Console.WriteLine();
                int count=Convert.ToInt32(count_string);
                student_data[i].courses=new string[count][];
                Console.WriteLine();
                Console.Write("Enter the courses of the semester 6(comma-separaeted) : ");
                for(int j = 0; j < count; j++)
                {
                    student_data[i].courses[j] =Console.ReadLine().Split(',');
                }
            }
            display(student_data);
            Console.ReadKey();
        }
    }
}
