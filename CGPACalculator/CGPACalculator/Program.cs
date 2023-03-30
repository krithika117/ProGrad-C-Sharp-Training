using System;
using System.Collections.Generic;

namespace CGPACalculator
{

    enum CGPAEnum
    {
        Fail,
        Pass,
        SecondClass,
        FirstClass,
        Distinction,
        Merit
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of courses: ");
            int numOfCourses = int.Parse(Console.ReadLine());

            List<double> marksList = new List<double>();

            for (int i = 0; i < numOfCourses; i++)
            {
                Console.Write($"Enter the marks for course {i + 1}: ");
                double marks = double.Parse(Console.ReadLine());
                marksList.Add(marks);
            }
        }
            public string calculateCGPA(List<double>marksList, int numOfCourses) { 

            double totalMarks = 0;
            foreach (double marks in marksList)
            {
                totalMarks += marks;
            }

            double avgMarks = totalMarks / numOfCourses;
            double cgpa = avgMarks / 10.0;

            string classifier;
            if (cgpa <= 4.0)
            {
                classifier = CGPAEnum.Fail.ToString();
            }
            else if (cgpa < 5.0)
            {
                classifier = CGPAEnum.Pass.ToString();
            }
            else if (cgpa < 6.0)
            {
                classifier = CGPAEnum.SecondClass.ToString();
            }
            else if (cgpa < 7.0)
            {
                classifier = CGPAEnum.FirstClass.ToString();
            }
            else if (cgpa < 8.0)
            {
                classifier = CGPAEnum.Distinction.ToString();
            }
            else
            {
                classifier = CGPAEnum.Merit.ToString();
            }

            Console.WriteLine($"Your CGPA is: {cgpa}");
            Console.WriteLine($"CGPA Classification: {classifier}");
            return classifier;
            
        }
    }
}
