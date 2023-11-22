
string Exchange(int sum, int exchangeRate)
{
    return exchangeRate == 0 ? "Курс не може бути нуль" : ((float)sum / exchangeRate).ToString();
}
Console.WriteLine("Введiть суму");
int sum = int.Parse(Console.ReadLine());
Console.WriteLine("Введiть курс валюти");
int exchangeRate = int.Parse(Console.ReadLine());
Console.WriteLine($"{Exchange(sum, exchangeRate)}");
Console.ReadLine();
