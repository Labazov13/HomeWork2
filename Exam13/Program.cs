System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
if (num <= 99)
{
    System.Console.WriteLine("Третьей цифры нет");
}
if (num <= 999 ^ num <= 99) //156 --6
{
    int num3 = (num % 100) % 10;
    System.Console.WriteLine("Третья цифра числа " + num + " : " + num3);
}
if (num <= 9999 ^ num <= 999)   //1564 --6
{
    int num3 = (num / 10) % 10;
    System.Console.WriteLine("Третья цифра числа " + num + " : " + num3);
}
if (num <= 99999 ^ num <= 9999) //15642 --6
{
    int num3 = (num / 100) % 10;
    System.Console.WriteLine("Третья цифра числа " + num + " : " + num3);
}

// И так далее... Немного топорное решение,но пока не могу понять, как можно сократить код не изменив логику программы
