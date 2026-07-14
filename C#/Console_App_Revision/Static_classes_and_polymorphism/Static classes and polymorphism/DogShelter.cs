using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_classes_and_polymorphism
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs = new();

        public static void PrintAll()
        {
            foreach (Dog dog in ListOfDogs)
            {
                Console.WriteLine($"Dog Id: {dog.GetId()}, Dog Name: {dog.GetName()}, Dog Color: {dog.GetColor()}");
            }
        }
    }
}
