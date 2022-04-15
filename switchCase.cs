using System;

namespace switchCase
{
  class switchCase
  {
    static void Main(string[]args)
    {
      int month=DateTime.Now.Month;

      switch(month)
      {
        case 1:
          Console.WriteLine("ocak ayındasınız");
          break;
        case 2:
          Console.WriteLine("Şubat ayındasınız");
          break;
         case 3:
          Console.WriteLine("Mart ayındasınız");
          break;
        case 4:
          Console.WriteLine("Nisan ayındasınız");
          break;
        case 5:
          Console.WriteLine("Mayıs ayındasınız");
          break;  
      }

      switch(month)
      {
        case 12:
        case 1:
        case 2:
          Console.WriteLine("kış ayındasınız");
          break;
        case 3:
        case 4:
        case 5:
          Console.WriteLine("ilkbahar ayındasınız");
          break;  

        case 6:
        case 7:
        case 8:
          Console.WriteLine("Yaz ayındasınız ayındasınız");
          break;  
        case 9:
        case 10:
        case 11:
          Console.WriteLine("Sonbahar ayındasınız");
          break;    

      }
    }

  }
}