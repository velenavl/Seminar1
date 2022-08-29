// Написать программу, которая будет выдавать название дня недели по заданному номеру.

//int week = Convert.ToInt32(Console.ReadLine());
//if (week == 1)
{
    //Console.WriteLine("Понедельник");
}
//if (week == 2)
{
    //Console.WriteLine("Вторник");
}
//if (week == 3)
{
    //Console.WriteLine("Среда");
}
//if (week == 4)
{
    //Console.WriteLine("Четверг");
}
//if (week == 5)
{
    //Console.WriteLine("Пятница");
}
//if (week == 6)
{
    //Console.WriteLine("Суббота");
}
//if (week == 7)
{
    //Console.WriteLine("Воскресенье");
}

int number = Convert.ToInt32(Console.ReadLine());
switch(number)
{
    case 1:Console.WriteLine("Понедельник");
        break;
    case 2:Console.WriteLine("Вторник");
        break;
    case 3:Console.WriteLine("Среда");
        break;
    case 4:Console.WriteLine("Четверг");
        break;
    case 5:Console.WriteLine("Пятница");
        break;
    case 6:Console.WriteLine("Суббота");
        break;
    case 7:Console.WriteLine("Воскресенье");
        break;
}