Console.Write("Vize notunuzu giriniz: ");
double vize = Convert.ToInt32(Console.ReadLine());
Console.Write("Final notunuzu giriniz: ");
double final = Convert.ToInt32(Console.ReadLine());
Console.Write("Geçme notunuzu giriniz: ");
double gnot = Convert.ToInt32(Console.ReadLine());
double not = (vize*0.6) + (final*0.4);

if (not>=gnot)
{
    Console.WriteLine($"Tebrikler, dersi geçtiniz. Notunuz: {not}");
}
else
{
   Console.WriteLine($"Maalesef dersten kaldınız. Notunuz: {not}"); 
}