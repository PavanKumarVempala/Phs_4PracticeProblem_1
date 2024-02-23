using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class SchMang
    {
        static List<School> list = new List<School>()
        { 
            new School(){Id=1,TName="Teacher_1",Subject="Subject_1",Salary=12345},
            new School(){Id=1,TName="Teacher_2",Subject="Subject_2",Salary=67890},
            new School(){Id=1,TName="Teacher_3",Subject="Subject_3",Salary=13579}
        };
        public static List<School> allDetails()
        {
            return list;
        }
        public static List<School> getDetailsById(int id) 
        { 
            List<School> serachList=list.FindAll(tech=> tech.Id == id);
            return serachList;
        }
    }
}
