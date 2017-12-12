using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPNoté2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez un diviseur : (pas trop grand)");
            int multiple = Convert.ToInt32(Console.ReadLine());
            ArrayList l = new ArrayList();
            for (int i = 0; i < 101; i++)
                
                {
                    l.Add(i);
                }
            affiche(filtre(l, (a) => a % multiple == 0), multiple);

            Console.ReadLine();
        }

          static ArrayList filtre(ArrayList array, Func <int , bool> f)
          {
              ArrayList listfiltree = new ArrayList();
              foreach (int i in array)
              if (f((int)i))
              listfiltree.Add(i);
              return listfiltree;
          }

           static void affiche(ArrayList ar, int multiple)
           {
                Console.WriteLine("Multiples de " + multiple);
                foreach (int i in ar)
                Console.WriteLine(i.ToString());
           }
    }
}