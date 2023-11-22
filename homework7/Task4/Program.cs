string Analyze(int number)
{
    string result;
    if (number > 0)
        result = "Число позитивне";
    else if (number == 0)
        result = "Число дорівнює нулю";
    else
        result = "Число негативне";
    int count = 0;
    int[] numberForCheckNumbers = [1, 2, 3, 5, 6, 9];
    foreach (int numberForCheck in numberForCheckNumbers)
    {
        if (number % numberForCheck == 0)
        {
            count++;
        }
    }
    if (count <= 2)
    {
        result += "\nЧисло просте";
    }
    else
    {
        result += "\nЧисло складне";
    }
    return result;
    

}
Console.WriteLine("Введiть число для аналiзу");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Analyze(number));
Console.ReadKey();


