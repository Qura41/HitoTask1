namespace HitoTaskArray1;
using static ArrayMethods;

public class MenuManager
{
    ArrayMethods arrayMethods = new ArrayMethods();
    private int _lines { get ; set; }
    private int _columns { get ; set; }
    private int _resultNumber;
    private int[,] _array;

    public bool isValid(string input) => int.TryParse(input, out _) && int.Parse(input) > 0;
    
    private void Validate()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (isValid(input))
            {
                _resultNumber = int.Parse(input);
                break;
            }
            else
                Console.WriteLine("Пожалуйста, введите корректное целое число(больше 0).");
        }
    }
    
    private void SetLinesCount()
    {
        Console.WriteLine("Введите количество строк:");

        Validate();
        _lines = _resultNumber;
    }

    private void SetColumnsCount()
    {
        Console.WriteLine("Введите количество элементов в каждой строке:");

        Validate();
        _columns = _resultNumber;
    }

    private void InitializeArray()
    {
        SetLinesCount();
        SetColumnsCount();
            
        _array = arrayMethods.CreateArray(_lines, _columns);
    }
    
    public void DisplayMenu()
    {
        bool keepRunning = true;
        
        InitializeArray();
        
        arrayMethods.PrintArray(_array);

        while (keepRunning)
        {
            Console.WriteLine("Выберите действие:\n1. Поворот против часовой стрелки\n2. Поворот по часовой стрелке\n3. Перевернуть массив\n4. Выход");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    while (true)
                    {
                        Console.WriteLine(
                            "\nПоворот: против часовой стрелки.\nПовернуть на:\n1. 90°\n2. 180°\n3. 270°\n4. Вернуться обратно.");
                        int answer1 = int.Parse(Console.ReadLine());
                        switch (answer1)
                        {
                            case 1:
                                _array = arrayMethods.Rotate90Counterclockwise(_array);
                                arrayMethods.PrintArray(_array);
                                break;
                            case 2:
                                _array = arrayMethods.Rotate90Counterclockwise(_array);
                                _array = arrayMethods.Rotate90Counterclockwise(_array);
                                arrayMethods.PrintArray(_array);
                                break;
                            case 3:
                                _array = arrayMethods.Rotate90Counterclockwise(_array);
                                _array = arrayMethods.Rotate90Counterclockwise(_array);
                                _array = arrayMethods.Rotate90Counterclockwise(_array);
                                arrayMethods.PrintArray(_array);
                                break;
                            case 4:
                                Console.WriteLine("Вернуться.");
                                break;
                            default:
                                Console.WriteLine("\nНеправильный ввод, дальнейшие действия недоступны.");
                                break;
                        } if (answer1 == 4) break;
                    }
                    break;
                case 2:
                    while (true)
                    {
                        Console.WriteLine("\nПовернуть на:\n1. 90°\n2. 180°\n3. 270°\n4. Вернуться обратно.");
                        int answer2 = int.Parse(Console.ReadLine());
                        switch (answer2)
                        {
                            case 1:
                                _array = arrayMethods.Rotate90Clockwise(_array);
                                arrayMethods.PrintArray(_array);
                                break;
                            case 2:
                                _array = arrayMethods.Rotate90Clockwise(_array);
                                _array = arrayMethods.Rotate90Clockwise(_array);
                                arrayMethods.PrintArray(_array);
                                break;
                            case 3:
                                _array = arrayMethods.Rotate90Clockwise(_array);
                                _array = arrayMethods.Rotate90Clockwise(_array);
                                _array = arrayMethods.Rotate90Clockwise(_array);
                                arrayMethods.PrintArray(_array);
                                break;
                            case 4:
                                Console.WriteLine("Вернуться.");
                                break;
                            default:
                                Console.WriteLine("\nНеправильный ввод, дальнейшие действия недоступны.");
                                break;
                        } if (answer2 == 4) break;
                    }
                    break;
                case 3:
                    _array = arrayMethods.ReverseArray(_array);
                    arrayMethods.PrintArray(_array);
                    Console.WriteLine("Массив перевернут.");
                    break;
                case 4:
                    Console.WriteLine("Выход из программы.");
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("\nНеправильный ввод, дальнейшие действия недоступны.");
                    break;
            }
        }
    }
}