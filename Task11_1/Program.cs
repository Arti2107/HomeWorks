namespace Task11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
            new Dog(),
            new Cat(),
            new Cat(),
            new Dog()
            };
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ShowInfo());
            }
            Console.ReadKey();
        }
        public abstract class Animal
        {
            public abstract string Name { get; }
            public abstract string Say();
            public string ShowInfo()
            {
                return $"{Name} говорит: \"{Say()}\"";
            }
        }
        public class Dog : Animal
        {
            public override string Name => "Собака";
            public override string Say()
            {
                return "Гав!";
            }
        }
        public class Cat : Animal
        {
            public override string Name => "Кошка";
            public override string Say()
            {
                return "Мяу!";
            }
        }
    }
}
