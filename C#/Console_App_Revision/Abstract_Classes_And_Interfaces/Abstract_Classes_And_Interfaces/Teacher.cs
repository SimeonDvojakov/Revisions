using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_And_Interfaces
{
    public class Teacher : User, ITeacher
    {
        protected List<string> Subjects = new();
        public Teacher(int id, string name, string username, List<string> subjects) :base(id, name, username)
        {
            this.Subjects = subjects;
        }
        public void PrintSubjects()
        {
            Console.WriteLine($"Printing Subjects for teacher {this.Name}");
            foreach (string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public void PrintUser()
        {
            Console.WriteLine($"Teacher ID: {this.Id}, Name: {this.Name}, Username: {this.Username}");
            Console.WriteLine($"Number of subjects tought: {this.Subjects.Count}");
        }


    }
}
