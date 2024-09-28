

int factorial = int.Parse(Console.ReadLine());
long result = FactorialSum(factorial);
Console.WriteLine(result);

long  FactorialSum(int factorial)
{
    if (factorial == 1)
    {
        return 1;
    }
    return factorial * FactorialSum(factorial - 1);
}