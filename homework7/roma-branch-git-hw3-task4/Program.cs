double result = default;
double number1;
double number2;

bool switcher = false;

Console.WriteLine("Please, choose first operand");
bool parseFirstNumber = double.TryParse(Console.ReadLine(), out number1);
Console.WriteLine("Please, choose second operand");
bool parseSecondNumber = double.TryParse(Console.ReadLine(), out number2);
Console.WriteLine("Please, choose operator");
string @operator = Console.ReadLine();

if (@operator != "+" && @operator != "-" && @operator != "*" && @operator != "/")
{
    Console.WriteLine("Only following operators are legit: +, -, *, /");
    return;
}

if (parseFirstNumber && parseSecondNumber)
{
    switcher = true;
}

while(switcher)
{
    SwitchCase switchCase = new(@operator, number1, number2, result);

    switchCase.PerformSwitch();

    switcher = false;
}