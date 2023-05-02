// Находим полиндромы

int Number = Promt("Введите пятизначное число: ");

Polindr(Number);

void Polindr(int Num)
{
if((Num/10000) == (Num%10))
   {
    if(((Num%10000)/1000) == ((Num/10)%10))
    {
        Console.Write(" ->Yes");
    }
    else
    {
        Console.Write(" ->No");
    }
    }
 else
 {
    Console.Write(" ->No");
 }   
}
 int Promt(string message)
 {
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return Math.Abs(result);
 }
