using System;
namespace dongu_whileforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Döngüsü
            //1den başlayarak consoledan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            Console.WriteLine("Bir sayı girin:");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int total=0;
            while (sayac<=sayi)
            {
                total += sayac;
                sayac++;
            }
            Console.WriteLine("Girdiğiniz sayı:" + sayi);
            Console.WriteLine("Ortalama:" + total/sayi);

            //a'dan z'ye kadar tüm harfler
            char character='a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }
            //foreach döngüsü
            Console.WriteLine("----ForEach----");
            string[] arabalar={"BMW","Porsche","Toyota","Togg","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }








        }
    }
} 
