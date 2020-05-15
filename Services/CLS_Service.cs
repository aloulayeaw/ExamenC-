using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.Services
{
    class CLS_Service
    {
        private dbgestionemployeContext db = new dbgestionemployeContext();
        private Service_Emp S;

        public bool Add_Service(string libelle, int nbreEm)
        {
            S = new Service_Emp();
            S.Libelle = libelle;
            S.NbrEmploye = nbreEm;
            if(db.Service_Emp.SingleOrDefault(s=>s.Libelle==libelle && S.NbrEmploye==nbreEm) == null)
            {
                db.Service_Emp.Add(S);
                db.SaveChanges();
                return true;
            }else
            {
                return false;
            }
        }
    }
}
