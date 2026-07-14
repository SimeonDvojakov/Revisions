using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_And_Interfaces
{
    public abstract class User : IUser
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Username { get; set; }
        protected User(int id, string name, string username)
        {
            Id = id;
            Name = name;
            Username = username;
        }
        public void PrintUser()
        {
            Console.WriteLine($"User ID: {this.Id}, Name: {this.Name}, Username: {this.Username}");
        }
    }
}
