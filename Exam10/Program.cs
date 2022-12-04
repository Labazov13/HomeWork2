System.Console.WriteLine("Введите число от 100 до 999 включительно ");
int num = int.Parse(Console.ReadLine()!);
if (num <= 99 || num > 999)
{
    System.Console.WriteLine(num + " не входит в диапазон программы.Введите число от 100 до 999 включительно");
}
int num2 = (num / 10) % 10;
System.Console.WriteLine("Вторая цифра числа " + num + ": " + num2);


