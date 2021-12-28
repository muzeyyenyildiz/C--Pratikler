// See https://aka.ms/new-console-template for more information
// Girilen sayıya kadar olan tek sayıları ekrana yazdır
Console.WriteLine("Bir Sayi Giriniz:");
int sayac = int.Parse( Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}

// 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplanlarını consola yazdır.
int tekToplam = 0;
int ciftToplam = 0;

for (int i = 0; i <= 1000; i++)
{
    if (i % 2 == 1){
        tekToplam += i;
    }
    else{
        ciftToplam += i;
    }
}

Console.WriteLine("Tek Toplam:"+ tekToplam);
Console.WriteLine("Çift Toplam:"+ ciftToplam);

// break (döngüyü durdurmak) and continue (mevcut döngünün o şartını atlamak ve sonraki şarta geçmesini sağlar)

for (int i = 0; i < 10; i++)
{
    if (i == 4){
        break;
    }
    Console.WriteLine(i);
}
//Çıktısı  0 1 2 3 

for (int i = 0; i < 10; i++)
{
    if (i == 4){
        continue;
    }
    Console.WriteLine(i);
}
// Çıktısı 0 1 2 3 5 6 7 8 9 