//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading.Tasks;

//namespace day_6_hands_on
//{
//    class Student
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public string Dept { get; set; }
//        public Student(int id, string name, int age, string dept) {
//            Id = id;
//            Name = name;
//            Age = age;
//            Dept = dept;
//        }
//        public override string ToString()
//        {
//            return $"{Name} {Age} {Dept} {Id}";
//        }
//        public static void Main(string[] args)
//        {
//            List<Student> student_list = new() {
//            new Student(1, "Krithika", 20, "IT"),
//            new Student(2, "Sai", 21, "IT"),
//            new Student(3, "Priya", 22, "CSE"),
//            new Student(4, "Nithya", 23, "CSE"),
//            new Student(5, "Prasad", 24, "IT"),
//            new Student(6, "Mano", 23, "Mech"),
//            new Student(7, "Harish", 22,  "Mech"),
//            new Student(8, "Akash", 21,  "Mech")};

            
//            student_list.Sort((s1, s2) => (s1.Age).CompareTo(s2.Age));
            
//            student_list.ForEach(student => student.Id += 10);
            
//            foreach (Student s in student_list.FindAll(s => s.Dept == "IT")) {
//                Console.WriteLine(s);
//            }
//        }
//    }
//}
