// See https://aka.ms/new-console-template for more information
int Number = new int();
Console.WriteLine("Введите число:");
Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 1)
{
    Console.WriteLine("Число" + Number  + " является: НЕЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + Number + " является: ЧЁТНЫМ");
}