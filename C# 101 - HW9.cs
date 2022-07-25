using System;
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler=new string[5]; //renkler dizisi tanımlanır=eleman sayısı belirtilir

            string[] hayvanlar={"kedi","köpek","kuş","yunus"}; //hayvanlar dizisi tanımlanır=elemanları belirtilir

            int[] dizi; //dizi tanımlanır
            dizi=new int[5];  //dizi dizisinin eleman sayısı belirtilir
            
            // dizilere değer atama
            renkler[0]="Mavi"; //renkler dizisi 0.index(1.elemana) Mavi ataması yapılır
            dizi[3]=10; //dizi dizisinin 3.indexine(4.elemanına) 10 ataması yapılır
            
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // döngülerle dizi kullanımı
            // klavyeden girilen n tane sayının ortalaması
            Console.WriteLine("Eleman Sayısını Giriniz:");
            int n=int.Parse(Console.ReadLine()); //n=dizi uzunluğu eleman sayısı
            int[] sayiDizisi=new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. elemanı giriniz:", i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
                
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            
            
            Console.WriteLine("Ortalama:" + toplam/n);

            //Hackerrank PlusMinus

             {
        double positive=0;
        double negative=0;
        double neutral=0;
        int length=arr.Count;
        
        foreach(int num in arr)
        {
            if(num>0)
            {
                positive++;
            }
            else if(num<0)
            {
                negative++;
            }
            else{
                neutral++;
            }
        }

        Console.WriteLine(positive/length);
        Console.WriteLine(negative/length);
        Console.WriteLine(neutral/length);

    }
        }
    }
}
