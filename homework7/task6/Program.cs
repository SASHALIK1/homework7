float Calculate(int operand1, int operand2, int operand3)
{
    return (operand1 + operand2 + operand3) / 3;
}
Console.WriteLine("Визначення середнього арифметичного трьох чисел");
int operand1 = int.Parse(Console.ReadLine());
int operand2 = int.Parse(Console.ReadLine());
int operand3 = int.Parse(Console.ReadLine());
Console.WriteLine($"Середнє арифметичне: {Calculate(operand1, operand2, operand3)}");