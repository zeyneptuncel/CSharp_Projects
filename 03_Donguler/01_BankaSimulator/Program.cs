using System.Runtime.Intrinsics.Arm;

Console.WriteLine("-----Banka Uygulamasına Hoş Geldiniz-----");
int bakiye=5000;
while (true)
{
    Console.Write("1-Para Çek\n2-Para Yatır\n3-Bakiye Görüntüle\n4-Çıkış\nİşlem no giriniz: ");
    string secim=Console.ReadLine();
    if (secim=="1")
    {
        System.Console.WriteLine($"Bakiyeniz: {bakiye}. Çekmek istediğiniz tutarı giriniz.");
        int cek = Convert.ToInt32(Console.ReadLine());
        bakiye-=cek;
        System.Console.WriteLine($"İşlem tamamlandı. Mevcut bakiyeniz: {bakiye}");
    }
    if (secim=="2")
    {
        System.Console.WriteLine($"Bakiyeniz: {bakiye}. Yatırmak istediğiniz tutarı giriniz.");
        int ekle = Convert.ToInt32(Console.ReadLine());
        bakiye+=ekle;
        System.Console.WriteLine($"İşlem tamamlandı. Mevcut bakiyeniz: {bakiye}");
    }
    if (secim=="3")
    {
        System.Console.WriteLine($"Mevcut bakiyeniz: {bakiye}");
    }
    if (secim=="4")
    {
        System.Console.WriteLine("Çıkış Yapılıyor...");
        break;
    }

}


