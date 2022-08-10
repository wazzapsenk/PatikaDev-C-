using System;
namespace metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";
            

            bool sonuc= int.TryParse(sayi,out int outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else{
                Console.WriteLine("Başarısız!");
            }

            //toplam fonksiyonu
            Metotlar instance =new Metotlar();
            instance.Topla(4,5,out int ToplamSonuc);
            Console.WriteLine(ToplamSonuc);
            
            //Metot Aşırı Yükleme--Overloading
            int ifade=999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Kaan","Şahin");
            //Metot İmzası
            //metotAdı+ParametreSayısı+Parametre
        }
    }
    class Metotlar
    {
        //toplam fonksiyonu
        public void Topla(int a,int b,out int toplam)
        {
            toplam=a+b;
        }
        //Metot Aşırı Yükleme--Overloading
        public void EkranaYazdir( string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir( int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir( string veri1,string veri2)
        {
            Console.WriteLine(veri1 + " " +veri2);
        }
    }
}
