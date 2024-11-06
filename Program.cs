using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111222333444555", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone("7891011", "iPhone 13", "555666777888999", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
