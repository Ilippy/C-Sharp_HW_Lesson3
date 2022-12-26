// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using NumberMain;
internal partial class ShowCubeNumber
{
    private static void Main(string[] args)
    {
        int number = Numbers.EnterNumber("Введите целое число");
        ShowStringCubeNumbers(number);
    }

    static void ShowStringCubeNumbers(int number){
        System.Console.WriteLine($"{number} -> {ShowCubeNumbers(number)}");
    }

    //Рекурсия 
    static string ShowCubeNumbers(int n, int i = 1){
        if(i > n) return "";
        return $"{Math.Pow(i,3)}" + (i+1 > n ? "" : ", ") + ShowCubeNumbers(n, i+1);
    }
}