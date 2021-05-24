using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice to understand get/set and override !\n");

            Movies the_Butterfly_Effect = new Movies();

            the_Butterfly_Effect.Name = "The Butterfly Effect";
            the_Butterfly_Effect.Genre = "Sci-Fi, Thriller";
            the_Butterfly_Effect.RealeaseDate = new DateTime(2004 ,10, 4);
            Console.WriteLine(the_Butterfly_Effect);



            Movies sharknado = new Movies();

            sharknado.Name = "Sharknado";
            sharknado.Genre = "Horror, Sci-Fi";
            sharknado.RealeaseDate = new DateTime(2013, 7, 1);
            Console.WriteLine(sharknado);




            Movies winnie_the_pooh = new Movies();

            winnie_the_pooh.Name = "Winnie the Pooh";
            winnie_the_pooh.Genre = "Animation, Adventure, Comedy";
            winnie_the_pooh.RealeaseDate = new DateTime(2011, 4, 13);
            Console.WriteLine(winnie_the_pooh);

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue ...");
                Console.ReadLine();
            }
        }
    }
}
