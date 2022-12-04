int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;
System.Console.WriteLine("Введите число");
int numOfTheDay = int.Parse(Console.ReadLine()!);
if (numOfTheDay == Saturday ^ numOfTheDay == Sunday)
{
    System.Console.WriteLine("Это выходной,поздравляю!");
}
else if (numOfTheDay == Friday)
{
    System.Console.WriteLine("Это почти выходной,потерпи:)");
}
else if (numOfTheDay == Monday || numOfTheDay == Tuesday || numOfTheDay == Wednesday || numOfTheDay == Thursday)
{
    System.Console.WriteLine("Это не выходной,иди работай!");
}
else if (numOfTheDay > Sunday)
{
    System.Console.WriteLine("Мы не знаем,что это такое. Если бы мы знали,что это такое, мы не знаем,что это такое");
}

/* Альтернативный вариант решения:
System.Console.WriteLine("Введите число");
int numOfTheDay = int.Parse(Console.ReadLine()!);
switch(numOfTheDay){
    case 1:
    System.Console.WriteLine("Это не выходной,иди работай!");
    break;
    case 2:
    System.Console.WriteLine("Это не выходной,иди работай!");
    break;
    case 3:
    System.Console.WriteLine("Это не выходной,иди работай!");
    break;
    case 4:
    System.Console.WriteLine("Это не выходной,иди работай!");
    break;
    case 5:
    System.Console.WriteLine("Это почти выходной,потерпи:)");
    break;
    case 6:
    System.Console.WriteLine("Это выходной,поздравляю!");
    break;
    case 7:
    System.Console.WriteLine("Это выходной,поздравляю!");
    break;
    default:
    System.Console.WriteLine("Мы не знаем,что это такое. Если бы мы знали,что это такое, мы не знаем,что это такое");
    break;
}*/



