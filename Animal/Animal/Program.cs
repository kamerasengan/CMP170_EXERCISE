using System;
using System.Collections;
using System.Collections.Generic;
namespace Animal
{
    class Program
    {
        public interface IAnimal
        {
            DateTime birthday { get; }
            void Move();
            void Speak();
        }

        public class Pet : IAnimal
        {
            public string name;
            public DateTime birthday => birthday.Date;
            public void Move() { }
            public void Speak() { }
        }

        public class Dog : Pet
        {
            public void Speak()
            {
                Console.WriteLine("The dog say gaw gaw");
            }
            public void Move()
            {
                Console.WriteLine("The dog walks and runs");
            }
        }

        public class Cat : Pet
        {
            public void Move()
            {
                Console.WriteLine("The cat walks and runs");
            }
            public void Speak()
            {
                Console.WriteLine("The cat speaks meow meow");
            }
        }

        public class Monkey : IAnimal
        {
            public DateTime birthday => birthday.Date;
            public void Move()
            {
                Console.WriteLine("The monkey walks and runs");
            }
            public void Speak()
            {
                Console.WriteLine("The monkey speaks kec kec");
            }

            public void climb()
            {
                Console.WriteLine("Monkey can climb tree");
            }
        }

        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Move();
            cat1.name = "Tagu";
            cat1.Speak();

            Dog dog1 = new Dog();
            dog1.Move();
            dog1.Speak();
            dog1.name = "Wison";

            Monkey monkey1 = new Monkey();
            monkey1.Move();
            monkey1.Speak();
            monkey1.climb();
        }
    }
}

