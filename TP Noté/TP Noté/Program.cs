using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPNoté
{
    static class ExtensionClass
    {
        public static void AfficheContenu(this ArrayList l)
        {
            foreach (int i in l) Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList l = new ArrayList();
            for(int i = 0; i < 101; i++)
            {
                l.Add(i);
            }
            l.AfficheContenu();
        }
    }
}