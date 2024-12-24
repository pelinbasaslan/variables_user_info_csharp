using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz.");
        Console.Write("TC Kimlik numarası:");
        //Herhangi bir matematiksel işlem yapılmayacağı için TC No, ad, soyad, telefon numarası için string veri tipi.
        string TCNo = Console.ReadLine();
        Console.Write("Adı:");
        string name = Console.ReadLine();
        Console.Write("Soyadı:");
        string surName = Console.ReadLine();
        Console.Write("Telefon numarası:");
        string strNo = Console.ReadLine();
        Console.Write("Yaşı:");
        //Yaş için bir matematiksel işlem yapılabileceği için örn ortalama yaş, 5'tan büyük yaş vs gibi int.
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("İlk aldığı ürünün fiyatı:");
        //Console.Readline() verileri string olarak sakladığı için ve ürün fiyatlarının matematiksel değerleri lazım olduğu için convertle doublea dönüştürdüm. Fiyatların ondalık olabileceği için int tercih etmedim. 
        double price = Convert.ToDouble(Console.ReadLine());
        Console.Write("İkinci aldığı ürünün fiyatı:");
        double price2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine($"{TCNo} TC Numaralı, {name} isimli kişi için kayıt oluşturulmuştur.");
        Console.WriteLine($"{strNo} telefon numarasına bildirim mesajı gönderilmiştir.");
        double sum = price + price2;
        double sumPerc = sum * 0.10;
        Console.WriteLine($"{sum} toplam karşılığı kazanılan %10 patika puan miktarı -> {sumPerc:F2}TL'dir");
    }
}
