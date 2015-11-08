using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    class Program
    {
        static void Main(string[] args)
        {
            ComandoUtente cmd = null;
            bool uscita = false;
            do
            {
                cmd = new ComandoUtente(Prompt());
                switch (cmd.Nome)
                {
                    case "EXIT": uscita = true; break;
                }
            }
            while (!uscita);

        }
        static string Prompt()
        {
            Console.Write("\n>> ");
            return Console.ReadLine();
        }
    }
}
