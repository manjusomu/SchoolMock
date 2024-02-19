using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class SchoolManagement
    {
        static List<School> list = new List<School>()
        {
           new School(){StuId=1,StuName="Harish",TeacherName="Divya",SubName="Science"},
           new School(){StuId=2,StuName="Shyam",TeacherName="Merlin",SubName="Maths"},
          new School(){StuId=3,StuName="Prabha",TeacherName="Deepa",SubName="Chemistry"},
          new School(){StuId=4,StuName="Vidhya",TeacherName="Nandhini",SubName="Physics"},
          new School(){StuId=5,StuName="Gowtham",TeacherName="Prabhu",SubName="Social"},



        };
        public List<School> Allstulist()
        {
            return list;
        }
        public List<School> SearchStu(int id)
        {
            List<School> searchlist = list.FindAll(s => s.StuId == id);
            return searchlist;

        }
        public virtual bool StudentMarks()
        {
            return false;
        }
    }
}
