//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.//
int Number1 = new int();
Console.WriteLine("Введите число");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Введите число");
Number2 = Convert.ToInt32(Console.ReadLine());
int Number3 = new int();
Console.WriteLine("Введите число");
Number3 = Convert.ToInt32(Console.ReadLine());
int max = Number1;
if(Number1 > max) max = Number1;
if(Number2 > max) max = Number2;
if(Number3 > max) max = Number3;
Console.Write("Максимальное число - ");
Console.WriteLine(max);