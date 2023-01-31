// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


int max = 0;
int min = 0;

Console.WriteLine ("Введите число А:");
int numberA = System.Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine ("Введите число Б:");
int numberB = System.Convert.ToInt32(System.Console.ReadLine());

if(numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);