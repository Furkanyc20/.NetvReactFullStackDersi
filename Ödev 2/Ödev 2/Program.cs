//1- For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.

/*
Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;

for (int temp = Math.Abs(sayi); temp > 0; temp /= 10)
{
    toplam += temp % 10; // Son basamağı al ve toplama ekle
}

Console.WriteLine($"Girilen sayının rakamları toplamı: {toplam}");
*/

//2-while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu aralık dışında girerse tekrar iste.)


/*
Console.WriteLine("10 ile 100 arasında bir değer giriniz:"); int number = Convert.ToInt32(Console.ReadLine());
int min = 10, max = 100;
if (number >= min && number <= max)
{
    while (number >= min && number <= max)
    {
        Console.WriteLine($"Girilen deger {number}");
        break;
    }
}
else
{
    Console.WriteLine("Aralik Disi tekrar girinz");
}
*/

//3-foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.( 0-12: Çocuk, 13-19: Genç, 20-64: Yetişkin, 65+: Yaşlı.)

/*
int[] yaslar = { 0, 12, 25, 70, 12, 18, 45, 65 };
Console.WriteLine("Yas Kategorileri:");
foreach (int yas in yaslar)
{
    string kategori;
    if (yas >= 0 && yas <= 12)
    {
        kategori = "Cocuk";
    }
    else if (yas >= 13 && yas <= 19)
    {
        kategori = "Genc";
    }
    else if (yas >= 20 && yas <= 64)
    {
        kategori = "Yetiskin";
    }
    else
    {
        kategori = "Yasli";
    }
    Console.WriteLine($"Yas: {yas}  Kategori: {kategori}");
}
    
*/

//4-Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.

/*
int a,sayac = 0, f, u, r, k;
Console.WriteLine("Dizinin elemean sayisini girin:");
a = Int16.Parse(Console.ReadLine());
int[] dizi = new int[a];
Console.WriteLine("Dizinin elamanlarini girin:");
for(f = 0; f < a; f++)
{
    dizi[f] = Int16.Parse(Console.ReadLine());
}
for(u = 0; u < a; u++)
{
    for (r = 0; r < a; r++)
    {
        if (dizi[u] == dizi[r])
        {
            for(k = 0; k < u; k++)
            {
                if (dizi[k] == dizi[u]) ;
                sayac = -1;
            }
            sayac++;
        }
    }
    if(sayac != 0)
    {
        Console.WriteLine(dizi[u] + " sayisi " + sayac + " kez tekrar edildi");
    }
    sayac = 0;
}
*/

//5-Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.

/*
string[] kelimeler = { "elma", "armut", "cilek", "kavun", "karpuz", "kiraz" };
if (kelimeler.Length == 0)
{
    Console.WriteLine("Dizi boş.");
    return;
}
string enKisa = kelimeler[0];
string enUzun = kelimeler[0];
foreach (string kelime in kelimeler)
{
    if (kelime.Length < enKisa.Length)
    {
        enKisa = kelime;
    }
    if (kelime.Length > enUzun.Length)
    {
        enUzun = kelime;
    }
}
Console.WriteLine($"En kısa kelime: {enKisa} ({enKisa.Length} harf)");
Console.WriteLine($"En uzun kelime: {enUzun} ({enUzun.Length} harf)");
*/

//6-Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.

/*
string[] kelimeler = new string[4];
for(int i = 0; i < kelimeler.Length; i++)
{
    Console.WriteLine("Cunleler dizisinin "+ (i + 1)+ ".index değerini giriniz:");
    kelimeler[i] = Console.ReadLine();
}
Array.Sort(kelimeler, StringComparer.CurrentCultureIgnoreCase);
Console.WriteLine("\nAlfabetik sıralanmış cümleler:");
foreach (var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}
*/

//7-Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.

/*
using System;
class DynamicString
{
    private char[] _chars;
    private int _count;
    public DynamicString(int capacity = 16) 
    {
        _chars = new char[capacity];
        _count = 0;
    }
    private void ExpandCapacity()
    {
        int newCapacity = _chars.Length * 2;
        char[] newArray = new char[newCapacity];
        Array.Copy(_chars, newArray, _count);
        _chars = newArray;
    }
    public void Append(char c)
    {
        if (_count == _chars.Length)
        {
            ExpandCapacity();
        }
        _chars[_count] = c;
        _count++;
    }
    public void Append(string str)
    {
        foreach (char c in str)
        {
            Append(c);
        }
    }
    public override string ToString()
    {
        return new string(_chars, 0, _count); 
    }
    public int Length => _count; 
}
class Program
{
    static void Main()
    {
        DynamicString dynStr = new DynamicString();
        dynStr.Append("Merhaba, ");
        dynStr.Append("Dünya!");
        dynStr.Append(' ');
        Console.WriteLine(dynStr.ToString()); 
        Console.WriteLine("Uzunluk: " + dynStr.Length);
    }
}
*/

//8-Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.

/*
List<string> kelimeler = new List<string>();
Console.WriteLine("Eklemek istediginiz Kelimeyi giriniz (Programdan cikmak icin exit yazin)");
while (true)
{
  Console.WriteLine("Eklemek istediginiz Kelimeyi giriniz:"); 
  string kelime = Console.ReadLine();

    if (kelime.ToLower() == "exit") {
        break;
    }
    kelimeler.Add(kelime);
}
Console.WriteLine("\nGirilen kelimelerin ters sirali hali:");
kelimeler.Reverse();
foreach (string k in kelimeler)
{
    Console.WriteLine(k);
}
*/

//9-Kullanıcıdan ratgele sayılar alıp listeye ekleyen, bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

/*
List<int> sayilar = new List<int>();
Console.WriteLine("Rastgele sayi giriniz(Programdan cikmak icin 0 yazin)");
while (true)
{
    Console.WriteLine("Sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 0) {
        break;
    }
    sayilar.Add(sayi);
}
if (sayilar.Count > 0)
{
    double ortalama = sayilar.Average();
    sayilar.Sort();

    Console.WriteLine("\nGirilen sayılar (küçükten büyüğe sıralı):");
    sayilar.ForEach(s => Console.Write(s + " "));

    Console.WriteLine($"\nSayıların Ortalaması: {ortalama:F2}");
}
else
{
    Console.WriteLine("Hiç sayi girilmedi.");
}
*/

//10-Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.

/*
List<int> sayilar = new List<int> { 2, 5, 7, 11, 17, 19 };
sayilar = sayilar.Where(sayi => sayi >= 10).ToList();
Console.WriteLine("Filtrelenmis Liste:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
*/

//11-Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

/*
List<int> notlar = new List<int> { 2, 5, 7, 20, 60, 75, 50 };
for (int i = 0; i < notlar.Count; i++)
{
    if (notlar[i] < 50)
    {
        notlar[i] = 50;
    }
}
Console.WriteLine("Guncellenmis Notlar: " + string.Join(", ", notlar));
*/