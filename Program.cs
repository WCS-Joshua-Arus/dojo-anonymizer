using System;
using System.IO;
using System.Linq;

namespace dojo_anonymizer
{
    class Program
    {
        private static void readCsv(string path)
        {
            string[] lines = File.ReadAllLines(path);

            //Version sans Linq
            /*
             * 
             * string[] headers = lines[0].Split(',');
             * 
             */
            string[] headers = lines.First().Split(',');
            Console.WriteLine(headers[0] + " - " + headers[1]);

            // Version sans Linq
            /* 
             * for (int i = 1; i < lines.Length; i++) {
             *  line = lines[i];
             *  
            */

            foreach (String line in lines.Skip(1))
            {
                string[] columns = line.Split(',');

                Console.Write("AAAAA");
                for (int j = 1; j < columns.Length; j++)
                {
                    Console.Write(" - " + columns[j]);
                }
                Console.WriteLine("");//retour à la ligne !
            }
        }

        static void Main(string[] args)
        {
            readCsv("../../staff.csv");// par rapport au dossier bin/Debug

            Console.WriteLine("");//saut de ligne pour la visibilité

            readCsv("../../students.csv");// par rapport au dossier bin/Debug

            Console.ReadLine();//Pour afficher le résultat sans fermer la console
        }
    }
}
