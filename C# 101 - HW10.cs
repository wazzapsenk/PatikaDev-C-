using System;
namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
        //erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/arguman)
        //{
        //komutlar;
        //return;
        //}
        //erisim_belirteci nereden çağrılacağını belirtir
        //geri donus tipi
        //metot_adi process adımlarını belirten isimler olabilir kod içeriğini işleyişini anlamamızda yardımcı
        //parametre listesi kullanılacak elemanlar argümanlar
        
        int a=3;
        int b=2;
        Console.WriteLine("Sonuç1:"+(a+b));
        int sonuc=Topla(a,b);
        Console.WriteLine("sonuç1:"+ sonuc);

        Metotlar ornek=new Metotlar();
        ornek.EkranaYazdir(Convert.ToString("sonuç1:"+ sonuc));

        int sonuc2=ornek.ArttırveTopla(ref a,ref b);
        ornek.EkranaYazdir(Convert.ToString("sonuç2:"+ sonuc2));
        ornek.EkranaYazdir(Convert.ToString("sonuc2:"+ (a+b)));
        
        }
        static int Topla(int deger1, int deger2)
        {
            return(deger1 + deger2);
        }
        
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri) //public her yerden erişilebilmesini sağlar
        //private olsaydi sadece aynı class'da çağrılabilirdi 
        {
            Console.WriteLine(veri);
        }
        public int ArttırveTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
