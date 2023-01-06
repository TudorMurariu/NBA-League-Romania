using NBA_League_Romania.Domain;
using NBA_League_Romania.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League_Romania.ServiceFolder
{
    internal class Service
    {
        private IRepository<Guid, Echipa> echipe;
        private IRepository<Guid, Elev> elevi;
        private IRepository<Guid, Jucator> jucatori;
        private IRepository<Guid, Meci> meciuri;
        private IRepository<Guid, JucatorActiv> jucatoriActivi;

        public Service(IRepository<Guid, Echipa> echipe, IRepository<Guid, Elev> elevi, IRepository<Guid, Jucator> jucatori, IRepository<Guid, Meci> meciuri, IRepository<Guid, JucatorActiv> jucatoriActivi)
        {
            this.echipe = echipe;
            this.elevi = elevi;
            this.jucatori = jucatori;
            this.meciuri = meciuri;
            this.jucatoriActivi = jucatoriActivi;
        }

        public IEnumerable<Jucator> JucatoriiEchipeiX(Echipa echipa)
        {
            return jucatori.FindAll().Where(j =>
            {
                Jucator jucator = (Jucator)j;
                return j.Echipa.Equals(echipa);
            });
        }

        public IEnumerable<Jucator> JucatoriiActiviAiUneiEchipeDeLaMeciulX(Echipa echipa, Meci meci)
        {
            return
                from jucatorActiv in jucatoriActivi.FindAll()
                join jucator in jucatori.FindAll()
                on jucatorActiv.IdJucator equals jucator.Id
                where jucatorActiv.IdMeci == meci.Id && jucator.Echipa.Id == echipa.Id
                select jucator;
        }

        public IEnumerable<Meci> MeciuriDinPerioadaX(DateTime beginingDate, DateTime endingDate)
        {
            return
                from meci in meciuri.FindAll()
                where meci.Date >= beginingDate && meci.Date <= endingDate
                select meci;
        }

        public string ScorulUnuiMeci(Meci meci)
        {
            int scorEchipa1 = 0;
            try
            {
                scorEchipa1 =
                (from jucatorActiv in jucatoriActivi.FindAll()
                 join jucator in jucatori.FindAll()
                 on jucatorActiv.IdJucator equals jucator.Id
                 join echipa in echipe.FindAll()
                 on jucator.Echipa.Id equals echipa.Id
                 where jucatorActiv.IdMeci == meci.Id
                        && meci.Echipa1.Id == echipa.Id
                 select jucatorActiv.NrPuncteInscrise).Sum();
            }catch{}

            int scorEchipa2 = 0;
            try
            {
                scorEchipa2 =
                (from jucatorActiv in jucatoriActivi.FindAll()
                 join jucator in jucatori.FindAll()
                 on jucatorActiv.IdJucator equals jucator.Id
                 join echipa in echipe.FindAll()
                 on jucator.Echipa.Id equals echipa.Id
                 where jucatorActiv.IdMeci == meci.Id
                        && meci.Echipa2.Id == echipa.Id
                 select jucatorActiv.NrPuncteInscrise).Sum();
            }
            catch{}

            return scorEchipa1.ToString() + " - " + scorEchipa2.ToString(); 
        }

    }
}
