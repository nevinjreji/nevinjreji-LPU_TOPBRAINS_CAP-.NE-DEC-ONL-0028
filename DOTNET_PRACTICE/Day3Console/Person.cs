using System;

namespace Day3Console
{
    internal class Person
    {
        public Person()
        {
            Console.WriteLine("Person Class Constructor Invoked.");
        }

        ~Person()
        {
            Console.WriteLine("Person Class Destructor Invoked.");
        }

        ///<summary>
        /// Display Method for Demo Purpose
        /// </summary>
        
        public void Display(object obj)
        {
        System.Console.WriteLine("Display Function in Person Class.");
        System.Console.WriteLine("Value we got : {0}",obj);
        }
    }
}
