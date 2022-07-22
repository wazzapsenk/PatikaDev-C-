using System;
namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatikaDev Eğitiminde Yapılan uygulama
            /* int time=DateTime.Now.Hour; //o anki saati alır
            if(time>=6 && time <11)
                Console.WriteLine("Günaydın Aşko");
            else if(time<=18)
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi Akşamlar");

            string sonuc= time<=18 ? "İyi Günler" : "İyi Gecelera";
            sonuc=time>=6 && 11<11 ? "Günaydın" : time<=18 ? "İyi günler" : "İyi Gecelers"; //&&:ve ||:veya
            Console.WriteLine(sonuc);
            */
            //Deneme Projem
            Console.WriteLine("Şu anki saati tahmin et:");
            int time=Convert.ToSByte(DateTime.Now.Hour);
            int girdi;
            girdi=Convert.ToInt32(Console.ReadLine()) ;
            int fark;
            fark=girdi-time;
                        
            if(girdi<time && girdi<25 && girdi>0)
            Console.WriteLine(fark+" Saat geçmiş. Yarın görüşürüz..." );
            else if(girdi>time && girdi<25 && girdi>0)
            Console.WriteLine("Halen vakit var...Hatta " + fark + " saat var");
            else if(girdi==time)
            Console.WriteLine("Tam zamanı dostum");
            else
            Console.WriteLine("Paralel evrende " + fark + " saat ileridesin. Orada günler kaç saat?");

        }
    }

}
