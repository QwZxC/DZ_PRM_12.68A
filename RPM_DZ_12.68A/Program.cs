namespace RPM_DZ_12._68A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 0;
            int columns = 0;
            Random random = new Random();

            try
            {
                Console.Write("Введите количество строк: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Введите колличество столбцов(не меньше 3-х): ");
                columns = int.Parse(Console.ReadLine());
            } 
            catch
            {
                Console.WriteLine("Вы ввели не число");
                return;
            }

            if(columns < 3)
            {
                Console.WriteLine("Недостаточно стлобцов");
                return;
            }

            int[,] numbers = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                    numbers[i, j] = random.Next(100);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write($"{numbers[i, j]} ");
                Console.WriteLine();
            }

            Console.WriteLine($"Среднее арифметическое элементов 3-го столба {ArithmeticMean(numbers)}");;
        }

        static int ArithmeticMean(int[,] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
                sum += numbers[i, 2];
            return sum / numbers.GetLength(0);
        }
    }
}