// Расстояние между точками в 3D


int X1 = Prompt("Введите X1: ");
int Y1 = Prompt("Введите Y1: ");
int Z1 = Prompt("Введите Z1: ");
int X2 = Prompt("Введите X2: ");
int Y2 = Prompt("Введите Y2: ");
int Z2 = Prompt("Введите Z1: ");

double d = FirstS(X1, X2, Y1, Y2, Z1, Z2);

double FirstS(int X1, int X2, int Y1, int Y2, int Z1, int Z2)
{
double result = Convert.ToDouble(Math.Round(Math. Sqrt((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1)),2));
Console.WriteLine(result);
return result;
}

int Prompt(string messege)
{
    Console.Write(messege);
    int coordNumber = int.Parse(Console.ReadLine());
    int findQuarter = Convert.ToInt32(coordNumber);
    return findQuarter;
}