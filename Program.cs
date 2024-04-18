using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("987654321", "5200", "987-123-654", 128);


            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Instagram");

            Iphone iphone = new Iphone("321654987", "XR", "123-987-456", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Youtube");

            
        }
    }
}