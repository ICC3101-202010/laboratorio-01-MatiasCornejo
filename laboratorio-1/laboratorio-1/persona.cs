using System;
namespace laboratorio1
{
    public class persona

    {
        public persona()
        {
            Console.WriteLine("creando objeto");
        }

        public void lanzar()
        {
            Random azar = new Random();
            int numero;
            numero = azar.Next(0, 3);
            Console.WriteLine(numero);
        }
    }
}
