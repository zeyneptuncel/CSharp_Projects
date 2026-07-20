Console.Write("Adınızı Giriniz: ");
string isim = Console.ReadLine();
Console.Write("Soyadınızı Giriniz: ");
string soyisim = Console.ReadLine();
Console.Write("Yaşınızı Giriniz: ");
int yas =Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}. {yas} yaşındasınız");
Console.ReadKey();