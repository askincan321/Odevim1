using System;

namespace Odevim1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Pc1 = new Urun();
            Pc1.urunAdi = "Dell";
            Pc1.urunGpu = "RTX 3080";
            Pc1.urunFiyati = 12300;


            Urun Pc2 = new Urun();
            Pc2.urunAdi = "HP";
            Pc2.urunGpu = "RTX 3050";
            Pc2.urunFiyati = 7800;


            Urun Pc3 = new Urun();
            Pc3.urunAdi = "Lenovo";
            Pc3.urunGpu = "RTX 3060";
            Pc3.urunFiyati = 9000;


            Urun Pc4 = new Urun();
            Pc4.urunAdi = "MacBook Pro";
            Pc4.urunGpu = "Intel Irıs";
            Pc4.urunFiyati = 20400;


            Urun[] Pcler = new Urun[] { Pc1, Pc2, Pc3, Pc4 };

            foreach (var Urun in Pcler)
            {
                Console.WriteLine("Urun Adı :" + Urun.urunAdi + " " + "urunGpu:" + Urun.urunGpu + "urunFiyati:" + Urun.urunFiyati);
            }

            Console.WriteLine("");
            Console.WriteLine("");



            for (int i = 0; i < Pcler.Length; i++)
            {
                Console.WriteLine("Urun Adı:" +Pcler[1].urunAdi+""+"Urun Gpu:"+Pcler[1].urunGpu+""+"Urun Fiyatı:"+Pcler[1].urunFiyati);
            }
            Console.WriteLine("");
            Console.WriteLine("");



            int a = 0;
            while (a<Pcler.Length)
            {
                Console.WriteLine("Urun Adi:" + Pcler[a].urunAdi+ ""+"Urun Gpu:"+Pcler[1].urunGpu+""+"Urun Fiyati:"+Pcler[1].urunFiyati);
                a++;
            }









        }

        class Urun
        {
            public string urunAdi { get; set; }
            public string urunGpu { get; set; }
            public int urunFiyati { get; set; }

        }
    }
}
