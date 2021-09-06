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
             * for (int i = 1; i < lines.length; i++) {
             *  line = lines[i];
             *  
            */

            foreach (String line in lines.Skip(1))
            {
                Console.WriteLine("AAAAA - " + line.Split(',')[1]);
            }
            Console.ReadLine();//Pour afficher le résultat sans fermer la console
        }

        static void Main(string[] args)
        {
            readCsv("../../staff.csv");// par rapport au dossier bin/Debug
        }
    }
}
