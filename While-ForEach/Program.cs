// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//While
// 1 den başlayarak girilen sayıya kadar (sayı dahil) ortalama hesaplama
Console.Write("Lutfen bir sayi giriniz:");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam =0;

while (sayac <= sayi)
{
     toplam+=sayac;
     sayac++;
}
Console.WriteLine(toplam/sayi);


// a dan z ye kadar tüm harfleri consola yazdır.

char character = 'a';
while (character < 'z')
{
     Console.Write(character);
     character++;
}


//ForEach
string[] arabalar = {"BMW", "Ford", "Toyota","Nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}