//Create a base class Animal with properties Name and Age and a method Speak().
//Derive as many classes from it as you want (e.g. Dog, Cat, Horse) and override the Speak() method
//in each derived class to output a specific sound. Instantiate both derived classes
//and call their Speak() methods. The Speak() method should print to the Console output.

using Esercizio6;

Animal animal1 = new Bird();
Animal animal2 = new Cat();
Animal animal3 = new Dog();

animal1.Speak();
animal2.Speak();
animal3.Speak();

