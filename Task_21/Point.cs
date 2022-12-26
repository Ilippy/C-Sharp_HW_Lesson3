using NumberMain;

namespace Task_21
{
    public class Point
    {
 


        public string Name { get; private set; } // Имя
        public int X { get; private set; }  // Точка по оси Х
        public int Y { get; private set; } // точка по оси Y
        public int Z { get; private set; } // точка по оси Z


        public Point(string name)
        {
            this.Name = name;
            this.X = Numbers.EnterNumber($"Введите координату {name} по оси Х");
            this.Y = Numbers.EnterNumber($"Введите координату {name} по оси Y");
            this.Z = Numbers.EnterNumber($"Введите координату {name} по оси Z");
        }

        public void ShowDistanceBetween(Point b)
        {
            double distance = Math.Sqrt(Math.Pow(this.X - b.X, 2) + Math.Pow(this.Y - b.Y, 2) + Math.Pow(this.Z - b.Z, 2));
            System.Console.WriteLine($"{this.Name} ({this.X}, {this.Y}, {this.Z}); {b.Name} ({b.X}, {b.Y}, {b.Z}) -> {distance:f2}");
        }
        
    }
}