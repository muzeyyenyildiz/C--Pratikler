// See https://aka.ms/new-console-template for more information

// try
// {
//     Console.WriteLine("Bir sayi giriniz:");
//     int sayi = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Girmiş olduğunuz sayi:" + sayi);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Hata:"+ ex.Message.ToString());
// }
// finally
// {
//     Console.Write("İşlem Tamamlandı!");
// }


try
{
    // int a = int.Parse(null);
    //int a = int.Parse("Test");
    int a = int.Parse("-25555549564");
}
catch (ArgumentNullException ex)
{
   Console.WriteLine("Boş deger girdiniz.");
   Console.WriteLine(ex);

}
catch (FormatException ex)
{
   Console.WriteLine("Veri tipi uygun değil");
   Console.WriteLine(ex);
}
catch (OverflowException ex)
{
   Console.WriteLine("Çok küçük ya da çok büyük bir sayı girdiniz.");
   Console.WriteLine(ex);
}
finally
{
    Console.Write("İşlem başarıyla tamamlandı!");
}