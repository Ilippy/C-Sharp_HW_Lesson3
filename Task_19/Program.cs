// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Можно было бы ограничить 5 цифрами, но я решил проверять любое число
using NumberMain;
internal partial class Program
{
    private static void Main(string[] args)
    {
        int number = Numbers.EnterNumber("Введите целое число");
        IsNumberPalindrome(number);
        IsNumberPalindromeString(number);

    }

    static void IsNumberPalindrome(int number)
    {
        int start, end;
        bool isPalindrome = true;
        int numberDigits = (int)Math.Floor(Math.Log10(number) + 1);
        for (int i = 0; i < numberDigits / 2; i++)
        {
            start = number / (int)Math.Pow(10, numberDigits - 1 - i) % 10;
            end = number / (int)Math.Pow(10, i) % 10;
            // System.Console.WriteLine($"#{i} - {start}, {end}, {start == end}");
            if (start != end)
            {
                isPalindrome = false;
                break;
            }
        }
        System.Console.WriteLine($"Число {number} " + (isPalindrome ? "" : "не ") + "является палиндромом");
    }

    static void IsNumberPalindromeString(int number)
    {
        string stringNumber = number.ToString();
        int numberDigits = stringNumber.Length;
        bool isPalindrome = true;
        for (int i = 0; i < numberDigits / 2; i++)
        {
            // System.Console.WriteLine($"#{i} - {stringNumber[i]}, {stringNumber[numberDigits - 1 - i]}, {stringNumber[i] == stringNumber[numberDigits - 1 - i]}");
            if (stringNumber[i] != stringNumber[numberDigits - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        System.Console.WriteLine($"Число {number} " + (isPalindrome ? "" : "не ") + "является палиндромом");
    }

}