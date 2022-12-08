using System;

namespace Koleksiyonlar_Soru_3
{

    class Program
    {

        static void Main(string[] args)
        {
            List<char> sesli = new List<char>();
            string cumle=Console.ReadLine();

            for(int i = 0; i < cumle.Length; i++)
            {
                if ((cumle[i] == 'a' || cumle[i] == 'A') || (cumle[i] == 'e' || cumle[i] == 'E') || (cumle[i] == 'ı' || cumle[i] == 'I') || (cumle[i] == 'i' || cumle[i] == 'İ') || (cumle[i] == 'o' || cumle[i] == 'O') || (cumle[i] == 'ö' || cumle[i] == 'Ö') || (cumle[i] == 'u' || cumle[i] == 'U') || (cumle[i] == 'ü' || cumle[i] == 'Ü'))
                    sesli.Add(cumle[i]);
            }

            sesli.Sort();
            sesli.ForEach(i => Console.Write(i + " "));

        }

    }

}