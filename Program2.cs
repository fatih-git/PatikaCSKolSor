using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{

    class Program
    {

        public static int Toplam(int[] dizi)
        {
            int sum = 0;

            foreach (int i in dizi)
                sum += i;

            return sum;
        }

        public static double Ortalama(int[] dizi)
        {
            double ort = (Double)Toplam(dizi) / (Double)dizi.Length;

            return ort;
        }

        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            int[] buyuk = new int[3];
            int[] kucuk = new int[3];
            short control;

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("Bir değer giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");

            Array.Sort(dizi);
            for(int i = 0; i < kucuk.Length; i++)
                kucuk[i] = dizi[i];

            control = 0;
            for(int i = 0; i < buyuk.Length; i++)
            {
                buyuk[i] = dizi[dizi.Length-1-i];
                control++;
            }

            Console.WriteLine("\n");

            Console.WriteLine("En Küçük 3 Sayının Ortalaması = " + Ortalama(kucuk));
            Console.WriteLine("En Büyük 3 Sayının Ortalaması = " + Ortalama(buyuk));
            Console.WriteLine("Ortalamalar Toplamı = " + (Ortalama(kucuk)+Ortalama(buyuk)));

        }

    }

}
