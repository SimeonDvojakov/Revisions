using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_classes_and_polymorphism
{
    public class Dog
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected string Color { get; set; }
        public Dog(int id, string name, string color)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetColor(color);
        }

        public int GetId()
        {
            return this.Id;
        }
        public void SetId(int id)
        {
            this.Id = id;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static void Validate(Dog dog)
        {
            int numberOfChecks = 3;
            List<int> checksList = new List<int>();
            if (dog.Id <= 0)
            {
                Console.WriteLine("Error, dog entry has an invalid ID");
                checksList.Add(1);
            }
            if (dog.Name == null || dog.Name.Trim() == "")
            {
                Console.WriteLine("Error, dog entry has an invalid Name");
                checksList.Add(2);
            }
            if (dog.Color == null || dog.Color.Trim() == "")
            {
                Console.WriteLine("Error, dog entry has an invalid Color");
                checksList.Add(3);
            }

            if (checksList.Count == numberOfChecks)
            {
                Console.WriteLine("All checks passed");
                Console.WriteLine("Dog entry has all the required properties");
            }
        }
    }
}
