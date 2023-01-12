using NBA_League_Romania.Domain;
using NBA_League_Romania.Repository.FIleRepositories;
using NBA_League_Romania.ServiceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.UIFolder
{
    internal class UI
    {
        private Service service;
        public UI(Service service)
        { 
            this.service = service;
        }

        private Guid readId()
        {
            Console.WriteLine("Id-ul :");
            return Guid.Parse(Console.ReadLine());
        }

        private DateTime readDate()
        {
            Console.WriteLine("Data :");
            return DateTime.Parse(Console.ReadLine());
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
                    Echipa e;
                    Meci m;
                    switch (cmd)
                    {
                        case 0:
                            return;
                        case 1:
                            e = service.findEchipa(readId());
                            Console.WriteLine($"Jucatorii echipei {e.Name} sunt:");
                            foreach (var jucator in service.JucatoriiEchipeiX(e))
                                Console.WriteLine(jucator.Name + " , " + jucator.School);
                            break;
                        case 2:
                            e = service.findEchipa(readId());
                            m = service.findMeci(readId());
                            Console.WriteLine($"Jucatorii activi ai echipei {e.Name} din meciul din {m.Date} sunt:");
                            foreach (var jucator in
                                service.JucatoriiActiviAiUneiEchipeDeLaMeciulX(e, m))
                            {
                                Console.WriteLine(jucator.Name + " , " + jucator.School);
                            }
                            break;
                        case 3:
                            DateTime d1 = readDate();
                            DateTime d2 = readDate();
                            foreach (var meci in
                                service.MeciuriDinPerioadaX(d1, d2))
                            {
                                Console.WriteLine(meci.Echipa1.Name + " vs " + meci.Echipa2.Name + " din " + meci.Date);
                            }
                            break;
                        case 4:
                            m = service.findMeci(readId());
                            Console.WriteLine($"Scorul meciului dintre {m.Echipa1} si {m.Echipa2} din 12/20/2018 este: " +
                service.ScorulUnuiMeci(m));
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
