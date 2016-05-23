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
        public List<MagzineDTO> returnMagazines()
        {
            using (var ctx = new Database())
            {
                var obj = from m in ctx.Magzines
                          join f in ctx.Files on m.mag_file_id equals f.file_id
                          join mc in ctx.Magzines_Category on m.mag_cat_id equals mc.mag_cat_id
                          select new RMagzineDTO
                          {
                              name = m.mag_name,
                              file = f.file_path,
                              category = mc.mag_cat_name
                          };
                List<MagzineDTO> list = new List<MagzineDTO>();
                var deptz = obj.GroupBy(x => x.category).ToList();

                foreach (var x in deptz)
                {
                    MagzineDTO deptDto = new MagzineDTO();
                    deptDto.dtos = new List<SMagzineDTO>();
                    foreach (var dto in x)
                    {
                        deptDto.category = dto.category;
                        deptDto.dtos.Add(new SMagzineDTO { file = dto.file, name = dto.name });
                    }
                    list.Add(deptDto);
                }
                return list; 
            }
        }
        public List<RMagzineDTO> Search(string sh)
        {
            using (var ctx = new Database())
            {
                var obj = from m in ctx.Magzines
                          join f in ctx.Files on m.mag_file_id equals f.file_id
                          join mc in ctx.Magzines_Category on m.mag_cat_id equals mc.mag_cat_id
                          where m.mag_name.Contains(sh)
                          select new RMagzineDTO
                          {
                              name = m.mag_name,
                              file = f.file_path,
                              category = mc.mag_cat_name
                          };
                return obj.ToList(); 

            }
        }
    }
}
