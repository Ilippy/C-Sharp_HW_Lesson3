// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
namespace Task_21
{
    class Program
    {
        private static void Main(string[] args)
        {
            Point a = new Point("A");
            Point b = new Point("B");
            
            a.ShowDistanceBetween(b);
        }
    }
}