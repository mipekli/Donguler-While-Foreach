//while
// 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
Console.WriteLine("Lütfen Bir Sayı Giriniz:");
int sayi = Int32.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;
}
Console.WriteLine(toplam / sayi);

// 'a' dan 'z' ye kadar tüm harfleri console a yazdır.
char character = 'a';
while (character < 'z')
{
    Console.WriteLine(character);
    character++;
}

Console.WriteLine("****foreach****");
string[] arabalar = { "BMW", "FORD", "MERCEDES","MAZDA" };

foreach (var araba in arabalar)
{
    Console.Write(araba);
}