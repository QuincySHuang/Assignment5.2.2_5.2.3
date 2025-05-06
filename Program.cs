



Console.Write("Enter number to print in ascending order: ");
int number = int.Parse(Console.ReadLine());
Ascend(number);

int Ascend(int n)
{
    if (n <= 0)
        return n;
    
    Ascend(n - 1);

    Console.WriteLine(n);

    return n;

}

Console.Write("Enter number to print in reverse: ");
int number1 = int.Parse(Console.ReadLine());
Reverse(number1);

int Reverse(int n)
{
    if (n <= 0)
        return n;

    Console.WriteLine(n);
    return Reverse(n - 1);
}