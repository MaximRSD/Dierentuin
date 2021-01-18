using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrerriesTuin
{
    class DrerriesController
    {
         DierentuinDataContext db;

        public DrerriesController(DierentuinDataContext db) 
        {
            this.db = db;
        }

        public void addDieren(string Naam, locatie Locatie)
        {
            dieren D = new dieren();
            D.Naam = Naam;
            D.locatie = Locatie;

            db.dierens.InsertOnSubmit(D);
            db.SubmitChanges();
        }

        public void addLocatie(string LocatieNaam) 
        {
            locatie T = new locatie();
            T.LocatieNaam = LocatieNaam;

            db.locaties.InsertOnSubmit(T);
            db.SubmitChanges();
        }

        public void save()
        {
            db.SubmitChanges();
        }

        public List<locatie> allLocaties()
        {
            return db.locaties.ToList();
        }

        public List<dieren> allDieren()
        {
            return db.dierens.ToList();
        }
        public List<history> allHistory()
        {
            return db.histories.ToList();
        }

        public void editDieren(int ID, string Naam, locatie Locatie)
        {
            dieren D = (from dier in db.dierens where dier.ID == ID select dier).Single();

            locatie huidigeLocatie = D.locatie;
            D.Naam = Naam;
            D.locatie = Locatie;

            if (huidigeLocatie != Locatie)
            {
                history H = new history();
                H.dieren = D;
                H.locatie = huidigeLocatie;
                H.Datum = DateTime.Now;
                db.histories.InsertOnSubmit(H);
            }
            db.SubmitChanges();
        }
        public void deleteDieren(dieren dier)
        {
            db.dierens.DeleteOnSubmit(dier);
            db.SubmitChanges();
        }
        public List<dieren> ZoekItem(string sWaarde)
        {
            var lijst = (from dieren in db.dierens
                        where dieren.Naam.Contains(sWaarde) ||
                        dieren.locatie.LocatieNaam.Contains(sWaarde)
                        select dieren).ToList();
            return lijst;
        }
    }
}
