// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.Write("Введите пятизначное число : ");
// string word = Console.ReadLine();
// int size=word.Length-1;
// int index=0;
// if (word[index]==word[size])
// {
//     index++;
//     size--;
//     if (word[index]==word[size])
//     {
//         System.Console.WriteLine("Да");
//     }
//     else{
//         System.Console.WriteLine("Нет");
//     }
// }
// else{
//     System.Console.WriteLine("Нет");
// }





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


System.Console.Write("Введите координату первой точки по x : ");
double ax=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату первой точки по y : ");
double ay=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату первой точки по z : ");
double az=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату второй точки по x : ");
double bx=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату второй точки по y : ");
double by=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату второй точки по z : ");
double bz=Convert.ToDouble(Console.ReadLine());

double result=(Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2)));
System.Console.WriteLine("Координаты первой точки {0},{1},{2} ", ax,ay,az);
System.Console.WriteLine("Координаты второго точки {0},{1},{2} ", bx,by,bz);
System.Console.WriteLine(result);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125