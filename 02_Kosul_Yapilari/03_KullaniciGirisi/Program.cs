string k_adi = "admin";
string sifre = "12345";
Console.Write("Kullanıcı adınızı giriniz: ");
string k= Console.ReadLine();
Console.Write("Şifrenizi giriniz: ");
string s= Console.ReadLine();

if (k_adi==k && sifre==s)
{
    Console.WriteLine("Giriş Başarılı");
}
else if (k_adi==k && sifre!=s)
{
    Console.WriteLine("Şifre yanlış.\nGiriş Yapılamadı.");
}
else
{
    Console.WriteLine("Hata! Kullanıcı adı veya şifre yanlış.");
}