using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donus_tipi  metot_adi(paremetrelistesi||arguman)
            //{
                ////komutlar;
                //return;
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc=topla(a,b);
            Console.WriteLine(sonuc);
            
            metotlar ornek = new metotlar();
            ornek.ekranayazdir(Convert.ToString(sonuc));

        }

        static int topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }
    }
    class metotlar
    {
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
    }
}
