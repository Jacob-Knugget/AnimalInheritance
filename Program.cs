using System;

namespace Inheritance
{
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public Animal()
        {
            name = "";
            type = "";
            color = "";
        }

        public Animal(string name, string type, string color)
        {
            this.name = name;
            this.type = type;
            this.color = color;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
        public void display()
        {
            Console.WriteLine("Animal Information: ");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Color: {color}\n");
        }
    }
    class Hamster : Animal
    {
        public double weight;  // accessible from any class
        private int age;  //accessible from derived classes
        public int speed;

        public Hamster()
        {
            weight = 0;
            age = 0;
            speed = 0;
        }
        public Hamster(string name, string type, string color, double weight, int age, int speed)
            :base(name, type, color)
        {
            this.weight = weight;
            this.age = age;
            this.speed = speed;
        }

        public void setAge(int age)
        {
            this.age = age;
        }
        public virtual int getAge()
        {
            return age;
        }

        // access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // access type directly because it is protected and this is a derived class
        public override string getType()
        {
            return type;
        }
        public void display()
        {
            Console.WriteLine("Hamster Information: ");
            Console.WriteLine($"Name: {getName()}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Speed (mph): {speed}\n");
        }
    }  
    class Program
    {
        static void Main(string[] args)
        {
            Animal monkey = new Animal("Ludwig", "Monkey", "Purple");

            Hamster one = new Hamster("Hagul", "Rodent", "Brown", 5, 2, 7);

            monkey.display();
            one.display();

        }
    }
}



