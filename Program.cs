using NBA_League_Romania.Repository.FIleRepositories;
using NBA_League_Romania.ServiceFolder;
using NBA_League_Romania.UIFolder;

namespace NBA_League_Romania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElevFile elevFile = new ElevFile("elevi.txt");
            EchipaFile echipaFile = new EchipaFile("echipe.txt");
            JucatorFile jucatorFile = new JucatorFile(echipaFile, "jucatori.txt");
            MeciFile meciFile = new MeciFile(echipaFile, "meciuri.txt");
            JucatorActivFile jucatorActivFile = new JucatorActivFile("jucatoriActivi.txt");

            Service service = new Service(echipaFile, elevFile, jucatorFile, meciFile, jucatorActivFile);

            Console.WriteLine("Jucatorii echipei Houston Rockets: ");
            foreach (var jucator in service.JucatoriiEchipeiX(echipaFile.FindOne(Guid.Parse("860f0b2c-7fdf-48ac-b611-5eaecfee7f45"))))
            {
                Console.WriteLine(jucator.Name + " , " + jucator.School);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Jucatorii activi ai echipei New York Knicks in meciul cu Atlanta Hawks din 12/20/2018 sunt: ");
            foreach (var jucator in 
                service.JucatoriiActiviAiUneiEchipeDeLaMeciulX(
                     echipaFile.FindOne(Guid.Parse("03e579f0-1c89-4d40-9226-425206b130e1"))
                    ,meciFile.FindOne(Guid.Parse("444dc51f-717a-4b2e-9f6b-f1f42c9aedc6"))))
            {
                Console.WriteLine(jucator.Name + " , " + jucator.School);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Meciurile din perioada 12/20/2018 - 10/01/2022");
            foreach (var meci in
                service.MeciuriDinPerioadaX(DateTime.Parse("12/20/2018"), DateTime.Parse("10/01/2022")))
            {
                Console.WriteLine(meci.Echipa1.Name + " vs " + meci.Echipa2.Name + " din " + meci.Date);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Scorul meciului dintre Atlanta Hawks si New York Knicks din 12/20/2018 este: " +
                service.ScorulUnuiMeci(meciFile.FindOne(Guid.Parse("444dc51f-717a-4b2e-9f6b-f1f42c9aedc6"))));

            UI console = new UI(service);
            console.run();
        }
    }
}