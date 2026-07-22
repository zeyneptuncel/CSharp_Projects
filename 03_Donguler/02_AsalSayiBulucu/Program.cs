Console.Write("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
bool asalmi=true;
if (number<2)
{
    asalmi=false;
    System.Console.WriteLine("Sayı asal değil");
}

int i = 2;
while (i<number)
{
    if (number%i == 0)
    {
        Console.WriteLine("Sayı asal değil");
        asalmi=false;
        break;
    }
    i++;
}
if (asalmi==true)
{
    System.Console.WriteLine("Bu bir asal sayıdır.");
}