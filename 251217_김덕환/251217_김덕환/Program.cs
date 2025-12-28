namespace _251217_김덕환;

class Program
{
    static void Main(string[] args)
    {
        CarData car1 = new CarData();
        car1.PrintInfo();
    }

    struct CarData
    {
        private int maxSpeed;
        private float fuel;
        private string name;
        private string info;

        public CarData()
        {
            maxSpeed = 130;
            fuel = 75.4f;
            name = "덕카";
            info = "꽉";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine($"{maxSpeed}");
            Console.WriteLine($"{fuel}%");
            Console.WriteLine($"{info}");
        }

    }
}