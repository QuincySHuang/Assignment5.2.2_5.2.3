



Console.Write("Enter number to print in ascending order: ");
int number = int.Parse(Console.ReadLine());
Ascend(number);

void Ascend(int n)
{
    if (n <= 0)
        return;

    Ascend(n - 1);

    Console.WriteLine(n);


}

Console.Write("Enter number to print in reverse: ");
int number1 = int.Parse(Console.ReadLine());
Reverse(number1);

void Reverse(int n)
{
    if (n <= 0)
        return ;
    Console.WriteLine(n);
    Reverse(n - 1);
}