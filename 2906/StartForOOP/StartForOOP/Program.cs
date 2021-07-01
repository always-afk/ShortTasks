using System;

namespace StartForOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dog = new Dog();
            var human = new Human(10);

            var spider = new Spider(3);
            var scorpio = new Scorpion();

            dog.Beat(human);

            Console.WriteLine(spider.IsDangerous());
            Console.WriteLine(scorpio.IsDangerous());

            dog.Move();
            human.Move();
        }
    }
}
