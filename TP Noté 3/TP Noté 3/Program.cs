using System;
using System.Collections.Generic;

namespace TPNoté3
{
    class Program
    {
        delegate void dl(string str ,List<string> list);
        
        static void Main(string[] args)
        {
            List<string> listcap = new List<string>()
            {
                "Paris",
                "Madrid",
                "Londres",
                "Rome",
                "Genève",
                "Dublin",
                "Moscou",
                "Zurich",
                "Prague"
            };dl belvedere = (chaine, capitale) =>

            {
                Console.WriteLine("Capitales contenant '" + chaine + "'.");
                foreach (string contain in capitale)
                {
                    if (contain.ToUpper().Contains(chaine.ToUpper()))
                    {
                        Console.WriteLine(contain);
                    }
                }
            };
            Console.WriteLine("Rentrez la chaîne que doivent contenir les capitales :");
            belvedere(Console.ReadLine(), listcap);

        } 
    }  
}