using Entities;
using System;
using System.Collections.Generic;
using DAL;


namespace BAL
{
    public class LectureBAL
    {
        LectureDAL dal = new LectureDAL();
        public List<Cours> returnLecByCourseNo()
        {
            return dal.returnLecByCourseNo();
        }
        public List<Department> getDepts()
        {
            return dal.getDepts();
        }
        public Dictionary<KeyValuePair<String,String>,int> Search(string sh)
        {
            return dal.Search(sh);
        }
    }
}
