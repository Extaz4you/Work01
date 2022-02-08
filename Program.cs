// Задача 10: Показать вторую цифру трёхзначного числа.

//Console.WriteLine(" Введите число");
//int num = int.Parse(Console.ReadLine());
//int result = (num / 10)%10;
//Console.WriteLine(result);


//Задача 12: Удалить вторую цифру трёхзначного числа.

//Console.WriteLine("ВВедите 3-х значное число ");
//int num = int.Parse(Console.ReadLine());
//if ( num < 100 || num > 999)
{
   // Console.WriteLine("Неправильно число");
    //return;
}
//int delete = 2;
//var str = num.ToString();
//num = int.Parse(str.Remove(str.Length - delete, 1));
//Console.WriteLine(num);


//Задача 14: Найти третью цифру числа или сообщить, что её нет.

//Console.WriteLine("Введите число ");
//int num = int.Parse(Console.ReadLine());
//if (num <= 99)
{
    //Console.WriteLine("Нет 3 цифры");
    //return;
}
//int result = int.Parse(Convert.ToString(num)[1].ToString());
//if (result == 0)
{
    //Console.WriteLine(" Цифра равна 0 ");
    //return;
}
//Console.WriteLine(result);


// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник");
    break;
    case 2: Console.WriteLine("Вторник");
    break;
    case 3: Console.WriteLine("Среда");
    break;
    case 4: Console.WriteLine("Четверг");
    break;
    case 5: Console.WriteLine("Пятница");
    break;
    case 6: Console.WriteLine("Суббота - выходной");
    break;
    case 7: Console.WriteLine("Воскресенье - выходной");
    break;
}
