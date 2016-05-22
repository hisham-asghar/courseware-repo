using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utility;

namespace DAL
{
    public class MagazineDAL
    {
        public List<Magzine> returnMagazines()
        {
            Database ctx = new Database();
            List<Magzine> m = ctx.Magzines.ToList();
            return m;
        }
        public Object Search(string sh)
        {
            using (var ctx = new Database())
            {


                var obj = from l in ctx.Magzines where l.mag_name.Contains(sh) select new { l.mag_name };
                return obj;

            }
        }
    }
}
