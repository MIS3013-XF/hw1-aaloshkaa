// HW1b Grade

// Your Name:Ally Khrais
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            String firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            String lastName = Console.ReadLine();

            Console.WriteLine("What is your student ID number?");
            String studentID = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homework?");
            Double homeworkGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            Double participationGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            Double quizzesGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            Double midtermGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            Double finalGrade = Convert.ToDouble(Console.ReadLine());

            //calculate the grade according to the syllabus 

            Double overallGrade = 0;

            Console.WriteLine(firstName + " " + lastName + " your overall grade is " + overallGrade);

        }
    }
}
