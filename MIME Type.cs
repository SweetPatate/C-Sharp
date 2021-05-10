using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
https://www.codingame.com/ide/puzzle/mime-type
A table associating a MIME type with a file extension is provided. You will also be provided with a list of file names to be transferred and you will have to deduce for each of them, the MIME type to be used.

The extension of a file is defined by the part of the name after the last dot in the file.
If the file extension is present in the association table (case is not important, e.g. TXT is equivalent to txt), then display the corresponding MIME type. If it is not possible to find the MIME type associated with a file, or if the file has no extensions, display UNKNOWN.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        
        Dictionary <string, string> fileExtention = new Dictionary<string, string>();
        List<string> fileName = new List<string>();

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0].ToLower(); // file extension
            string MT = inputs[1]; // MIME type.
            fileExtention.Add(EXT, MT);
        }

        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            FNAME = FNAME.ToLower(); // on retire les majuscules
            if (FNAME.Contains('.'))
            {
                 FNAME = FNAME.Substring(FNAME.LastIndexOf('.')+1); // FNAME = extention
            }
            else
            {
                FNAME = "N/A";
            }
            fileName.Add(FNAME);
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        foreach(string extention in fileName)
        {
            if(extention == "N/A")
            {
                Console.WriteLine("UNKNOWN"); // si aucune extension = "UNKNOWN"
            }
            else if (fileExtention.ContainsKey(extention))
            {
                string MIMETypeToReturn = string.Empty;
                fileExtention.TryGetValue(extention, out MIMETypeToReturn); // Gets the value associated with the specified key.
                Console.WriteLine(MIMETypeToReturn);
            }
            else
            {
                Console.WriteLine("UNKNOWN"); // Si extention inconnue "UNKNOWN"
            }
        } 

        // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
        //Console.WriteLine("UNKNOWN");
    }
}