using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //do not repeat yourself
            
            string katagoriEtiketi = "katagoriler";  //string yazı
            int ogrencisayısı = 320000000;          //int tam sayı
            double faizoranı = 1.45;                //double küsürlü sayı
            bool sistemeGirisYapmışMı = true;      //şart değişkeni
            double dolardun = 7.55;
            double dolarbugun = 7.55;

            if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalış butonu");
            }

            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artış butonu");
            }

            else
            {
                Console.WriteLine("değişmedi butonu");
            }

            if (sistemeGirisYapmışMı==true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(katagoriEtiketi);


        }
    }
}
