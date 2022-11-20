// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int Number1 = new int();
Console.WriteLine("Введите число");
Number1 = Convert.ToInt32(Console.ReadLine());
int Number2 = new int();
Console.WriteLine("Введите число");
Number2 = Convert.ToInt32(Console.ReadLine());
if(Number1 < Number2) 
{
    Console.Write("Большее число - ");
    Console.WriteLine(Number2);
    Console.Write("Меньшее число - ");
    Console.WriteLine(Number1);
}
else
{
Console.Write("Большее число - ");
Console.WriteLine(Number1);
Console.Write("Меньшее число - ");
Console.WriteLine(Number2);
}