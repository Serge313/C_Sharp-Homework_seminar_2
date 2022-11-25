int yourDigit = GetDigit("Enter your digit from 1 to 7 ");
WeekendsOrNot(yourDigit);


void WeekendsOrNot(int a)
{
    if (a > 5 & a < 8)
    {
        Console.WriteLine($"{a} -> yes");
    }
    else if (a > 0 & a < 6)
    {
        Console.WriteLine($"{a} -> no");
    }
    else
    {
        Console.WriteLine("You should choose a digit from 1 to 7 only!");
    }
}


int GetDigit(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}