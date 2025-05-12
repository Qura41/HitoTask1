namespace HitoTaskArray1;
using static ArrayMethods;

public class IO // InputOutput
{
    public static int Lines { get ; private set; }
    public static int Columns { get ; private set; }
    
    public static int Validation(IInputReader reader)
    {
        int field;
        while (true)
        {
            string input = reader.ReadLine();
            if (int.TryParse(input, out field))
                break;
            else
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
        }

        return field;
    }
    public static void LinesCount(IInputReader reader)
    {
        Console.WriteLine("Введите количество строк:");
        
        Lines = Validation(reader);
    }

    public static void ColumnsCount(IInputReader reader)
    {
        Console.WriteLine("Введите количество элементов в каждой строке:");
        
        Columns = Validation(reader);
    }

    public static void Menu(IInputReader reader)
    {
        int[,] finalArray;
        
        LinesCount(reader);
        ColumnsCount(reader);

        int linesCount = Lines;
        int columnsCount = Columns;
            
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
                        Console.WriteLine("\nНеправильный ввод, дальнейшие действия недоступны.");
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
    }
}