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
        public class StudentBL
        {
            private StudentDal _dal = new StudentDal();

            public List<Student> GetAllStudents()
            {
                return _dal.GetAllStudents();
            }
        }
    }



