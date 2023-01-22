Console.Clear();
Console.WriteLine($"Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int x1 = x / 100;
x1 = Math.Abs(x1);
if(x1 < 1)
{
Console.WriteLine($"Третьей цифры нет");

}
else

{

x1 %= 10; 
Console.WriteLine ($"Введенное число {x}, третья цифра числа {x1}");
}