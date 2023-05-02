// Программа выдающая таблицу кубов от 1 до N


int n = Prompt("Введите число N: ");

NumbTable (n);

void NumbTable(int n)
{
    if(n<0)
    {
        int M = -1;
        while(n<=M)
       {
    
         int sqr = n*n*n;
        Console.WriteLine(sqr);
         n++;
       }
    }
    else
    {
    int S = 1;
    
while(S<=n)
{
    
    int sqr = S*S*S;
    Console.WriteLine(sqr);
    S++;
}
}
}


int Prompt(string messege)
{
    Console.Write(messege);
    int coordNumber = int.Parse(Console.ReadLine());
    int n = Convert.ToInt32(coordNumber);
    return (n);
}