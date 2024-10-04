var sehirler = new List<string>() //liste tanımı
{
    "Ankara" ,"istanbul", "Samsun", "Mardin", "Antalya"
};
/*foreach (string s in sehirler)
{
    Console.WriteLine(s); //girilen tüm şehirleri console yazdırır.
} */

//Lambda Expression =>
sehirler.ForEach(s => Console.WriteLine(s));

var iller = sehirler; //örtürülü değişken 
iller.ForEach(i => Console.WriteLine(i));

sehirler.Add("Sinop"); //şehirlere yeni liste elemanı ekleme
sehirler.ForEach(s => Console.WriteLine(s));
Console.WriteLine();
iller.ForEach(i => Console.WriteLine(i));

iller.Remove("Ankara");
iller.ForEach(i => Console.WriteLine(i));

Console.WriteLine();
sehirler.ForEach(s => Console.WriteLine(s));



Console.ReadKey();