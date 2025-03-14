

// 2.Soru

/*
Console.WriteLine("Tek mi ? Çift mi ? karşılaştrımak için sayı giriniz:");
int numaber = Convert.ToInt32(Console.ReadLine());

if (numaber % 2 == 0)
{
    Console.WriteLine("Çiftir.");
}
else
{
    Console.WriteLine("Tektir.");
}
*/

// 3.Soru

Console.WriteLine("Pozitif mi? Negatif mi ? karşılaştrımak için sayı giriniz:");
int numaber = Convert.ToInt32(Console.ReadLine());

if (numaber > 0)
{
    Console.WriteLine("Pozitiftir.");
}
else if(numaber < 00)
{
    Console.WriteLine("Negatiftir.");
}
else 
{
    Console.WriteLine("Sıfırdır.");
}