using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_hands_on
{
    internal class AggregationEx
    {

    }
    public class Student
    {
        string name;
        int age;
        int rollno;
        int dept_id;
        Marks M;
        public Student(string name, int age, int rollno, int dept_id, Marks M)
        {
            this.name = name;
            this.age = age;
            this.rollno = rollno;
            this.dept_id = dept_id;
            this.M = M;
        }

        public void display()
        {
            Console.WriteLine($"Name : {name},age : {age} ,rollno: {rollno}, dept_id : {dept_id},Total marks : {M.total_marks}");
            M.percentageCal();
            Console.WriteLine($"Your percentage is : {M.percentage}");
        }



        //public static void getValues(string name)

    }
    public class Marks
    {
        public int total_marks;
        public int no_subjects;
        public Marks(int total_marks, int no_subjects)
        {
            this.total_marks = total_marks;
            this.no_subjects = no_subjects;
        }

        public float percentage;
        public Marks() { }
        public void percentageCal()
        {
            percentage = (total_marks / no_subjects);
            Console.WriteLine(percentage);
        }

    }
}

