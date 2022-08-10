using System;
namespace metotlar3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli
            //3^4=3*3*3*3
            int sonuc=1;
            for(int i=1;i<5;i++)
            sonuc=sonuc*3;
            Console.WriteLine(sonuc);
            Islemler instance=new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar
            string ifade="Kaan Şahin";
            bool result=ifade.BoslukKontrol();
            Console.WriteLine(result);

            if(result)
                Console.WriteLine(ifade.BoslukDegistir());

            Console.WriteLine(ifade.BuyukHarf());
            Console.WriteLine(ifade.KucukHarf());

            int[] dizi={4, 5, 6, 7,0,3};
            dizi.diziSirala();
            dizi.EkranaYazdir();

            int sayi=5;
            Console.WriteLine(sayi.CiftSayi());
            
            Console.WriteLine(ifade.GetFirstChar());

        }
    }
    public class Islemler
    {
        //Rekürsif - Öz yinelemeli
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
            return sayi;
            return Expo(sayi,üs-1)*sayi;
        //Expo(3,4)
        //Expo(3,3)*3;
        //Expo(3,2)*3*3;
        //Expo(3,1)*3*3*3;
        //3*3*3*3=3^4;
        }



    }
            //Extension Metotlar
        public static class Extension
        {
            public static bool BoslukKontrol(this string param) //this ifadesi olursa fonksiyon değil extension olur
            {
                return param.Contains(" "); //param.contains : sayar
            }
            public static string BoslukDegistir(this string param)
            {
                string[] dizi=param.Split(" ");//param.Split : birleştir 
                return string.Join("",dizi); //string.join : degistir
            }
            public static string BuyukHarf(this string param)
            {
                return param.ToUpper();//param.ToUpper büyük harfe dönüştürür
            }
            public static string KucukHarf(this string param)
            {
                return param.ToLower();//param.ToUpper büyük harfe dönüştürür
            }
            public static int[] diziSirala(this int[] param)
            {
                Array.Sort(param);
                return param;
            }
            public static void EkranaYazdir(this int[] param)
            {
                foreach (int item in param)
                {
                    Console.WriteLine(item);
                }
            }
            public static bool CiftSayi(this int param)
            {
                return param%2==0;
            }

            public static string GetFirstChar(this string param)
            {
                return param.Substring(0,1); //0.indexten 1sonraki karaktere kadar getir
            }
            
        }
}
