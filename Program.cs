void Recurs1(int m, int n)
{
    if (m > n) return;
    if (m % 3 == 0) Console.Write(m + ", ");
    m++;
    Recurs1(m, n);
}
void Recurs2(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.Write(sum);
        return;
    }
    sum += m;
    m++;
    Recurs2(m, n, sum);
}
int Recurs3(int m, int n)
{
    if (m == 0) return n += 1;
    else if (n == 0) return Recurs3(m - 1, 1);
    else return Recurs3(m - 1, Recurs3(m, n - 1)); 
}

void Zadacha64()
{
    Console.Write("Ввидите M: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Ввидите N: ");
    int b = int.Parse(Console.ReadLine());
    Recurs1(a,b);
    Console.WriteLine("\b\b.");
}
void Zadacha66()
{
    Console.Write("Ввидите M: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Ввидите N: ");
    int b = int.Parse(Console.ReadLine());
    Recurs2(a,b);
}
void Zadacha68()
{
    Console.Write("Ввидите M: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Ввидите N: ");
    int b = int.Parse(Console.ReadLine());
    int v = Recurs3(a,b);
    Console.Write("Функция Аккермана = "+ v);
}

Zadacha68();