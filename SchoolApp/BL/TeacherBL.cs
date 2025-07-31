using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using SchoolApp.Entities;
using SchoolApp.DAL;

namespace SchoolApp.BL
{
    public class TeacherBL
    {
        private TeacherDal _dal = new TeacherDal();

        public List<Teacher> GetAllTeachers()
        {
            return _dal.GetAllTeachers();
        }
    }
}

