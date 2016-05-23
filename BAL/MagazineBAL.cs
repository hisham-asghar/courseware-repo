using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAL
{
    public class MagazineBAL
    {
        public List<MagzineDTO> returnMagazines()
        {
            MagazineDAL d = new MagazineDAL();
            return d.returnMagazines();
        }
        public List<RMagzineDTO> Search(string sh)
        {
            MagazineDAL d = new MagazineDAL();
            return d.Search(sh);
        }
    }
}
