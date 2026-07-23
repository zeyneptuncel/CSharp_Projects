// girilen kenar sayısına göre bir ikizkenar dik üçgen çizen program

Console.Write("Kenar uzunluğunu giriniz: ");
int k = Convert.ToInt32(Console.ReadLine());
if (k<0)
{
    System.Console.WriteLine("HATA. Negatif değer geçersizdir.");
}
else
{
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
        
    }
}
