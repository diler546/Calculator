public class MathOperations
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 != 0)
            return num1 / num2;
        else
            throw new ArgumentException("Divisor cannot be zero");
    }

    public double Power(double num1, double num2)
    {
        return Math.Pow(num1,num2);
    }
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию (+, -, *, /, ^):");
        char operation = Convert.ToChar(Console.ReadLine());

        MathOperations mathOperations = new MathOperations();
        double result = 0;

        switch (operation)
        {
            case '+':
                result = mathOperations.Add(num1, num2);
                break;
            case '-':
                result = mathOperations.Subtract(num1, num2);
                break;
            case '*':
                result = mathOperations.Multiply(num1, num2);
                break;
            case '/':
                try
                {
                    result = mathOperations.Divide(num1, num2);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    return;
                }
                break;
            case '^':
                result = mathOperations.Power(num1, num2);
                break;
            default:
                Console.WriteLine("Неизвестная операция.");
                return;
        }

        Console.WriteLine($"\nРезультат: {result}\n");
    }
}