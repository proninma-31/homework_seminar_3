// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     int result = 0;
//     while (true)
//     {
//         if(int.TryParse(Console.ReadLine(), out result) && result >= 9999 && result <=99999)
//         {
            
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Число не пятизначное, или не число. Попробуй ещё раз");
//         }
//     }
//     return result;
// }
// string ConvertoString()
// {
//     int x = GetNumber("Введите пятизначное число, чтобы проверить палендром ли оно");

//    string p = x.ToString();
// return p;
// }

// string arrive = ConvertoString();

// if (arrive[0] == arrive[4] && arrive[1] == arrive[3] )
// {
//     Console.WriteLine("Да, это палендром дружище");
// }
// else
// {
//     Console.WriteLine("К сожалению это не палендром");
// }

// ==========================================================================================================

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// int GetNumber( string message)


// {
//     Console.WriteLine(message);
//     int result = 0;
//     while (true)
//     {
//        if(int.TryParse(Console.ReadLine(), out result) && result != 0) 
//        {
//         break;
//        }
//        else
//        {
//         Console.WriteLine("Попробуй еще раз дружок, не вводи ноль и буквы");
//        }
//     }
//    return result;   
// }

// double GetDistance(int x1, int y1, int z1,int x2, int y2, int z2)
// {
// {
//     double result = Math.Sqrt((Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2))) ;
//     return result;
// }

// }


// int x1 = GetNumber("Вводи первую координату x");
// int y1 = GetNumber("Вводи первую координату y");
// int z1 = GetNumber("Вводи первую координату z");
// int x2 = GetNumber("Вводи вторую координату x");
// int y2 = GetNumber("Вводи вторую координату y");
// int z2 = GetNumber("Вводи вторую координату z");
// Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));

// =======================================================================================

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int GetNumber(string message)
// {
//     int result = 0;
//     Console.WriteLine(message);
//     while (true)
//     {
//        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
//        {
//         break;
//        }
//        else
//        {
//         Console.WriteLine ("Всё фигня, давай по новой");
//        }
//     }
//     return result;
// }

// int n = GetNumber("Вводи число, щас таблица кубов будет");
// for (int i = 1; i <= Math.Abs(n); i++)
// {
//     System.Console.Write($"{Math.Pow(i,3)} ");
// }

