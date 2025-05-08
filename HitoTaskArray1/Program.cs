using System;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using static HitoTaskArray1.ArrayMethods;

namespace HitoTaskArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] finalArray;
            
            Console.WriteLine("Введите количество строк:");
            int linesCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов в каждой строке:");
            int columnsCount = int.Parse(Console.ReadLine());
            
            int[,] array = CreateArray(linesCount, columnsCount);
            
            PrintArray(array);
            
            Console.WriteLine("\nВыберите действие:\n1. Повернуть массив против часовой стрелке.\n2. Повернуть массив по часовой стрелки.\n3. Инверсия массива.");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine("\nПоворот: против часовой стрелки.\nПовернуть на:\n1. 90°\n2. 180°\n3. 270°");
                    int answer1 = int.Parse(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:
                            finalArray = Rotate90Counterclockwise(array);
                            PrintArray(finalArray);
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("\nПоворот: по часовой стрелке.\nНеправильный ввод, дальнейшие действия недоступны.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("\nПовернуть на:\n1. 90°\n2. 180°\n3. 270°");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            finalArray = Rotate90Clockwise(array);
                            PrintArray(finalArray);
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("\nНеправильный ввод, дальнейшие действия недоступны.");
                            break;
                    }
                    break;
                case 3:
                    finalArray = ReverseArray(array);
                    PrintArray(finalArray);
                    Console.WriteLine("Массив перевернут.");
                    break; 
                default:
                    Console.WriteLine("\nНеправильный ввод, дальнейшие действия недоступны.");
                    break;
            }

            Console.ReadKey();
        }
    }
}