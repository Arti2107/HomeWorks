namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyingObjects = new IFlyable[]
            {
new Bird(25),
new Airplane(4000, 116),
new Bird(200),
new Airplane(1500, 30)
        };
            foreach (IFlyable flyable in flyingObjects)
            {
                flyable.Fly();
            }
            Console.ReadKey();
        }
    }
    public interface IFlyable
    {
        void Fly();
        int MaxAltitude { get; }
    }
    public class Bird : IFlyable
    {
        public int MaxAltitude { get; }

        public Bird(int maxAltitude)
        {
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }
    public class Airplane : IFlyable
    {
        public int MaxAltitude { get; }
        public int CountPassengers { get; }
        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
