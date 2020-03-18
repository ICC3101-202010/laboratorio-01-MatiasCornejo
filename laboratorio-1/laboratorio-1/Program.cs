using System;

namespace laboratorio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            persona m= new persona(); //llamo a la clase creada de persona
            m.lanzar();  //ocupo el metodo creado para la clase de persona
            Console.ReadKey();
        }
    }
}
