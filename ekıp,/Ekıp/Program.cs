using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.Serialization;

namespace Ekip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long a =Fıbonaccı(29);
           // Console.WriteLine(a);

          /*  int[] b = {12,312,41,414};
           int a  = Toplama(b,3);
           Console.WriteLine(a);*/
         /* int[] a = {35,53,3,6363,6,36,3};
          Dizi(a,2);*/

          /*  int[] a = {123}; 
          Tersten(a);
          
          foreach(var i in a)
          {
            Console.WriteLine(i);
          }*/
   /*int n = 4; // Burada istediğiniz satır numarasını belirleyin

        int[] result = Pascal(n);

        // Sonucu yazdır
        Console.WriteLine($"{n}. satır: {string.Join(", ", result)}");
            */

           /* AsalMı(2);*/

           /* int[] a = {12131,214,1212,4,51,51};
          int ortlama = Ortalama(a);
          Console.WriteLine(ortlama);*/

         /* SıfırYuzAsal(100);*/

            /*
            string aa2 = "3111111001";
            string aa3 = "3111101001";
            int a = Hamming(aa2,aa3);
            Console.WriteLine(a);*/

        /*  int a =  SeslıHarf("sAAAAiid");
          Console.WriteLine(a);*/
         
        }
        static long Fıbonaccı(long a = 30)
        {
            const long MaxValue = 30; // const ıle longun değerini 30 yapıyorum
            long oncekıSayı = 0;
            long suankıSayı = 1;
            long sonrakıSayı = 0;

            if(a > MaxValue) // girilen sayı max valuemden buyukse
            {
                Console.WriteLine("Belirlediğim Değerden Fazlasını Giremezsin");
                a = MaxValue; // a yı max value ye eşitlıyorum
            }
            if(a <= 1) // temel durumlar ıcın zaten ılk ıkı sayıs bellı
            {
                return a;
            }

            for(int i = 2; i <= a; i++ )
            {
                sonrakıSayı = oncekıSayı + suankıSayı;
                oncekıSayı = suankıSayı;
                suankıSayı = sonrakıSayı;

            }
            return sonrakıSayı;

        }

        // Verilen bir dizi için özyineli bir toplama fonksiyonu yazın.
        
        static int Toplama(int[] a , int index)
        {
            if(index == a.Length) // eğer  index dizinin boyutuna ulaşırsa ıslemı sonlandır
            {
                return (0);
            }
            
            return a[index] + Toplama(a , index + 1); // a nın mevcut dızısınde kı elemanı alır sonra kendini cagırıp a nın bır sonrkı indexini alır
        }

       // N elemanlı bir dizi için elemanları sırayla yazdıran özyineli bir metot yazın.

       static int Dizi(int[] a , int index)
       {

        if(index == a.Length) // eğer index dizinin boyutuna ulaşırsa bitiriyoruz
        {
            return (0);
        }
            Console.WriteLine(a[index]); // a nın o ankı indexinde ki elemanı yazdırıyoruz

           return Dizi(a,index +1); // sonra tekrar çağırıp bu sefer bır sonra kı elemana geçıyoruz
       }

        // Bir metot yazın, bir sayının tersini (ör. 123 -> 321) hesaplasın.

        static void Tersten(int a)
        {
           for(int i = 0; i < a; i++)
           {
            
           }
        }

        //Bir metot yazın, pascal üçgeninin n. satırını döndürsün.

        static int[] Pascal(int n)
        {
            int[] row = new int[n + 1];
            row[0] = 1; // ilk eleman bastan baslar

            for(int i = 1; i <= n; i++)
            {
                row[i] = row[i -1] * (n - i +1) /i;
            }
                return row;
        }

        //Bir sayının asal olup olmadığını kontrol eden bir metot yazın.

        static int AsalMı(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("Asal Değildir");
                return (0);
            }
            else
            {
                Console.WriteLine("Asaldır");
                return (1);
            }
        }

       // Bir metot yazın, verilen bir sayı dizisinin ortalamasını döndürsün.

       static int Ortalama(int[] a)
       {
        if(a.Length == 0)
        {
            Console.Write("Diziniz Boş");
            return (0);
        }
        int toplam = 0;
        for(int i = 0; i < a.Length; i++)
        {
            toplam += a[i];
        } 
        return toplam /= a.Length;  
       }

       // 0-100 arasındaki tüm asal sayıları bulan bir metot yazın.

        static void SıfırYuzAsal(int a)
        {
            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine($"Sırasıyla 0 dan 100 e Asal {i}");
                }
            }
        }

        // İki metin arasındaki Hamming mesafesini hesaplayan bir metot yazın.

        static int Hamming(string a1, string a2)
        {

            if(a1.Length != a2.Length) // uzunlukları aynı değilse
            {
                Console.WriteLine("Aynı Uzunlukta Gir!");
                return (0);
                
            }
            int fark = 0;
            for(int i = 0; i < a1.Length; i++)
            {
                if(a1[i] != a2[i]) // ıkısınıde ı nıncı elemanı bir birine eşit değilse kaç tane fark oldugu bulunur
                {
                    fark++; // eşit olmadıgı durumda buraya girer ve farkı arttır
                }   
            }
            return fark; // en sonda kaç tane fark oldugunu gormek ıcın farkı dondururuz
        }
        // Bir metot yazın, string içindeki sesli harfleri sayarak döndürsün.
        
        static int SeslıHarf(string a)
        {
            int sesliHarf = 0;
            if(String.IsNullOrEmpty(a))
            {
                Console.WriteLine("Boş Girmeyiniz");
                return (0);
            }
            else
            a = a.ToLower();
         {
             foreach(char sesli in a)
            {
                if(sesli == 'a' || sesli == 'e' || sesli == 'ı' || sesli == 'i' || sesli == 'u' ||sesli == 'ü' || sesli == 'o' || sesli == 'ö')
                {
                    sesliHarf++;
                }
               
            }
        }
            return sesliHarf;
        }

        //Verilen bir string içinde belirli bir karakterin kaç kez geçtiğini bulan bir metot yazın.

       static int  KaçKez (string a, char b)
       {
        int sayac = 0;
        if(String.IsNullOrEmpty(a))
        {
            return (0);
        }
        else
        {
            foreach(var i in a)
            {
                if(i == b)
                {
                    sayac++;
                }
            }
        }
        return sayac;
       }


    }
}