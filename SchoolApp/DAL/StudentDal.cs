using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections.Generic;
using System.Data.SqlClient;
using SchoolApp.Entities;

namespace SchoolApp.DAL
    {
        public class StudentDal
        {
        //private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School.mdf;Integrated Security=True";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Desktop\studies\C#\SchoolApp\SchoolApp\School.mdf;Integrated Security=True;Connect Timeout=30";

        public List<Student> GetAllStudents()
            {
                var students = new List<Student>();

                using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        students.Add(new Student
                        {
                            Id = (int)reader["Id"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["HomePhone"].ToString(),
                            BirthdayYear = reader["BirthdayYear"].ToString(),
                            ClassRoom = reader["Class"].ToString(),

                        });
                    }
                }

                return students;
            }
        }
    }


