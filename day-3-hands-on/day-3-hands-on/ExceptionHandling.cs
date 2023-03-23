﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3_hands_on
{
    internal class ExceptionHandling
    {
        static void Main(String[] args) {
            ExceptionHandling.exception_handling();
        }
        public static void exception_handling()
        {
            int a = 10;
            int b = 0;
            int[] arr = { 1, 2, 3, 4 };
            try
            {
                int c = arr[3];
                int d = a / b;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.WriteLine("you cannot divide a num by zero");
            }

            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
                Console.WriteLine("you cannot access an element outside of array limit");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("entered catch block ");
            }

            finally
            {
                Console.WriteLine("entered finally block ");
            }

            //User Defined Exceptions
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                check_age(age);
            }
            catch (myOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void check_age(int age)
        {
            if (age < 18)
            {
                throw new myOwnException("You cant enter here");
            }
            else
            {
                Console.WriteLine("Welcome! you passed the age restriction");
            }
        }

        public class myOwnException : Exception
        {
            public myOwnException(string my_msg) : base(my_msg)
            {

            }
        }



    }
}
