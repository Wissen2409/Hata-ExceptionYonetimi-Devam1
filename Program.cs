
try
{

    Console.WriteLine("1. sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    int sonuc = sayi1/sayi2;
}
catch (Exception e)
{

// exceptionların sebeplerini ekrana yazdıralım 

// e. message ile hata mesajının kendine ulaşabiliriz.

Console.WriteLine("Message : "+e.Message);
// e üzerinden bir çok detaya daha ulaşılabilif
// örnek hatanın olduğu kod satırını bile hata mesajı üzeirnden ulaşabilirsiniz
Console.WriteLine("Stack Trace: "+e.StackTrace);

}
