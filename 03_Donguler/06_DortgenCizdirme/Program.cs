// iki kenar uzunlugu girilerek dörtgen çizen prgram
/* ORNEK CIKTI (5,5)
    -----
    |ooo|
    |ooo|
    |ooo|
    -----   */
Console.Write("1. kenar uzunluğunu giriniz: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("2. kenar uzunluğunu giriniz: ");
int l = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= k; i++)
{
    if (i==1 || i==k)
    {
        for (int j = 1; j <= l; j++)
        {
            System.Console.Write("-");
        }
    }
    else
    {
        System.Console.Write("|");
        for (int o = 1; o <= l-2 ; o++)
        {
            System.Console.Write("o");
        }
        System.Console.Write("|");
    }
    System.Console.WriteLine();
}
