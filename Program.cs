using System.Diagnostics;

internal class Program
{
    enum secimler
    {
        Toplama=1, //eğer her angi bir sayıya eğitlenmezse index 0 dan başlar
        Cikarma=2,
        Carpma=3,
        Bolme=4
    }
    private static void Main(string[] args)
    {
        //SwitchKullanımOrnegi();

        SwitcKullanimiRandomOrnegi();
        Console.ReadKey();

    }

    private static void SwitcKullanimiRandomOrnegi()
    {
        int A = 20;
        int B = 10;
        secimler secim = (secimler)(new Random().Next(1, 5));
        switch (secim)
        {
            case secimler.Toplama:
                Console.WriteLine($"{A}+{B}={A + B}");
                break;
            case secimler.Cikarma:
                Console.WriteLine($"{A}-{B}={A - B}");
                break;
            case secimler.Carpma:
                Console.WriteLine($"{A}*{B}={A * B}");
                break;
            case secimler.Bolme:
                Console.WriteLine($"{A}/{B}={A / B}");
                break;
            default:
                break;
        }
    }

    private static void SwitchKullanımOrnegi()
    {
        int A = 20;
        int B = 10;
        secimler secim = secimler.Toplama;//Sayı verilebileceği gibi enum listesinden değer de verilebilir"(secimler)1" yazılsa da olurdu
        switch (secim)
        {
            case secimler.Toplama:
                Console.WriteLine($"{A}+{B}={A + B}");
                break;
            case secimler.Cikarma:
                Console.WriteLine($"{A}-{B}={A - B}");
                break;
            case secimler.Carpma:
                Console.WriteLine($"{A}*{B}={A * B}");
                break;
            case secimler.Bolme:
                Console.WriteLine($"{A}/{B}={A / B}");
                break;
            default:
                break;
        }
    }
}