// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// void TwoToN(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         TwoToN(n, count + 1);
//         Console.Write(count + " ");
//     }
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// TwoToN(number, count);


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumNatural(m - 1, n));
// }

// int SumNatural (int m, int n)
// {
//    int count = m;
//    if ( n == m)
//    {
//     return 0;
//    }
//    else
//    {
//     m = m + 1;
//     count = m + SumNatural(m, n);
//     return count;
//    }
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// void AkkermanZadacha(int n, int m)
// {
//     System.Console.WriteLine(Akkerman(n,m));
// }

// int Akkerman (int n, int m)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else    
//         if ( n == 0 && m > 0)
//         {
//             return Akkerman(m - 1,1);
//         }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m,n - 1)));
//     } 
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanZadacha(m,n);