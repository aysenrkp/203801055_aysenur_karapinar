using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203801055_aysenur_karapinar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++) ;
            {
                Console.Write("{0}.Sayıyı Giriniz", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(sayilar);
            Console.WriteLine();
            Console.Write("Sayıları Küçükten Büyüğe Sıralama=");
            for (int i = 0; i < 5; i++) ;
            {
                Console.Write(sayilar[ i ] + " ");
            }
            Console.WriteLine();
            Console.Write( " Sayıları Büyükten Küçüğe Sıralama= ");
            Array.Reverse(sayilar);
            for (int i = 0; i < 5; i++) ;
            {
                Console.WriteLine(sayilar[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
