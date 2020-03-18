using System;
namespace laboratorio1
{
    public class persona

    {
        public persona()//aqui creo un constructor para darle el nombre 
        {
            Console.WriteLine("bob kunga");
        }

        public void lanzar()//aqui creo el metodo "lanzar"
        {
            Random azar = new Random();
            int numero;
            numero = azar.Next(0, 3);
            Console.WriteLine(numero);
        }
    }
}
