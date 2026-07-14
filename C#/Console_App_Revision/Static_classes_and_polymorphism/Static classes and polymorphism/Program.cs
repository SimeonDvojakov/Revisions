using Static_classes_and_polymorphism;

Dog dog1 = new Dog(1, "Sparky", "Orange");
Dog dog2 = new Dog(0, "", " ");
Dog dog3 = new Dog(3, "Dzuki", "");

DogShelter.ListOfDogs.Add(dog1);
DogShelter.ListOfDogs.Add(dog2);
DogShelter.ListOfDogs.Add(dog3); 


DogShelter.PrintAll();
Dog.Validate(dog1);
Dog.Validate(dog2);
Dog.Validate(dog3);
