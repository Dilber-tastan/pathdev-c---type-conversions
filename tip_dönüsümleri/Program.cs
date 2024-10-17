using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_dönüsümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion ( bilinçsiz dönüşüm )
            byte a = 5;
            sbyte b= 10;
            short c = 30;
            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);


            float i = h;
            Console.WriteLine(i);


            string e = "dilber";
            char f = 'a';
            object g = e + f + d;
            Console.WriteLine(g);


            // explicit conversion(bilinçli dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte u = (byte)z;
            Console.WriteLine("u:"+z);

            float w = 10.3f;
            byte  k=(byte)w;
            Console.WriteLine("k:" + k);
            //-------------------------------------
            // tostring metodu 
            int xx = 4;
            string yy =xx.ToString();
            Console.WriteLine("yy:"+xx);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);
            //-----------------------------------------
            //system.convert
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);






            Console.Read();
        }
    }
}
