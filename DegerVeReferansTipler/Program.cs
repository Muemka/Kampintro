using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int decimal float double bool = değer tiplerdir. stack türündedir.
            //array class interface = referans tipdir. heap türündedir.
            //stack türünde sayi1=sayi2 yapıldığında sayi1 in değeri sayi2 değerine eşitlenir ve sayi 2 ile bağlantı kesilir. sayi2 değişse bile sayi1 değişmez. sayi2 ye
            //yeni değer atandıktan sonra tekar sayi1 = sayi 2 yapman gerekir.
            //heap türünde sayilar1 =sayilar2 yapıldığından sonra sayilar2 değişirse sayilar1 de değişir. heap türünde sayilar1 = sayilar 2 yapıldığında sayilar 1 in adresi
            //sayilar2 ile aynı olur.

            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1 = 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);





            //sailar1[0] = 999
        }
    }
}
