namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("ул. Хрустальная, 5", 400, 2003);
            MultiBuilding multiBuilding1 = new MultiBuilding("пер. Каховского, 7", 1700, 1972, 5, true);
            Console.WriteLine("Информация о простом здании:");
            building1.DisplayInfo();
            Console.WriteLine("\nИнформация о многоэтажном здании:");
            multiBuilding1.DisplayInfo();

            Building upcastedBuilding = multiBuilding1;
            Console.WriteLine("\nUpcasting - вызов DisplayInfo() для приведенного объекта:");
            upcastedBuilding.DisplayInfo();
            if (upcastedBuilding is MultiBuilding)
            {
                MultiBuilding downcastedBuilding = (MultiBuilding)upcastedBuilding;
                Console.WriteLine("\nDowncasting успешен:");
                Console.WriteLine($"Площадь на этаж: {downcastedBuilding.AreaPerFloor:F2} м2/эт.");

                Console.WriteLine("\nВызов уникального свойства AreaPerFloor:");
                Console.WriteLine($"Средняя площадь на этаж: {downcastedBuilding.AreaPerFloor:F2} м2/эт.");
            }
            Console.WriteLine("\nСравнение налогов:");
            Console.WriteLine($"Налог для простого здания: {building1.CalculateTax()} р.");
            Console.WriteLine($"Налог для многоэтажного здания: {multiBuilding1.CalculateTax()} р.");
            Console.ReadKey();
        }
        public class Building
        {
            protected string _address;
            protected double _area;
            protected int _yearBuild;
            public Building(string address, double area, int yearBuild)
            {
                _address = address;
                _area = area;
                _yearBuild = yearBuild;
            }
            public virtual double CalculateTax()
            {
                double tax = _area * 1000;
                return tax;
            }
            
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Адрес: {_address}");
                Console.WriteLine($"Площадь: {_area} м2");
                Console.WriteLine($"Год постройки: {_yearBuild} г.");
                Console.WriteLine($"Возраст здания: {BuildingAge} лет");
                Console.WriteLine($"Налог: {CalculateTax()} р.");
            }
            public int BuildingAge
            {
                get { return DateTime.Now.Year - _yearBuild; }
                }
            }
        public sealed class MultiBuilding : Building
        {
            private int _floors;
            private bool _hasElevator;
            public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
                : base(address, area, yearBuilt)
            {
                _floors = floors;
                _hasElevator = hasElevator;
            }
            public override double CalculateTax()
            {
                double baseTax = base.CalculateTax();
                double floorsCoeff = 1 + (_floors - 1) * 0.05;
                double elevator = _hasElevator ? 5000 : 0;
                return baseTax * floorsCoeff + elevator;
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Количество этажей: {_floors}");
                Console.WriteLine($"{(_hasElevator ? "Дом с лифтом" : "Лифт отсутствует")}");
                Console.WriteLine($"Средняя площадь на этаж: {AreaPerFloor:F2} м2/эт.");
            }
            public double AreaPerFloor
            {
                get { return _area / _floors; }
            }
        }
    }
}
