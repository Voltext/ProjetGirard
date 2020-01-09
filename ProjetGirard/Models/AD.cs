using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGirard.Models
{
    public class AD
    {
        private BDChantierBricchiEntities db;

        public AD()
        {
            db = new BDChantierBricchiEntities();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<Client> TousLesClients()
        {
            return db.Clients.ToList();
        }
    }
}