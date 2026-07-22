Console.Write("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());
int sonuc=1;
if (number>12)
{
    System.Console.WriteLine("Girdiğiniz sayının değeri integer sınırlarını aşmaktadır.");
}
else if(number>=0)
{
    if (number==0)
    {
        System.Console.WriteLine($"{number} sayısının faktoriyeli: 1");
    }
    else
    {
        for (int i = number; i > 1; i--)
        {
            sonuc = i * sonuc;
        }
        System.Console.WriteLine($"{number} sayısının faktoriyeli: {sonuc}");
    }
    
}
else
{
    System.Console.WriteLine("Girdiğiniz sayının faktöryeli tanımsızdır");
}
