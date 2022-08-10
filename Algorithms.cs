using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Algoritmalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Çift sayıları yazdırma");
            Console.WriteLine("2. Bölme sorusu");
            Console.WriteLine("3. Sondan başa doğru liste yazdırma");
            Console.WriteLine("4. Cümledeki toplam kelime ve harf");
            
            Console.WriteLine("Görüntülemek istediğiniz soruyu seçiniz:");
            int secim = Convert.ToInt32(Console.ReadLine());
            questions soru = new questions();
            switch (secim)
            {
                case 1:
                    soru.IsEvenList();
                    break;
                case 2:
                    soru.dividingOrNot();
                    break;
                case 3:
                    soru.fromlasttofirst();
                    break;
                case 4:
                    soru.CounterOfWord();
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız.");
                    break;
            }
        }
    }

    class questions
    {
        public void IsEvenList()
        {
            Console.Write("Sayı Adedini Giriniz : ");
            string n = Console.ReadLine();
            List<int> sayilar = new List<int>();
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.Write((i+1)+". Sayıyı Giriniz : ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi % 2 == 0) sayilar.Add(sayi);
            }
            foreach(var m in sayilar)
            {
                Console.WriteLine(m);
            }
        }

        public void dividingOrNot()
        {
            Console.Write("Bölen değerini giriniz : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Sayı Adedini Giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<int> sayilar = new List<int>();

            for (int i=0; i<n;i++)
            {
                Console.Write((i+1) + ". Sayıyı Giriniz : ");
                int sayi = int.Parse(Console.ReadLine());
                if (m % sayi == 0) sayilar.Add(sayi);
            }
            foreach (var j in sayilar)
            {
                Console.WriteLine(j);
            }
        }

        public void fromlasttofirst()
        {
            Console.Write("Kelime Adedini Giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<string> kelimeler = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Sayi Giriniz : ");
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }
            /*
            foreach (var kelime in kelimeler)
            Console.WriteLine(kelime);
            Console.WriteLine(Array.Reverse(kelimeler));
            */

        }

        public void CounterOfWord()
        {
            Console.Write("Cümle veya kelime Giriniz : ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayisi : {0}",kelimeler.Count());
            Console.WriteLine("Harf Sayisi : {0}", cumle.Count());

        }
    }




}
