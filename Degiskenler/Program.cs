// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int deger;
deger = 10;
string degisken = null;
string Degisken = null;

byte b = 5;  // 0 / 255 deger alabilir (1 byte)
sbyte c = -5; //  -128 / 127  deger  alabilir  (1 byte)

short s = 5; // -3276 / 3276 deger alabilir (2 byte) tam sayı
 
ushort us = 5; // 0 / 65535 deger alabilir (2 byte)

Int16 i16 = 2; // -32768 / 32767 deger alabilir (2 byte)

Int32 i32 = 2; //(4 byte)

Int64 i64 = 2 ; // (8 byte) 

int i = 5; // (4 byte)

uint ui = 5 ; // (4 byte)

long l = 5; //(8 byte)
ulong ul = 5; //(8 byte)

float f = 5; // (4byte) reel sayılar

double d = 5; // (8 byte)

char ch ='a'; // (2 byte)

string strf = "abfgdh"; // (8 byte) sınırsız uzunlukta karakter dizileri 

bool bo = true; 

bool bo2 = false; 

 
DateTime dt = DateTime.Now; // tarih ve saat bilgisi
Console.WriteLine(dt);

object o1 = "x"; // string
object o2 = 5; // int
object o3 = true; // bool
object o4 = DateTime.Now; // Datetime
 
//String
string str1 = string.Empty; // boş string
str1 = "Zikriye";
string ad = "Müzeyyen";
string soyad = "Yildiz";
string tamisim = ad + " " + soyad ; 

// Integer

int int1 = 6;
int int2 = 3;
int int3 = int1 * int2 ; 

//boolean

bool bo1 = 10 < 2;
bool bool2 = 10 > 2 ;


//Değişken dönüşümleri

string str20 = "20";
int int20 = 20;

string yeniDeger = int20.ToString()+ str20; // stringe cevirme 

Console.WriteLine(yeniDeger); // 2020 çıktısı verir


int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); // 40 çıktısı verir.

int int22 = int20 + int.Parse(str20);
Console.WriteLine(int22); // 40 çıktısı verir.


// DateTime 

string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(dateTime); // 23.12.2021 çıktısı verir.

string date_Time = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(date_Time); // 23/12/2021 çıktısı verir.


//Saat
string datehour = DateTime.Now.ToString("HH:mm:ss");
Console.WriteLine(datehour); // 14:55:28 çıktısı verir.