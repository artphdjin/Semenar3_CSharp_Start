using System;

namespace Semenar3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
            14212 -> нет
            12821 -> да
            23432 -> да
            Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            A (3,6,8); B (2,1,-7), -> 15.84
            A (7,-5, 0); B (1,-1,9) -> 11.53
            Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
            3 -> 1, 8, 27
            5 -> 1, 8, 27, 64, 125
            */


            // Задача 19
            
            
            Console.WriteLine("Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Введите число:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int numberTask19);

            if (numberCheck)
            {
                if (numberTask19 < 100000)
                {
                    if((numberTask19 % 10 == numberTask19 / 10000) && ((numberTask19 % 10) / 10 == (numberTask19 / 1000) % 10))
                        Console.WriteLine("да");
                    else Console.WriteLine("нет");
                }
                else Console.WriteLine("не 5-значное число.");

            }
            else Console.WriteLine("не число.");

            Console.WriteLine("\n");
            

            // Задача 21
            

            Console.WriteLine("Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            Console.WriteLine("Введите координаты А и В через Enter сначала A, затем В (защита ввода не предусмотрена):");

            int[,] koordinatXYZ = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    koordinatXYZ[i, j] = int.Parse(Console.ReadLine());
                }

            }

            double dist3D = Math.Sqrt(Math.Pow(koordinatXYZ[0, 0] - koordinatXYZ[1, 0], 2) +
                Math.Pow(koordinatXYZ[0, 1] - koordinatXYZ[1, 1], 2) + Math.Pow(koordinatXYZ[0, 2] - koordinatXYZ[1, 2], 2));

            Console.WriteLine("{0:f2}", dist3D);
            Console.WriteLine("\n");


            // Задача 23


            Console.WriteLine("Задача 23 Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел от 1 до N.");
            Console.WriteLine("Введите N");

            numberCheck = int.TryParse(Console.ReadLine(), out int task23);
            String answer23 = "";

            if (numberCheck)
            {
                for (int i = 1; i<=task23; i++)
                {
                    if (i>1) answer23 += ", ";
                    answer23 += Math.Pow(i,3);
                }
                Console.WriteLine(answer23);
            }
            else Console.WriteLine("не число");

        }
    }
}
