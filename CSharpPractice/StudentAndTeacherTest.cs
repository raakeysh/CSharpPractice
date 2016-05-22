using System;

namespace CSharpPractice
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Student student = new Student();
            //Teacher teacher = new Teacher();
            //person.SayHello();
            //student.SetAge(14);
            //student.SayHello();
            //student.ShowAge();
            //teacher.SetAge(30);
            //teacher.SayHello();
            //teacher.Explain();
            ManipulateNumbers TN = new ManipulateNumbers();
            //TN.TestNumberPositiveOrNegative();
            //TN.ReverseArray();
            TN.AddNumbers();
            Console.ReadLine();
        }
        
    }

    class programs
    {
        public void program1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Lisha Raut");
        }

    }

    class Person
    {
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I am going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }

    class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }

    class ManipulateNumbers
    {
        private int number;
        private int[] numberArray = new int[5];
        public void TestNumberPositiveOrNegative()
        {
            Console.Write("Enter Number :  ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("{0} is a positive number.", number);
            else
                Console.WriteLine("{0} is a negative number.", number);
        }

        public void ReverseArray()
        {
            int[] ReversedNumberArray = new int[5];
            int j = 4;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Number {0}:  ", (i+1));
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
                ReversedNumberArray[j] = numberArray[i];
                j--;
            }
            Console.WriteLine("Reversed array is ");
            for (int k = 0; k < 5; k++)
            {
                if (k == 0)
                    Console.Write(ReversedNumberArray[k]);
                else
                    Console.Write(", {0}", ReversedNumberArray[k]);

            }
            
        }

        public void AddNumbers()
        {
            int firstNumber, secondNumber;
            Console.Write("Provide Number 1 : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Provide Number 2 : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine("Addition of {0} and {1} is : " +result , firstNumber, secondNumber);            
        }
    }
}
