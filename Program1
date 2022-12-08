using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{

    class Program
    {

        public static bool asalMi(int sayi)
        {
            bool cevap=true;

            if (sayi == 0 || sayi==1)
                cevap=false;
            else if (sayi == 2)
                cevap=true;
            else
            {
                
                for(int i=2; i<=(sayi/2)+1; i++)
                {
                    if (sayi % i == 0)
                    {
                        cevap=false;
                        break;
                    }
                }

            }

            return cevap;
        }

        public static int Toplam(ArrayList dizi)
        {
            int sum = 0;

            foreach (int i in dizi)
                sum += i;

            return sum;
        }

        public static double Ortalama(ArrayList dizi)
        {
            double ort=(Double)Toplam(dizi)/(Double)dizi.Count;

            return ort;
        }

        static void Main(string[] args)
        {

            ArrayList asal = new ArrayList();
            ArrayList degil = new ArrayList();
            int sayi;

            for(int i=0; i<20; i++)
            {
                Console.Write("Lütfen 0 veya 0'dan büyük bir sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (sayi < 0)
                {
                    Console.WriteLine("Hatalı Giriş!\n");
                    continue;
                }
                else if (asalMi(sayi))
                    asal.Add(sayi);
                else
                    degil.Add(sayi);

            }
            Console.WriteLine("\n");

            asal.Sort();
            Console.WriteLine("Asal Sayılar:");
            foreach(var i in asal)
                Console.Write(i + " ");

            Console.WriteLine("\n");

            degil.Sort();
            Console.WriteLine("Asal Olmayan Sayılar:");
            foreach (var i in degil)
                Console.Write(i + " ");

            Console.WriteLine("\n");

            Console.WriteLine("Asal Sayılar Dizisinin Uzunluğu = "+asal.Count);
            Console.WriteLine("Asal Olmayan Sayılar Dizisinin Uzunluğu = " + degil.Count);

            Console.WriteLine("\n");

            Console.WriteLine("Asal Sayılar Dizisinin Ortalaması = "+Ortalama(asal));
            Console.WriteLine("Asal Olmayan Sayılar Dizisinin Ortalaması = " + Ortalama(degil));

        }

    }

}
