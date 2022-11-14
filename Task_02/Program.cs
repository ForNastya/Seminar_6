// Показать числа Фибоначчи
Console.WriteLine("До какого числа считать ряд Фибоначчи? ");
int number = int.Parse(Console.ReadLine() ?? "0");
int numA = 1;
Console.Write("{0}", numA);
int numB = 1;
Console.Write("{0}", numB);
int sum = 0;
while (number >= sum)
{
    sum = numA + numB;
        Console.Write("{0} ", sum);
            numA = numB;
            numB = sum;
}
