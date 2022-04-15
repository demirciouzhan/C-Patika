 using System;

namespace Diziler
{
    internal class Diziler
    {
        static void Main(string[] args)
        {
           string[] renkler=new string[5];

           string[] hayvanlar={"kedi","köpek","kuş","maymun"};

           int[] dizi;
           dizi=new int[5];


           //Değer atama ve erişim

           renkler[0]="Mavi";
           
           dizi[3]=10;

          Console.WriteLine(hayvanlar[1]);
           Console.WriteLine(dizi[3]);
           Console.WriteLine(renkler[0]);


          //Döngülerle Dizi kullanımı
          //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
          Console.WriteLine("Dizinin eleman sayısını giriniz");
          int diziuzunlugu=int.Parse(Console.ReadLine());
          int[] sayiDizisi=new int[diziuzunlugu];

          for (int i = 0; i < diziuzunlugu; i++)
          {
            Console.Write("{0}.sayıyı giriniz: ",i+1);
            sayiDizisi[i]=int.Parse(Console.ReadLine());
          }

          int Toplam=0;
          foreach (var sayi in sayiDizisi)
          {
            Toplam += sayi;

            Console.WriteLine("Ortalama : "+Toplam/diziuzunlugu);
          }



        }
    }
}