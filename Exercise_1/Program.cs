int yourNumber = GetNumber("Enter your number ");
FindSecondDigit(yourNumber);


void FindSecondDigit(int a)
{
    int secondDigit = (a % 100) / 10;
    Console.WriteLine($"{a} -> {secondDigit}");
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}