using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            // Criando instancia da classe Nokia
            Nokia nokia = new Nokia("123456", "Nokia 7.2", "0987654321", 64);

            // Chamar o metodo Ligar
            nokia.Ligar();

            // Chamar o metodo InstalarAplicativo
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone iPhone:");
            // Criando instancia da classe Iphone
            Iphone iphone = new Iphone("987654", "Iphone 12", "1234567890", 128);

            // Chamar o metodo ReceberLigacao
            iphone.ReceberLigacao();

            // Chamar o metodo InstalarAplicativo
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
