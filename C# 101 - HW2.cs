// See https://aka.ms/new-console-template for more information
using System;
namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
    {
            Console.WriteLine("----Atama ve İşlemli Atama Operatörleri----");
            //Atama ve İşlemli atama
            //=, +=, -=, *=, /=
            int x=3;
            int y=3;
            y=y+2; //2eklenir çıktı 5 olur
            Console.WriteLine(y);
            y += 2; //son haline 2 eklenir çıktı 7 olur
            Console.WriteLine(y);
            y /=1;  //son hali 1e bölünür çıktı 7 olur
            Console.WriteLine(y);
            x *=2; //son hali 2ile çarpılır çıktı 6 olur
            Console.WriteLine(x);

            Console.WriteLine("----Mantıksal Operatörler----");

            //Matıksal Operatörler
            //&&, ||, !
            bool isSuccess=true;
            bool isCompleted=false;

            if(isSuccess && isCompleted )
                Console.WriteLine("Perfect!");
            if(isSuccess || isCompleted )
                Console.WriteLine("Great!");
            if(isSuccess && !isCompleted )
                Console.WriteLine("Fine!");

            Console.WriteLine("----İlişkisel Operatörler----");
            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=
            int a=3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc= a>b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc= a==b;
            Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("----Aritmetik Operatörler----");
            //Aritmetik Operatörler
            // +,*,/,-
            int c=5;
            int d=10;
            float sonuc1;
            sonuc1=c/d;
            Console.WriteLine(sonuc1);
            sonuc1=d/c;
            Console.WriteLine(sonuc1);
            sonuc1=c+d;
            Console.WriteLine(sonuc1);
            sonuc1=c*d;
            Console.WriteLine(sonuc1);
            sonuc1=c-d;
            Console.WriteLine(sonuc1);
            sonuc1=c++;
            Console.WriteLine(C++);

            // % işareti mod alır
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);

    }
    }
}
