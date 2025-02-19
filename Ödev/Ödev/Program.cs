// Veri Tipleri ve If-Else Yapıları

/*
 -string Veri Tipi-

string Urun = "Dell G15";
Console.WriteLine($"{Urun} fiyati:47.000TL");
Console.WriteLine($"{Urun} ağırlığı:2,65kg");
Console.WriteLine($"{Urun} hafızası:1TB");
Console.WriteLine($"{Urun} monitor Hz:166Hz");

*/

/*
 -int Veri Tipi-

int sayı1 = 10;
int sayı2 = 11;
//int sayı2 = 9;
//int sayı2 = 10;

if (sayı1 < sayı2)
 {
    Console.WriteLine(sayı2 + " Buyuktur "+ sayı1 +"'dan" );
 }
 else if(sayı1 > sayı2)
 {
   Console.WriteLine(sayı1 + " Buyuktur "+ sayı2+"'dan");
  }
 else
 {
  Console.WriteLine("Sayilar esittir");
 }

*/

/*
 -long Veri Tipi-

long tas = 201203;
long idealtas = 300000;
//ong idealtas = 200203;
//long idealtas = 201203;

if(tas < idealtas)
{
    Console.WriteLine("Yetersiz gramaj istenilen kilo: "+ idealtas);

}
else if (tas > idealtas)
{
    Console.WriteLine("İstenilenden fazladır");
}
else
{
    Console.WriteLine("İstenilen tas kilosu");
}

*/

/*
-byte Veri Tipi-

byte  sayı1 = 170;
byte sayı2 = 190;
//byte sayı2 = 150;
//byte sayı2 = 170;

if (sayı1 < sayı2)
{
    Console.WriteLine(sayı2 + " Buyuktur");
}
else if (sayı1 > sayı2)
{
    Console.WriteLine(sayı1 + " Buyuktur");
}
else
{
    Console.WriteLine("Sayilar esittir");
}

*/

/*
 -short Veri Tipi-

short a = 12;
short c = 10;
//short c = 13;
//short c = 12;

if (a > c ) 
{
    Console.WriteLine(a +" Buyuktur");
}
else if (a < c)
{
    Console.WriteLine(c +" Buyuktur");
}
else
{
    Console.WriteLine("Eşitler");
}

*/

/*
-double Veri Tipi-

double g = 320.148;
double f = 450.145;
//double f = 200.201;
//double f = 320.148;

if (g < f)
{
    Console.WriteLine(f + " Buyuktur");
}
else if (g > f)
{
    Console.WriteLine(g + " Buyuktur");
}
else
{
    Console.WriteLine("Sayilar esittir");
}

*/

/*
-float Veri Tipi-

float idealpamuk = 0.900f;
float pamuk = 0.700f;
//float pamuk =  1f;
//float pamuk = 0.900f;

if ( pamuk < idealpamuk )
{
    Console.WriteLine("Yetersiz gram\nistenilen gram:" + idealpamuk);
}
else if ( pamuk > idealpamuk )
{
    Console.WriteLine("Fazla gram\nİstenilen gram:" + idealpamuk);
}
else
{
    Console.WriteLine("İstenilen Gramdir");
}

*/

/*
-decinal Veri Tipi-

decimal  d = 12.34m; 
decimal  e = 22.3M; 
//decimal e = 12.3m;
//decimal e = 21.34m ;

if ( d < e )
{
  Console.WriteLine(e + " Buyuktur");
}
else if ( d > e )
{
    Console.WriteLine( d+ " Buyuktur");
}
else
{
    Console.WriteLine("Esittir");
}

*/