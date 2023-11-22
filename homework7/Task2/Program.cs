int Add(int operand1, int operand2)
{
    return operand1 + operand2;
}
int Sub(int operand1, int operand2)
{
    return operand1 - operand2;
}
int Mul(int operand1, int operand2)
{
    return operand1 * operand2;
}
string Div(int operand1, int operand2)
{
    return operand2 == 0 ? "Не можна дiлити на нуль": ((float)operand1 / operand2).ToString();
}
while (true)
{
    Console.WriteLine("Введiть знак арефметичної операцiї або ! щоб вийти");
    string sign = Console.ReadLine();
    if (sign == "!")
    {
        break;
    }
    Console.WriteLine("Введiть перше число");
    int operand1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введiть друге число");
    int operand2 = int.Parse(Console.ReadLine());
    switch (sign)
    {
        case "+":
            Console.WriteLine(Add(operand1, operand2));
            break;
        case "-":
            Console.WriteLine(Sub(operand1, operand2));
            break;
        case "*":
            Console.WriteLine(Mul(operand1, operand2));
            break;
        case "/":
            Console.WriteLine(Div(operand1, operand2));
            break;
        default:
            Console.WriteLine("Невiрний арефметичний знак");
            break;

    }

    Console.ReadKey();
}
