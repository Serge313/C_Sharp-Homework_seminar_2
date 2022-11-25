int yourNumber = GetNumber("Enter your number ");
int count = CountDigits(yourNumber);
int[] array = new int [count];
FillArray(array, yourNumber);

if (count > 2)
{
    Console.WriteLine($"{yourNumber} -> {array[2]}");
}
else
{
    Console.WriteLine("There is no third digit");
}

void FillArray(int[] array1, int a)
{
    for (int i = array1.Length - 1; i >= 0; i--)
    {
        array1[i] = a % 10;
        a = a / 10;
    }
}


int CountDigits(int a)
{
    int counter = 0;
    int rest = 0;
    while (a > 0)
    {
        rest = a % 10;
        a = a / 10;
        counter++;
    }
    return counter;
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}