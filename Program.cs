using System;

namespace enumm
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine((int)günler.Cumartesi);
        int sıcaklık = 32;
        if(sıcaklık<=Sıcaklık.soğuk)
        {
            Console.WriteLine("hava çok soğuk bekle lütfen")
        }
        else if(sıcaklık>=(int)Sıcaklık.sıcak)
        {
            Console.WriteLine("hava sıcakk kremini unutma")
        }
        else if(sıcaklık>(int)Sıcaklık.ılık && sıcaklık<(int)Sıcaklık.çoksıcak)
        {
            Console.WriteLine("dışarı çıkman için oldukça sıcak")
        }
        }
    }
    enum günler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum Sıcaklık
    {
        soğuk=5,
        ılık=15,
        sıcak= 25,
        çoksıcak= 30
    }
}