using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_6_hands_on
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static void Main(string[] args)
        {
            
            List<Student> student_list = new List<Student>();
            student_list.Add(new Student() { Id = 1, Name = "Krithika", Age = 20});
            student_list.Add(new Student() { Id = 2, Name = "Sai", Age = 20});
            student_list.Add(new Student() { Id = 3, Name = "Priya", Age = 20});
            student_list.Add(new Student() { Id = 4, Name = "Nithya", Age = 20});
            foreach (Student student in student_list)
            {
                Console.WriteLine("Name = "+student.Name);

            }
        }
    }
}
