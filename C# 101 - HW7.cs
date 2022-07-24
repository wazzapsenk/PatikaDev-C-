using System;
namespace fordongu
    {
    class Program
    {
        static void Main(string[] args)
        {
            
            //ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
            Console.WriteLine("bir sayı giriniz:");
            //sayaç tanımlanır
            int sayac =int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if(i%2==1) //tek sayı için mod 2si alınır mod 2yken kalan 1 olduğu belirtilir
                Console.WriteLine(i);
            }
            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam=0;
            int ciftToplam=0;
            for (int i = 1; i < 1000; i++)
            {
                if(i%2==1)
                tekToplam += i; //tektoplam=tektoplam+i; de yazılabilir
                else
                ciftToplam += i; //ciftToplam=ciftToplam+i;
            }
            Console.WriteLine("Tek Toplam:" + tekToplam);
            Console.WriteLine("Çift Toplam:" + ciftToplam);

            //break; continue;
            //break;
            for (int i = 1; i < 10; i++) //10 a kadar saymasini soyledik
            {
                if(i==4)
                break; //donguden cikarir. yani 4te dongu durur
                Console.WriteLine(i);
            }
            //continue;
            for (int i = 1; i < 10; i++) //10 a kadar saymasini soyledik
            {
                if(i==4)
                continue; //iterasyonu atlar. yani 4ü yazmaz  devam eder
                Console.WriteLine(i);
            }
       //hackerrank day 5
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int gain;
        for (int i=1;i<=10;i++){
        gain= n * i;
        Console.WriteLine("Solve:" + gain);
        }

        
        {
        int a = Convert.ToInt32(Console.ReadLine().Trim());
        int answer;
        for (int i=1;i<=10;i++)
        {
           answer= a * i;
        Console.WriteLine( a + " x " + i + " = " + answer);
        }
    }
    //hackerrank staircase
            int c = Convert.ToInt32(Console.ReadLine().Trim());
            for (int k = c - 1; k >= 0; k--)
            {
            for(int j = 0; j < c; j++)
            {
                if(j >= k)
                {
                Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
            }
        }
}
}
