using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3_hands_on
{
    internal class Constructors
    {
            string Name;
            int id;
            string department;
            float grade;
            public Constructors(string myName, int myId, string myDepartment, float myGrade)
            {
                this.Name = myName;
                this.id = myId;
                this.department = myDepartment;
                this.grade = myGrade;
            }
            public void displayStudent()
            {
                Console.WriteLine("Details of the student are : " + Name + " is th name ");
                Console.WriteLine(id + " is id " + department + "is dept " + grade + " is grade");
            }

            //static void Main(string[] args)
            //{

            //    Constructors myProgram = new Constructors("Krithika", 8, "automobile", 8.8f);
            //    myProgram.displayStudent();
            //    Constructors myProgram1 = new Constructors("Anna", 10, "cs", 9.2f);
            //    myProgram1.displayStudent();
            //}

        }
    }
