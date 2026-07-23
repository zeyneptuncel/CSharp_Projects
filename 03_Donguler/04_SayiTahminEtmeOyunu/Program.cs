// 3 hak verilen rakam tahmin etme uygulaması
int hak=3;
Random rastgele = new Random();
int number=rastgele.Next(10);
System.Console.Write("Rakamı tahmin ediniz: ");
while(hak!=0)
{
    int tahmin=Convert.ToInt32(Console.ReadLine());
    hak--;
    if (tahmin==number)
    {
        System.Console.Write("Tebrikler, Bildiniz.");
        break;
    }
    else if (number>tahmin)
    {
        System.Console.Write("Daha büyük bir sayı giriniz: ");
    }
    else
    {
        System.Console.Write("Daha küçük bir sayı giriniz: ");
    }
    if (hak==0)
    {
        System.Console.Write($"Mallesef hakkınız kalmadı. Sayı: {number}"); 
    } 
    
}



