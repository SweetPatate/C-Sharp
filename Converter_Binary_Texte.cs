using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertisseur
{
    class Convertissor
    {
        static void Main(string[] args)
        {
            string texte = "";
            /*
            texte = @"Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It's not a story the Jedi would tell you. It's a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life... He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful... the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.";
            
            string a = StringToBinary(texte);
            Console.WriteLine(StringToBinary(texte));
            Console.WriteLine(BinaryToString(a));
            Console.ReadLine();
            */
            
            bool a = true;
            while (a)
            {
                Console.WriteLine("T to transform your message into binary \nB to transform the binary message into text");
                Console.Write("Insert [T/B] :");
                string x = Console.ReadLine();
                if (x == "t" | x == "T")
                {
                    Console.WriteLine("\nInsert your text message to convert :");
                    texte = Console.ReadLine();
                    Console.WriteLine(StringToBinary(texte) + "\n");
                }
                else if (x == "b" | x == "B")
                {
                    Console.WriteLine("\nInsert your binary message to convert :");
                    texte = Console.ReadLine();
                    Console.WriteLine(BinaryToString(texte) + "\n");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            
        }

        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public static string BinaryToString(string texte)
        {
            // use your encoding here
            Encoding enc = System.Text.Encoding.ASCII;

            string binaryString = texte.Replace(" ", "");

            var bytes = new byte[binaryString.Length / 8];

            var ilen = (int)(binaryString.Length / 8);

            for (var i = 0; i < ilen; i++)
            {
                bytes[i] = Convert.ToByte(binaryString.Substring(i * 8, 8), 2);
            }

            string str = enc.GetString(bytes);

            return str;

        }
    }
}
