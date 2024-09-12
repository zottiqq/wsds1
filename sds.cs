using System;

class Program
{
    static void Main()
    {
        string input1, input2, operation;
        Console.Write("Введите первое число: ");
        input1 = Console.ReadLine();
        Console.Write("Введите второе число: ");
        input2 = Console.ReadLine();
        
        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            Console.WriteLine("1 - сложение, 2 - вычитание, 3 - умножение, 4 - деление");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "1": Console.WriteLine(number1 + number2); break;
                case "2": Console.WriteLine(number1 - number2); break;
                case "3": Console.WriteLine(number1 * number2); break;
                case "4": if (number2 != 0) Console.WriteLine(number1 / number2); else Console.WriteLine("Ошибка: деление на ноль!"); break;
                default: Console.WriteLine("Неверная операция"); break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: некорректный ввод.");
        }
    }
}
