namespace HitoTaskArray1;

public class ArrayMethods
{
        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public int[,] CopyArray(int[,] array)
        {
            int[,] copiedArray = new int[array.GetLength(0), array.GetLength(1)];
            int lines = copiedArray.GetLength(0);
            int columns = copiedArray.GetLength(1);
            
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    copiedArray[i, j] = array[i, j];
                }
            }

            return copiedArray;
        }
        
        public int[,] CreateArray(int linesCount, int columnsCount)
        {
            Random random = new Random();
            
            int[,] arrayNumbers = new int[linesCount, columnsCount];
            for (int i = 0; i < linesCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    arrayNumbers[i, j] = random.Next(1, 10);
                }
            }
            
            return arrayNumbers;
        }

        public int[,] ReverseArray(int[,] array)
        {
            int[,] reversedArray = CopyArray(array);
            int lines = reversedArray.GetLength(0);
            int columns = reversedArray.GetLength(1);


            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j <= columns / 2; j++)
                {
                    int temp = reversedArray[i, j];
                    reversedArray[i, j] = reversedArray[i, columns - 1 - j];
                    reversedArray[i, columns - 1 - j] = temp;
                }
            }
            
            return reversedArray;
        }

        public int[,] Rotate90Counterclockwise(int[,] array)
        {
            int[,] rotatedArray = CopyArray(array);
            int lines = rotatedArray.GetLength(0);
            int columns = rotatedArray.GetLength(1);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int linesRotated = j;
                    int columnsRotated = lines - (i + 1);

                    rotatedArray[columnsRotated, linesRotated] = array[j, i];
                }
            }

            return rotatedArray;
        }
        
        public int[,] Rotate90Clockwise(int[,] array)
        {
            int[,] rotatedArray = CopyArray(array);
            int lines = rotatedArray.GetLength(0);
            int columns = rotatedArray.GetLength(1);

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int linesRotated = columns - (j + 1);
                    int columnsRotated = i;

                    rotatedArray[columnsRotated, linesRotated] = array[i, j];
                }
            }

            return rotatedArray;
        }
}