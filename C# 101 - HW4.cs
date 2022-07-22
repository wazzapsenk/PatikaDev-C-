using System;
namespace hatayonetimi
{
    class Program
    {
        static void Main(string[] args)

        {  

            //string hatası
            try{
                Console.WriteLine("Bir sayı giriniz:");
                int sayi =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);

            }
            catch(Exception eas) 
            {
                Console.WriteLine(" Hata:" + eas.Message.ToString());


            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");

            } 
            
            //null=> int hatası
            //Parse : string ifadeleri int'e çevirir
            try
            {
                //int a=int.Parse(null); //ArgumentNullException  geçersiz girdi
                //int a=int.Parse("test"); //FormatException  biçim geçersiz
                int a=int.Parse("-20000000000"); //OverflowException  taşma ya da aralık dışında bir deger girildiğinde
                
            }
            catch (ArgumentNullException se)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(se);
                Console.WriteLine(se.Message);

            }
            catch(FormatException fe)
            {
                Console.WriteLine("veri tipi uygun değil");
                Console.WriteLine(fe);
            }
            catch(OverflowException of)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(of);
            }
            finally{

                Console.WriteLine("işlem başarıyla tammalandı!")
            }
            //sayıyı denetleyen bir sistem yok string çevrim var
            /*Console.WriteLine("Bir sayı giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);*/

        }

    }

}
