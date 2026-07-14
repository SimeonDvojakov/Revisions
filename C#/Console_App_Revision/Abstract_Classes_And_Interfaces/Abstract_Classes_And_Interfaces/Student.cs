using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_And_Interfaces
{
    public class Student : User, IStudent
    {
        protected Dictionary<string, int> Grades = new();
        public Student(int id, string name, string username, Dictionary<string,int> grades) : base(id, name, username)
        {
            Grades = grades;
        }
        public void PrintGrades()
        {
            Console.WriteLine($"Printing grades for student {this.Name} with ID: {this.Id}");
            foreach (KeyValuePair<string, int> grade in this.Grades)
            {
                Console.WriteLine($"Subject: {grade.Key}, Grade: {grade.Value}");
            }
        }

        public void PrintUser()
        {
            double average = 0;
            foreach (KeyValuePair<string, int> grade in Grades)
            {
                average += grade.Value;
            }
            average = average / Grades.Count;
            Console.WriteLine($"Student with ID: {this.Id}, Name: {this.Name}, Username: {this.Username}");
            Console.WriteLine($"Has a grade average of {Math.Round(average, 2) }");
        }
    }
}
