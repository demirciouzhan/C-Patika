using System;

namespace WhileForeach
{
    internal class WhileForeach
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Lütfen Bir sayı giriniz");
          int sayi=int.Parse(Console.ReadLine());
          int sayac=1;
          int Toplam=0;
           while(sayac<= sayi)
           {
            Toplam +=sayac;
            sayac++;
           }
           Console.WriteLine(Toplam/sayi);


             char character='a';
        while(character <'z')
        {
        Console.Write(character);
        character++;
        }

        string[] arabalar={"bmw","ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
          Console.WriteLine(araba);
        }

        }

      
    }
}