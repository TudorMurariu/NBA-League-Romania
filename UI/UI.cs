using NBA_League_Romania.ServiceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.UI
{
    internal class UI
    {
        private Service service;
        public UI(Service service)
        { 
            this.service = service;
        }
        public void run()
        {
           while(true)
           {
                Console.WriteLine("\n");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Comenzile sunt :");
                Console.WriteLine("0 - exit");
                Console.WriteLine("1 - afisam toti jucatori unei echipe date");
                Console.WriteLine("2 - afisam toti jucatorii activi ai unei echipe de la un anumit meci");
                Console.WriteLine("3 - sa se afiseze toate meciurile dintr-o anumita perioada calendaristica");
                Console.WriteLine("4 - sa se afiseze scorul de la un anumit meci");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("\n");

                Console.Write("Dati o comanda : ");
                try
                {
                    int cmd = int.Parse(Console.ReadLine());
                    switch (cmd)
                    {
                        case 0:
                            return;
                        case 1:
                            break;

                    }
                }
                catch {
                    Console.WriteLine("Va rugam sa introduceti o comanda valida!");
                }
            }
        }
    }
}
