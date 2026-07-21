Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi%2==1)
{
    Console.WriteLine($"{sayi} sayısı tek sayıdır.");
}
else
{
    Console.WriteLine($"{sayi} sayısı çift sayıdır.");
}
