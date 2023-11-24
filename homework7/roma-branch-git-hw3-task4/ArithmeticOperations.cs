class ArithmeticOperations
{
    public void Addition(double number1, double number2, double result)
    {
        result = number1 + number2;

        Console.WriteLine($"Result of an addition operation is {result}");
    }

    public void Subtraction(double number1, double number2, double result)
    {
        result = number1 - number2;

        Console.WriteLine($"Result of a substraction operation is {result}");
    }

    public void Multiplication(double number1, double number2, double result)
    {
        result = number1 * number2;

        Console.WriteLine($"Result of a multiplication operation is {result}");
    }

    public void Division(double number1, double number2, double result)
    {
        result = number1 / number2;

        Console.WriteLine($"Result of a division operation is {result}");
    }
}