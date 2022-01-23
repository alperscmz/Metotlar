using System;
namespace Metotlar
{
    class Program
    {
        static void Main(string[]args)
        {
         //Erişim_beliteci geri_dönüş_tipi metot_adi parametre_listesi/arguman

         int a=2;
         int b=3;

         Console.WriteLine(a+b);

         int sonuc=Topla(a,b);
         
         Console.WriteLine(sonuc);

          metotlar ornek=new metotlar();
          ornek.EkranaYazdir(Convert.ToString(sonuc)); 


          int sonuc2=ornek.ArttırVeTopla(ref a,ref b);
           ornek.EkranaYazdir(Convert.ToString(sonuc2)); 
          ornek.EkranaYazdir(Convert.ToString(a+b)); 
        }
        static int Topla( int deger1,int deger2)
        {
            return (deger1+deger2);
        }
    }
    class metotlar
    {
     public  void EkranaYazdir(string var1)
        {
             Console.WriteLine(var1);
        }
        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}