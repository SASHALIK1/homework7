class SwitchCase
{
    private readonly ArithmeticOperations arithmeticOperations;
    private readonly string _operator;

    private readonly double _number1;
    private readonly double _number2;
    private readonly double _result;

    public SwitchCase(string @operator, double number1, double number2, double result)
    {
        _operator = @operator;
        _number1 = number1;
        _number2 = number2;
        _result = result;

        arithmeticOperations = new ArithmeticOperations();
    }

    public void PerformSwitch()
    {

        switch (_operator)
        {
            case "+":
                arithmeticOperations.Addition(_number1, _number2, _result);
                break;

            case "-":
                arithmeticOperations.Subtraction(_number1, _number2, _result);
                break;

            case "*":
                arithmeticOperations.Multiplication(_number1, _number2, _result);
                break;

            case "/":
                arithmeticOperations.Division(_number1, _number2, _result);
                break;
        }
    }
}