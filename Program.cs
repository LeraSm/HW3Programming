// Console.WriteLine("Hello, World!");
Console.Clear();

// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндр

// Console.Write("input five digit number: ");
// int number= Convert.ToInt32(Console.ReadLine());
// if(number>99999 || number<10000)
// {
//     Console.Write($"{number} is not five digit");
//     return;
// }
// if(number/10000 != number%10)
// {
//     Console.Write($"{number} is not palindrom");
// }
// else if((number/1000)%10 != (number%100)/10)
// {
//    Console.Write($"{number} is not palindrom");

// }
// else
// {
//     Console.Write($"{number} is palindrom");
// }

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("input number 1-N: ");
// int number= Convert.ToInt32(Console.ReadLine());
// int i= 1;
// while (i<=number)
// {
//     Console.Write(Math.Pow(i,3)+ "|");
//     i++;
// }

// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки a: ");
int x1 =Convert.ToInt32(Console.ReadLine());
int y1=Convert.ToInt32(Console.ReadLine());
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки b: ");
int x2 =Convert.ToInt32(Console.ReadLine());
int y2=Convert.ToInt32(Console.ReadLine());
int z2=Convert.ToInt32(Console.ReadLine());
double d=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+ Math.Pow(z1-z2,2));
Console.WriteLine($"d={d:f2}");






