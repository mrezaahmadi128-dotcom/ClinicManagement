using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagement
{
    internal class BimarManager
    {
        private static List<Bimar> bimaran;

        public List<Bimar> GetBimaran()
        {
            return bimaran;
        }

        public void AddBimar(Bimar bimar)
        {
            if (bimaran == null)
                bimaran = new List<Bimar>();

            bimaran.Add(bimar);
        }
    }
}
